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
        public Managers Manager { get; set; }

        public ListManagerVM(Directions direction)
        {
            Manager = direction.Managers.Where(x => x.IsMainManager).SingleOrDefault();
            Title = $"Руководители. Направление '{direction.Name}'";
        }
    }
}
