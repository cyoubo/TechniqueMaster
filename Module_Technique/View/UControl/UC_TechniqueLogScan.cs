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
            foreach (var item in controller.TravleAllEntities())
            {
                Appointment appoint = this.schedulerStorage1.CreateAppointment(AppointmentType.Normal);
                appoint.Subject = item.Context;
                appoint.Start = DateTime.Parse(item.Date);
                appoint.AllDay = true;
                schedulerStorage1.Appointments.Add(appoint);
            }
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            return;
        }
    }
}
