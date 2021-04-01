using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public partial class Events
    {
        //получить компетенции строкой
        public string competentciesRating
        {
            get
            {
                var s = "";
                foreach (var item in Сompetencies)
                {
                    s += $"{item.Name}\n";
                }
                if (s == "")
                    return "У этого мероприятия нет компетенций";
                return s;
            }
        }

    }
}
