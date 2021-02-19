using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Diplom
{
    

    public class Menu
    {
        //список элементов меню
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        public Menu()
        {
            MenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem("Студенты"),
                new MenuItem("Мероприятия"),
                new MenuItem("Руководители")
            };

        }

    }
}
