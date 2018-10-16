using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PS.Plot.FrameBasic.Module_Common.Interface;
using TechniqueMaster.Module_Technique.Controller;
using DevExpress.XtraScheduler;

namespace TechniqueMaster.Module_Technique.View.Frm
{
    public partial class Frm_TechniqueDetialScheduler : DevExpress.XtraEditors.XtraForm,IInitialUI
    {
        public int CurrentTechID { get; set; }

        private TechniqueMisssionController controller_mission;
        private TechniqueLogController controller_log;
        private TechniqueController controller_tech;

        public Frm_TechniqueDetialScheduler()
        {
            InitializeComponent();
        }

        private void Frm_TechniqueDetialScheduler_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            controller_mission = new TechniqueMisssionController();
            controller_log = new TechniqueLogController();
            controller_tech = new TechniqueController();
            controller_tech.CurrentID = CurrentTechID;
            controller_tech.LoadEntry();
        }

        public void onInitialUI()
        {
            this.schedulerStorage1.Appointments.Clear();

            foreach (var missionItem in controller_mission.QueryEntriesByTechniquID(CurrentTechID))
            {
                foreach (var logItem in controller_log.QueryEntiesByMissionID((int)missionItem.ID))
                {
                    Appointment appoint = this.schedulerStorage1.CreateAppointment(AppointmentType.Normal);
                    appoint.Subject = logItem.Context;
                    appoint.Description = "" + logItem.ID;
                    appoint.Start = DateTime.Parse(logItem.Date);
                    appoint.AllDay = true;
                    schedulerStorage1.Appointments.Add(appoint);
                }
            }

            tv_TechName.Text = controller_tech.Entry.Name;

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

        private void schedulerControl1_EditAppointmentFormShowing_1(object sender, AppointmentFormEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Appointment.Description))
            {
                e.Handled = true;
                return;
            }
            Frm_TechniqueLogEdit form = new Frm_TechniqueLogEdit();
            form.LogID = int.Parse(e.Appointment.Description);
            form.IsReadOnly = true;
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


    }
}