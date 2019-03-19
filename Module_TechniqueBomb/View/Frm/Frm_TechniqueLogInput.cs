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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Interface;
using TechniqueMaster.Module_TechniqueBomb.Controller;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace TechniqueMaster.Module_TechniqueBomb.View.Frm
{
    public partial class Frm_TechniqueLogInput : DevExpress.XtraEditors.XtraForm,IInitialUI,IValidateInput2,INewRowCallBack
    {
        public DateTime CurrentDate { get; set; }

        private TB_TechniqueLogBuilder builder;
        private TB_TechniqueLogAdapter adapter;
        private GridControlHelper gridHelper;

        private TechniqueLogController controller;

        public Frm_TechniqueLogInput()
        {
            InitializeComponent();
        }

        private void Frm_TechniqueLogInput_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_TechniqueLogBuilder();
            adapter = new TB_TechniqueLogAdapter();

            adapter.Initial(builder);
            adapter.NotifyCreateNewResultDataTable();

            gridHelper = new GridControlHelper(this.gridView1, this.gridControl1);

            gridHelper.GridControl.DataSource = adapter.ResultTable;

            //gridHelper.DisplayNewInputLine();
            gridHelper.AddNewRowInputCallBack(this);
            gridHelper.SetColMaxWidth(builder.Op_Delete, 80);
            gridHelper.SetColunmOption(builder.Date, false, false);
            gridHelper.SetColunmOption(builder.ID, false, false);
            gridHelper.SetCellResposity(builder.MissionID, repo_search_TechMission);
            gridHelper.SetCellResposity(builder.IsNeedTidy, repo_cke_Tidy);
            

            controller = new TechniqueLogController();
        }

        public void onInitialUI()
        {
            tv_date.Text = CurrentDate.ToString("yyyy-MM-dd");

            TB_TechniqueMissionAdapter missionAdapter = new TB_TechniqueMissionAdapter();
            TB_TechniqueMissionBuilder missionBuilder = new TB_TechniqueMissionBuilder();
            missionAdapter.Initial(missionBuilder);
            missionAdapter.NotifyfreshDataTable(new TechniqueMissionController().FindUnFinishMission());
            repo_search_TechMission.DataSource = missionAdapter.ResultTable;
            repo_search_TechMission.PopulateViewColumns();
            repo_search_TechMission.DisplayMember = missionBuilder.Name;
            repo_search_TechMission.ValueMember = missionBuilder.ObjectID;
            for (int index = 0; index < repo_search_TechMission.View.Columns.Count; index++)
                repo_search_TechMission.View.Columns[index].Visible = false;
            repo_search_TechMission.View.Columns[missionBuilder.Name].Visible = true;
            repo_search_TechMission.View.Columns[missionBuilder.TechinqueName].Visible = true;
            repo_search_TechMission.View.Columns[missionBuilder.TechinqueName].Group();
            repo_search_TechMission.View.GroupFormat = "{1}";
            repo_search_TechMission.View.ExpandAllGroups();
        }

        public void onExtractInputValue()
        {
            
        }

        public PS.Plot.FrameBasic.Module_Common.Component.Validator onValidateInputValue()
        {
            return null;
        }

        public void onNewRowAdded(GridControlHelper gridControlHelper, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            if (e.RowHandle != -1)
            {
                gridHelper.GridView.SetRowCellValue(e.RowHandle, builder.Op_Delete, builder.Op_Delete);
                gridHelper.GridView.SetRowCellValue(e.RowHandle, builder.Date, tv_date.Text);
                gridHelper.GridView.AddNewRow();
            }
        }

        public void onValidateNewRow(GridControlHelper gridControlHelper, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e, DataRow NewRow)
        {
            
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            TB_TechniqueLogDeserializion deserializaion = new TB_TechniqueLogDeserializion();
            deserializaion.LogDate = DateTime.Parse(tv_date.Text);
            if (deserializaion.ExcuteDesrialize(builder, gridHelper.DataTableSource))
            {
                if (controller.BatchInsert(deserializaion.DeserializeResult))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBoxHelper.ShowCreateStateDialog(false);
            }
        }

       
    }
}