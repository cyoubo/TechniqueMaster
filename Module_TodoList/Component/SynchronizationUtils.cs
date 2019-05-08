using cn.bmob.io;
using Moon.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniqueMaster.Module_TodoList.Component
{
    public interface IBombMoonConverter<B,E> where B : BmobTable where E : EntityBase
    {
        //public B toBmobTable(E entry);

        //public E toMoonEntity(B table);
    }


    public class SynchronizationUtils
    {
    }
}
