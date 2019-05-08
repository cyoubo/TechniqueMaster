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
using cn.bmob.io;
using TechniqueMaster.Module_TechniqueBomb.Model;
using TechniqueMaster.Module_TechniqueBomb.BombCloud;
using TechniqueMaster.Module_TechniqueBomb.Componet.Adapter;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using TechniqueMaster.Module_TechniqueBomb.Controller;

namespace TechniqueMaster.Module_TechniqueBomb.TestCast
{
    public partial class UC_TestLogAsyn : DevExpress.XtraEditors.XtraUserControl
    {
        private TB_TechniqueLogBuilder builder;
        private TB_TechniqueLogAdapter adapter;
        private GridControlHelper gridhelper;

        public UC_TestLogAsyn()
        {
            InitializeComponent();
        }

        private void UC_TestLogAsyn_Load(object sender, EventArgs e)
        {
            gridhelper = new GridControlHelper(this.gridView1, this.gridControl1);

            builder = new TB_TechniqueLogBuilder();
            adapter = new TB_TechniqueLogAdapter();


            adapter.Initial(builder);

            TechniqueLogController controller = new TechniqueLogController();

            controller.TravelAsyn((repo, ex) => 
            {
                if (ex != null)
                {
                    string temp = ex.Message;
                }
                adapter.NotifyfreshDataTable(repo.results);
                gridhelper.UpdateTableSourceAsyn(adapter.ResultTable);
            });
        }
    }
}
