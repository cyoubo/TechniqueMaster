using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniqueMaster.Module_Technique.Componet.Enum
{
    public enum MissionStatusEnum
    {
        [DescriptionAttribute("已创建")]
		Create= 1,
		[DescriptionAttribute("进行中")]
		Running= 2,
		[DescriptionAttribute("已完成")]
		Finish= 3
    }
}
