using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniqueMaster.Module_TechniqueBomb.Component.Enum
{
    public enum TechniqueStatusEnum
    {
        [DescriptionAttribute("已创建")]
        Create = 1,
        [DescriptionAttribute("进行中")]
        Start = 2,
        [DescriptionAttribute("暂停中")]
        Pause = 3,
        [DescriptionAttribute("已完成")]
        Finish = 4,
        [DescriptionAttribute("已放弃")]
        Abandon = 5
    }
}
