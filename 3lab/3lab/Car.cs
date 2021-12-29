using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
       public partial class Car
        {
        public uint makeHash(int id, string mark, int year, int num)
        {
            int intRes = mark.Length + num * 9 - id;
            uint res = (uint)intRes;//явное преобразование
            return res;
        }
      
    }
    public class NewClass : System.Object//унаследование
    {
        public override bool Equals(object obj)//переопределение метода
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return base.Equals(obj);//ссылка  на родителя
        }
    }
}

