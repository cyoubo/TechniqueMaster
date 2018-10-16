using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PS.Plot.FrameBasic.Module_Common.Interface;
using TechniqueMaster.Module_Technique.Controller;
using DevExpress.XtraScheduler;
using PS.Plot.FrameBasic.Module_Common.Utils;
using TechniqueMaster.Module_Technique.View.Frm;

namespace TechniqueMaster.Module_Technique.View.UControl
{
    public partial class UC_TechniqueLogScan : DevExpress.XtraEditors.XtraUserControl,IInitialUI
    {
        private TechniqueLogController controller;
        
        public UC_TechniqueLogScan()
        {
            InitializeComponent();
        }

        private void UC_TechniqueLogScan_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            controller = new TechniqueLogController();
            this.schedulerControl1.Start = new DateUtils().MonthFirstDay(DateTime.Now);
        }

        public void onInitialUI()
        {
            this.schedulerStorage1.Appointments.Clear();
            foreach (var item in controller.TravleAllEntities())
            {
                Appointment appoint = this.schedulerStorage1.CreateAppointment(AppointmentType.Normal);
                appoint.Subject = item.Context;
                appoint.Description = ""+item.ID;
                appoint.Start = DateTime.Parse(item.Date);
                appoint.AllDay = true;
                schedulerStorage1.Appointments.Add(appoint);
            }
        }

        private void schedulerControl1_EditAppointmentFormShowing_1(object sender, AppointmentFormEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Appointment.Description))
            {
                e.Handled = true;
                return;
            }
            Frm_TechniqueLogEdit form = new Frm_TechniqueLogEdit();
            form.LogID = int.Parse(e.Appointment.Description);
            try
            {
                e.DialogResult = form.ShowDialog();
                if (e.DialogResult == DialogResult.OK)
                    onInitialUI();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }
        }

        private void schedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            SchedulerControl control = this.schedulerControl1;
            if (e.Menu.Id == DevExpress.XtraScheduler.SchedulerMenuItemId.DefaultMenu)
            {
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.GotoDate);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.GotoToday);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringEvent);
            }

            if (e.Menu.Id == DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu)
            {
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.OpenAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.DeleteAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.LabelSubMenu);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.EditSeries);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu);
            }
        }
    }
}
