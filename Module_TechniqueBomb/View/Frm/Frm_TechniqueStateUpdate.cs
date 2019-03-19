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
using TechniqueMaster.Module_TechniqueBomb.Componet.Adapter;
using TechniqueMaster.Module_TechniqueBomb.Controller;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using TechniqueMaster.Module_TechniqueBomb.Component.Enum;
using PS.Plot.FrameBasic.Module_Common.Utils;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace TechniqueMaster.Module_TechniqueBomb.View.Frm
{
    public partial class Frm_TechniqueStateUpdate : DevExpress.XtraEditors.XtraForm
    {
        public string TechniqueID { get; set; }
        private TechniqueController controller;
        private GridControlHelper gridHelper;
        private TB_TechniqueMissionStateAdapter adapter;
        private TB_TechniqueMissionStateBuilder builder;

        public Frm_TechniqueStateUpdate()
        {
            InitializeComponent();
        }

        private void Frm_TechniqueStateUpdate_Load(object sender, EventArgs e)
        {
            controller = new TechniqueController();
            controller.CurrentObjectID = TechniqueID;
            controller.LoadEntry();

            tv_MissionName.Text = controller.Entry.Name;
            tv_State.Text = controller.Entry.Status;

            gridHelper = new GridControlHelper(this.gridView1, this.gridControl1);
            
            adapter = new TB_TechniqueMissionStateAdapter();
            builder = new TB_TechniqueMissionStateBuilder();
            adapter.Initial(builder);
            adapter.NotifyfreshDataTable(new TechniqueMissionController().FindMissionByTechniqueID(controller.CurrentObjectID));

            gridHelper.GridControl.DataSource = adapter.ResultTable;
            gridHelper.SetAllColumnEditable(false);
            gridHelper.SetAllColumnVisible(false);
            gridHelper.SetColunmOption(builder.Cal_IsFinish, false, true);
            gridHelper.SetColunmOption(builder.FinishDate, false, true);
            gridHelper.SetColunmOption(builder.CreateDate, false, true);
            gridHelper.SetColunmOption(builder.Name, false, true);
            gridHelper.Group(builder.Cal_IsFinish);
            gridHelper.GridView.ExpandAllGroups();
            gridHelper.GridView.GroupFormat = "{1}";
        }
        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if (adapter.IsAllMissionFinish())
            {
                controller.Entry.Status = new EnumUtils().GetEnumdescription(TechniqueStatusEnum.Finish);
                onUpdateTechniqueState();
            }
            else
                MessageBoxHelper.ShowDialog("提示", "当前技能还有任务没有完成");
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            controller.Entry.Status = new EnumUtils().GetEnumdescription(TechniqueStatusEnum.Start);
            onUpdateTechniqueState();
        }


        private void btn_Pause_Click(object sender, EventArgs e)
        {
            controller.Entry.Status = new EnumUtils().GetEnumdescription(TechniqueStatusEnum.Pause);
            onUpdateTechniqueState();
        }

        private void btn_Abandon_Click(object sender, EventArgs e)
        {
            controller.Entry.Status = new EnumUtils().GetEnumdescription(TechniqueStatusEnum.Abandon);
            onUpdateTechniqueState();
        }

        private void onUpdateTechniqueState()
        {
            if (controller.UpdateEntry())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }
    }
}