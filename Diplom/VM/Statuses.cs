using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Diplom
{
    public class Statuses
    {
        //список элементов меню
        public ObservableCollection<StatusStudent> StatusCollection { get; set; }

        public Statuses()
        {
            StatusCollection = new ObservableCollection<StatusStudent>
            {
                new StatusStudent("Студенты",10),
                new StatusStudent("Мероприятия", 10),
                new StatusStudent("Руководители", 10)
            };

        }

    }
}
