using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using Diplom.Model;

namespace Diplom
{
    public class Statuses
    {
        //список элементов меню
        public ObservableCollection<Item> MenuItems { get; set; }

        public Statuses()
        {
            MenuItems = OtherData.loadMenuItems();

        }

    }
}
