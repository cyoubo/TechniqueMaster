using cn.bmob.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniqueMaster.Module_TechniqueBomb.BombCloud
{
    public class BmobIntance
    {
        private static BmobIntance instance;

        public static BmobIntance Create()
        {
            if (instance == null)
                instance = new BmobIntance();
            return instance;
        }

        private BmobIntance()
        {
            Bmob = new BmobWindows();
        }

        public BmobWindows Bmob { protected set; get; }

        public void InitialBomb()
        {
            Bmob.initialize("c3302d735a7d4330349cf82eeefc2599", "9c98676875c049dd12525b796b1ecf30");         
        }
    }
}
