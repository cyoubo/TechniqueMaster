﻿using System;
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
using TechniqueMaster.Module_TechniqueBomb.Componet.Adapter;
using TechniqueMaster.Module_TechniqueBomb.Controller;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using TechniqueMaster.Module_TechniqueBomb.Model;
using PS.Plot.FrameBasic.Module_Common.Utils;
using TechniqueMaster.Module_TechniqueBomb.Component.Enum;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace TechniqueMaster.Module_TechniqueBomb.View.UControl
{
    public partial class UC_TechniqueEdit : DevExpress.XtraEditors.XtraUserControl,IInitialUI,IValidateInput2
    {
        private TB_TechniqueBuilder2 builder;
        private TB_TechniqueAdapter2 adapter;
        private TechniqueController controller;
        private GridControlHelper gridHelper;

        public UC_TechniqueEdit()
        {
            InitializeComponent();
        }

        private void UC_TechniqueEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_TechniqueBuilder2();
            adapter = new TB_TechniqueAdapter2();
            controller = new TechniqueController();
            gridHelper = new GridControlHelper(this.gridView1, this.gridControl1);

            adapter.Initial(builder);
            controller.LoadEntry();
        }

        public void onInitialUI()
        {
            adapter.NotifyfreshDataTable(controller.Travels());
            gridHelper.GridControl.DataSource = adapter.ResultTable;

            gridHelper.SetAllColumnEditable(false);
            gridHelper.SetColunmOption(builder.ID, false, false);
            gridHelper.SetColunmOption(builder.Op_Edit, false, false);
            gridHelper.SetColunmOption(builder.Op_Detail, false, false);
            gridHelper.SetColunmOption(builder.CatalogID, false, false);
            gridHelper.SetColMaxWidth(builder.Op_Delete, 80);
            gridHelper.SetColMaxWidth(builder.Status, 80);
            gridHelper.SetColMaxWidth(builder.Interest, 80);
            gridHelper.SetColMaxWidth(builder.CreateDate, 120);

            cmb_Category.Properties.Items.Clear();
            foreach (var item in new TechniqueCategoryController().Travels())
                cmb_Category.Properties.Items.Add(item.ConvertToComboxItem());
            if (cmb_Category.Properties.Items.Count > 0)
                cmb_Category.SelectedIndex = 0;

            dateE_CreateDate.DateTime = DateTime.Now.Date;

            tv_Name.Text = "";
            tv_Description.Text = "";
        }

        public void onExtractInputValue()
        {
            controller.Entry.Name = tv_Name.Text;
            controller.Entry.Description = tv_Description.Text;
            controller.Entry.CatalogID = (cmb_Category.SelectedItem as ComboxItem).Tag;
            controller.Entry.CreateDate = dateE_CreateDate.DateTime.Date;
            controller.Entry.Interest = trackBar.Value;
            controller.Entry.Status = new EnumUtils().GetEnumdescription(TechniqueStatusEnum.Create);
        }

        public Validator onValidateInputValue()
        {
            Validator validater = new Validator();
            validater.NotNullFinishValidate(tv_Name.Text, "技能名称");
            return validater;
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

            if (controller.InsertEntry())
            {
                onInitialUI();
                controller.ReleaseEntry();
            }
            else
                MessageBoxHelper.ShowCreateStateDialog(false, controller.ErrorMessage);
        }

        private void repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            string techniqueObjectID = gridHelper.getFocuseRowCellValue_String(builder.ID);
            if (controller.ExistSubTechniqueLog(techniqueObjectID))
            {
                MessageBoxHelper.ShowErrorDialog("请删除当前任务下属日志后重试");
                return;
            }

            if (controller.DeleteByObjectID(techniqueObjectID))
            {
                onInitialUI();
                controller.ReleaseEntry();
            }
            else
                MessageBoxHelper.ShowErrorDialog("删除失败");
        }
    }
}
