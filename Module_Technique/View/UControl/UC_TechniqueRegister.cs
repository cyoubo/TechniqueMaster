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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using TechniqueMaster.Module_Technique.Componet.Adapter;
using TechniqueMaster.Module_Technique.Controller;
using PS.Plot.FrameBasic.Module_Common.Interface;
using TechniqueMaster.Module_Technique.Componet.Enum;
using PS.Plot.FrameBasic.Module_Common.Utils;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace TechniqueMaster.Module_Technique.View.UControl
{
    public partial class UC_TechniqueRegister : DevExpress.XtraEditors.XtraUserControl,IInitialUI,IValidateInput2
    {
        private GridControlHelper gridHelper;
        private TB_TechniqueBuilder builder;
        private TB_TechniqueAdapter adapter;
        private TechniqueController controller_tech;
        private TechniqueRegisterController controller_regist;

        public UC_TechniqueRegister()
        {
            InitializeComponent();
        }

        private void UC_TechniqueRegister_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_TechniqueBuilder();
            adapter = new TB_TechniqueAdapter();
            controller_regist = new TechniqueRegisterController();
            controller_tech = new TechniqueController();
            gridHelper = new GridControlHelper(gridView_Tech, gridControl_Tech);

            controller_regist.CurrentID = 0;
            controller_tech.CurrentID = 0;
            controller_regist.LoadEntry();
            controller_tech.LoadEntry();
        }

        public void onInitialUI()
        {
            if (adapter != null)
                adapter.NotifyClearTable();

            adapter.Initial(builder);
            adapter.NotifyfreshDataTable(controller_tech.TravleAllEntities());
            gridHelper.GridControl.DataSource = adapter.ResultTable;
            gridHelper.SetAllColumnVisible(false);
            gridHelper.SetColunmOption(builder.Name, false, true);
            gridHelper.SetColunmOption(builder.Status, false, true);
            gridHelper.Group(builder.Status);
            gridHelper.GridView.ExpandAllGroups();
            gridHelper.GridView.GroupFormat = "{1}";

            dateE_Date.DateTime = DateTime.Now.Date;
            tv_Introspection.Text = "";
            tv_Reason.Text = "";
            tv_Status.Text = "";
            tv_Summary.Text = "";
            tv_Name.Text = "";
            btn_sure.Enabled = false;
        }


        private void gridView_Tech_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            //获得选中的任务编号
            controller_tech.CurrentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            //依据状态判断右键哪些菜单可以显示
            string currentStatus = gridHelper.getFocuseRowCellValue_String(builder.Status);
            EnumUtils utils = new EnumUtils();
            if(currentStatus.Equals(utils.GetEnumdescription(TechniqueStatusEnum.Create)))
            {
                barBtn_Start.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barBtn_Pause.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtn_Finish.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtn_Abandon.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else if (currentStatus.Equals(utils.GetEnumdescription(TechniqueStatusEnum.Start)))
            {
                barBtn_Start.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtn_Pause.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barBtn_Finish.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barBtn_Abandon.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else if (currentStatus.Equals(utils.GetEnumdescription(TechniqueStatusEnum.Pause)))
            {
                barBtn_Start.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barBtn_Pause.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtn_Finish.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barBtn_Abandon.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else if (currentStatus.Equals(utils.GetEnumdescription(TechniqueStatusEnum.Finish)))
            {
                barBtn_Start.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barBtn_Pause.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtn_Finish.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtn_Abandon.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                barBtn_Start.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barBtn_Pause.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtn_Finish.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barBtn_Abandon.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            //显示右键菜单
            popupMenu1.ShowPopup(Control.MousePosition);  
        }

        private void onReIntialController(TechniqueStatusEnum status)
        {
            controller_tech.LoadEntry();
            controller_tech.Entry.Status = new EnumUtils().GetEnumdescription(status);
            tv_Name.Text = controller_tech.Entry.Name;
            tv_Status.Text = controller_tech.Entry.Status;

            controller_regist.CurrentID = 0;
            controller_regist.LoadEntry();
            controller_regist.Entry.TechniqueStatue = ((int)status);
            controller_regist.Entry.TechniqueID = controller_tech.CurrentID;

            tv_Introspection.Text = "";
            tv_Reason.Text = "";
            tv_Summary.Text = "";
            btn_sure.Enabled = true;
        }

        private void barBtn_Start_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            onReIntialController(TechniqueStatusEnum.Start);
        }

        private void barBtn_Pause_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            onReIntialController(TechniqueStatusEnum.Pause);
        }

        private void barBtn_Finish_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TechniqueMisssionController controller = new TechniqueMisssionController();
            //当前技术下有对应的任务
            if(controller.HasSubMission(controller_tech.CurrentID))
            {
                //如果是finish,则需要检验下属的任务是否都完成了
                if (controller.IsSubMissionFinish(controller_tech.CurrentID))
                    onReIntialController(TechniqueStatusEnum.Finish);
                else
                {
                    MessageBoxHelper.ShowErrorDialog("当前学习技术还有任务未完成，请完成后重试...");
                    btn_sure.Enabled = false;
                }
            }
            else 
            {
                MessageBoxHelper.ShowErrorDialog("当前学习技术未进行任何任务学习登记...");
                btn_sure.Enabled = false;
            }
        }

        private void barBtn_Abandon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            onReIntialController(TechniqueStatusEnum.Abandon);
        }


        public void onExtractInputValue()
        {
            controller_regist.Entry.Summary = tv_Summary.Text;
            controller_regist.Entry.Reason = tv_Reason.Text;
            controller_regist.Entry.Introspection = tv_Introspection.Text;
            controller_regist.Entry.Date = controller_regist.FormatDate(dateE_Date.DateTime.Date);
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            return validator;
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            onExtractInputValue();

            if (controller_regist.InsertEntry())
            {
                if (controller_tech.UpdateEntryByID())
                {
                    onInitialUI();
                    MessageBoxHelper.ShowDialog("提示", "学习技术状态已经修改..");
                }
                else
                {
                    controller_regist.DeleteEntry();
                    MessageBoxHelper.ShowDialog("提示", "学习技术状态修改过程中发生错误..");
                }
            }
            else
                MessageBoxHelper.ShowDialog("提示", "学习技术状态修改失败..");
        }
    }
}
