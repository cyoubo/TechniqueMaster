using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechniqueMaster
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //修改主题皮肤
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
            //抑制DevExpress的跨线程修改错误
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Main());
        }
    }
}
