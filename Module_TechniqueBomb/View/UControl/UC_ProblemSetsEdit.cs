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
using TechniqueMaster.Module_TechniqueBomb.Componet.Adapter;
using TechniqueMaster.Module_TechniqueBomb.Controller;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Component;

namespace TechniqueMaster.Module_TechniqueBomb.View.UControl
{
    public partial class UC_ProblemSetsEdit : DevExpress.XtraEditors.XtraUserControl,IInitialUI,IValidateInput2
    {
        private TB_ProblemSetsAdapter adapter;
        private TB_ProblemSetsBuilder builder;
        private ProblemSetsController controller;
        private GridControlHelper gridHelper;

        public UC_ProblemSetsEdit()
        {
            InitializeComponent();
        }

        private void UC_ProblemSetsEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_ProblemSetsBuilder();
            adapter = new TB_ProblemSetsAdapter();
            adapter.Initial(builder);

            gridHelper = new GridControlHelper(this.gridView1, this.gridControl1);
            gridHelper.GridControl.DataSource = builder.CreateDataTable();
            gridHelper.GridView.RowHeight = 35;

            gridHelper.SetAllColumnEditable(false);
            gridHelper.SetColunmOption(builder.ID, false, true);
            gridHelper.SetCellResposity(builder.Op_Delete,repo_HLE_Delete);
            gridHelper.SetColMaxWidth(builder.Op_Delete, 80);
            gridHelper.SetColMaxWidth(builder.Immediacy, 80);
            gridHelper.SetColMaxWidth(builder.Importance, 80);
            gridHelper.SetColMaxWidth(builder.Size, 80);
            gridHelper.SetColMaxWidth(builder.Difficulty, 80);
            gridHelper.SetColMaxWidth(builder.Op_Edit, 80);
            gridHelper.SetColMaxWidth(builder.PreProblemID, 60);
            gridHelper.SetColMaxWidth(builder.CreateDate, 80);
            gridHelper.SetColMaxWidth(builder.FinishDate, 80);
            gridHelper.SetColMaxWidth(builder.UpdateDate, 100);
            gridHelper.SetColMaxWidth(builder.ID, 60);


            cmb_Category.Properties.Items.AddRange(new string[] { "自我要求", "工作需要" });
            cmb_Category.SelectedIndex = 0;

            date_CreateDate.DateTime = DateTime.Now.Date;

            controller = new ProblemSetsController();
        }

        public void onInitialUI()
        {
            controller.CurrentID = 0;
            controller.LoadEntry();

            tv_Description.Text = "";

            //加载问题
            adapter.NotifyfreshDataTable(controller.TravleAllEntities());
            this.gridHelper.GridControl.DataSource = adapter.ResultTable;
            //加载前置问题
            SLU_Preblem.Properties.DataSource = controller.FindUnFinishProblem();
            SLU_Preblem.Properties.PopulateViewColumns();
            SLU_Preblem.Properties.ValueMember = builder.ID;
            SLU_Preblem.Properties.DisplayMember = builder.Description;
            //SLU_Preblem.Properties.View.Columns[builder.Op_Delete].Visible = false;
            //SLU_Preblem.Properties.View.Columns[builder.Op_Edit].Visible = false;
            SLU_Preblem.Properties.View.Columns[builder.FinishDate].Visible = false;
            SLU_Preblem.Properties.View.Columns[builder.UpdateDate].Visible = false;
        }

        public void onExtractInputValue()
        {
            controller.Entry.CreateDate = controller.FormatDate(date_CreateDate.DateTime.Date);
            controller.Entry.Description = tv_Description.Text;
            controller.Entry.Catagory = cmb_Category.Text;
            controller.Entry.Difficulty = Decimal.ToInt64(rating_Difficulty.Rating);
            controller.Entry.Immediacy = Decimal.ToInt64(rating_Immediacy.Rating);
            controller.Entry.Importance = Decimal.ToInt64(rating_Importance.Rating);
            controller.Entry.Size = Decimal.ToInt64(rating_Size.Rating);
            if(SLU_Preblem.EditValue!=null)
                controller.Entry.PreProblemID = int.Parse(SLU_Preblem.EditValue.ToString());
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            return validator;
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            onExtractInputValue();

            if (controller.CurrentID == 0)
            {
                if (controller.InsertEntry())
                {
                    this.controller.ReleaseEntry();
                    this.onInitialUI();
                }
                else
                    MessageBoxHelper.ShowCreateStateDialog(false);
            }
            else
            {
                if (controller.UpdateEntryByID())
                {
                    this.controller.ReleaseEntry();
                    this.onInitialUI();
                }
                else
                    MessageBoxHelper.ShowUpdateStateDialog(false);
            }
        }

        private void repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            int targetID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            if (controller.DeleteEntryByID(targetID))
            {
                this.controller.ReleaseEntry();
                this.onInitialUI();
            }
            else
                MessageBoxHelper.ShowDeleteStateDialog(false);
        }
    }
}
