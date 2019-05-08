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
using TechniqueMaster.Module_TechniqueBomb.Controller;
using TechniqueMaster.Module_TechniqueBomb.Componet.Adapter;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace TechniqueMaster.Module_TechniqueBomb.View.Frm
{
    public partial class Frm_TechniqueLogUpdate : DevExpress.XtraEditors.XtraForm,IInitialUI
    {
        public object LogObject { get; set; }

        private TechniqueLogController controller;

        public Frm_TechniqueLogUpdate()
        {
            InitializeComponent();
        }

        private void Frm_TechniqueLogUpdate_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            controller = new TechniqueLogController();
            controller.CurrentObjectID = LogObject.ToString();
            controller.LoadEntry();
        }

        public void onInitialUI()
        {
            tv_Context.Text = controller.Entry.Context;
            tv_Url.Text = controller.Entry.LogUrl;
            tv_date.Text = TechniqueLogController.FormatBmobDate(controller.Entry.Date);
            cke_IsNeedTidy.Checked = controller.Entry.IsNeedTidy.Get();

            TB_TechniqueMissionAdapter missionAdapter = new TB_TechniqueMissionAdapter();
            TB_TechniqueMissionBuilder missionBuilder = new TB_TechniqueMissionBuilder();
            missionAdapter.Initial(missionBuilder);
            missionAdapter.NotifyfreshDataTable(new TechniqueMissionController().FindUnFinishMission());
            sle_Mission.Properties.DataSource = missionAdapter.ResultTable;
            //若没有设置列名绑定，则此处需要手工通知数据源重绑定，否则sle_Mission.Properties.View.Columns中将不会有值
            sle_Mission.Properties.PopulateViewColumns();
            sle_Mission.Properties.DisplayMember = missionBuilder.Name;
            sle_Mission.Properties.ValueMember = missionBuilder.ObjectID;
            for (int index = 0; index < sle_Mission.Properties.View.Columns.Count; index++)
                sle_Mission.Properties.View.Columns[index].Visible = false;
            sle_Mission.Properties.View.Columns[missionBuilder.Name].Visible = true;
            sle_Mission.Properties.View.Columns[missionBuilder.TechinqueName].Visible = true;
            //选择默认值,使用valueMember列中的值，而不是直接设置Text值
            sle_Mission.EditValue = controller.Entry.MissionID;
        }

        private void btn_goto_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tv_Url.Text) == false)
                System.Diagnostics.Process.Start("chrome.exe", tv_Url.Text);  
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            controller.Entry.MissionID = sle_Mission.EditValue.ToString();
            controller.Entry.Context = tv_Context.Text;
            controller.Entry.LogUrl = tv_Url.Text;
            controller.Entry.IsNeedTidy = cke_IsNeedTidy.Checked;

            if (controller.UpdateEntry())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBoxHelper.ShowDeleteInfoDialog() == DialogResult.Yes)
            {
                if (controller.DeleteByObjectID(LogObject.ToString()))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBoxHelper.ShowDeleteStateDialog(false);
            }
        }

        
    }
}