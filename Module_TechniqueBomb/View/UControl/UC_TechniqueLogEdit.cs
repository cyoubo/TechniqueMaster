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
using DevExpress.XtraScheduler;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_Common.Utils;
using TechniqueMaster.Module_TechniqueBomb.View.Frm;
using TechniqueMaster.Module_TechniqueBomb.Controller;

namespace TechniqueMaster.Module_TechniqueBomb.View.UControl
{
    public partial class UC_TechniqueLogEdit : DevExpress.XtraEditors.XtraUserControl,IInitialUI
    {
        private TechniqueLogController controller;

        public UC_TechniqueLogEdit()
        {
            InitializeComponent();
        }

        private void UC_TechniqueLog_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }


        public void onCreateComponet()
        {
            controller = new TechniqueLogController();
        }

        public void onInitialUI()
        {
            this.dateE_Start.DateTime = new DateUtils().MonthFirstDay(DateTime.Now.Date);
            this.dateE_End.DateTime = new DateUtils().MonthLastDay(DateTime.Now.Date);
            this.btn_Refresh.PerformClick();
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            e.Handled = true;
            if (string.IsNullOrEmpty(e.Appointment.Subject))
            {
                Frm_TechniqueLogInput frm = new Frm_TechniqueLogInput();
                frm.CurrentDate = e.Appointment.Start;
                if (DialogResult.OK == frm.ShowDialog())
                {
                    onInitialUI();
                }
            }
            else
            {
                Frm_TechniqueLogUpdate frm = new Frm_TechniqueLogUpdate();
                frm.LogObject = e.Appointment.Id;
                if (DialogResult.OK == frm.ShowDialog())
                {
                    onInitialUI();
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            this.schedulerStorage1.Appointments.Clear();
            foreach (var item in controller.FindLogBetweenDate(this.dateE_Start.DateTime,this.dateE_End.DateTime))
            {
                Appointment appoint = this.schedulerStorage1.Appointments.CreateAppointment(AppointmentType.Normal);
                appoint.AllDay = true;
                appoint.Start = DateTime.Parse(item.Date.iso).Date;
                appoint.Subject = item.Context;
                appoint.SetId(item.objectId);
                appoint.LabelKey = item.IsNeedTidy.Get() ? 10 : 0;
                this.schedulerStorage1.Appointments.Add(appoint);
            }
            this.schedulerControl1.Start = dateE_Start.DateTime;
        }

        private void schedulerControl1_CustomDrawAppointmentBackground(object sender, CustomDrawObjectEventArgs e)
        {
           
        }

        private void schedulerControl1_CustomDrawAppointment(object sender, CustomDrawObjectEventArgs e)
        {
            
        }




    }
}
