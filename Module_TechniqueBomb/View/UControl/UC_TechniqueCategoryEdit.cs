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
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using cn.bmob.io;
using TechniqueMaster.Module_TechniqueBomb.BombCloud;
using TechniqueMaster.Module_TechniqueBomb.Model;
using TechniqueMaster.Module_TechniqueBomb.Controller;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace TechniqueMaster.Module_TechniqueBomb.View.UControl
{
    public partial class UC_TechniqueCategoryEdit : DevExpress.XtraEditors.XtraUserControl , IInitialUI,IValidateInput2
    {
        private TB_TechniqueCategoryAdapter adapter;
        private TB_TechniqueCategoryBuilder builder;
        private GridControlHelper gridHelper;
        private TechniqueCategoryController controller;

        public UC_TechniqueCategoryEdit()
        {
            InitializeComponent();
        }

        private void UC_TechniqueCategoryEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            controller = new TechniqueCategoryController();
            controller.LoadEntry();

            gridHelper = new GridControlHelper(this.gridView1, this.gridControl1);
            adapter = new TB_TechniqueCategoryAdapter();
            builder = new TB_TechniqueCategoryBuilder();

            adapter.Initial(builder);
        }

        public void onInitialUI()
        {
            adapter.Initial(controller.Travels(), builder);
            adapter.NotifyfreshDataTable();
            gridHelper.GridControl.DataSource = adapter.ResultTable;
            gridHelper.SetAllColumnEditable(false);

            gridHelper.SetColunmOption(builder.ID, false, false);
            gridHelper.SetColMaxWidth(builder.Op_Delete, 80);
            gridHelper.SetColMaxWidth(builder.Op_Edit, 80);
            gridHelper.SetCellResposity(builder.Op_Delete, repo_HLE_Delete);
            gridHelper.SetCellResposity(builder.Op_Edit, repo_HLE_Update);
        }

        public void onExtractInputValue()
        {
            controller.Entry.Name = tv_Name.Text;
            controller.Entry.Description = tv_Description.Text;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Name.Text, "类别名称");
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

            if (string.IsNullOrEmpty(controller.CurrentObjectID))
            {
                if (controller.InsertEntry())
                {
                    onInitialUI();
                    controller.ReleaseEntry();
                }
                else
                    MessageBoxHelper.ShowCreateStateDialog(false);
            }
            else
            {
                if (controller.UpdateEntry())
                {
                    onInitialUI();
                    controller.ReleaseEntry();
                }
                else
                    MessageBoxHelper.ShowUpdateStateDialog(false);
            }
        }

        private void repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            string objectID = gridHelper.getFocuseRowCellValue_String(builder.ID);
            if (controller.ExistSubTechnique(objectID))
            {
                MessageBoxHelper.ShowErrorDialog("请删除该类别下属的技能后重试");
                return;
            }

            if (controller.DeleteByObjectID(objectID))
            {
                onInitialUI();
                controller.ReleaseEntry();
            }
            else
                MessageBoxHelper.ShowDeleteStateDialog(false);
        }

        private void repo_HLE_Update_Click(object sender, EventArgs e)
        {
            string objectID = gridHelper.getFocuseRowCellValue_String(builder.ID);
            controller.CurrentObjectID = objectID;
            controller.LoadEntry();

            tv_Description.Text = controller.Entry.Description;
            tv_Name.Text = controller.Entry.Name;
        }
    }
}
