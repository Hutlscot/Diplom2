using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.VM
{
    public class ListManagerVM
    {
        public string Title { get; set; }
        public Managers MainManager { get; set; }

        public ListManagerVM(Directions direction)
        {
            MainManager = direction.Managers.SingleOrDefault(x => x.IsMainManager);
            Title = $"Руководители. Направление '{direction.Name}'";
        }
    }
}
