using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4
{
    internal class MouthOption
    {
        public string GetMounth(string mounthString)
        {
            Mounth mounth = (Mounth)Enum.Parse(typeof(Mounth), mounthString);
            if (mounth == Mounth.Декабрь)
            {
                mounth = Mounth.Январь;
                return mounth.ToString();
            }

            mounth += 1;
            return mounth.ToString();
        }
    }
}
