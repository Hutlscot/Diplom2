using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    public class EventsVM
    {
        public EventsVM()
        {

        }

        //добавить мероприятие
        private RelayCommand addEvent;
        public RelayCommand AddEvent
        {
            get
            {
                return addEvent ?? (addEvent = new RelayCommand(obj =>
                  {
                      Transfer.GoTo("Добавить мероприятие");
                  }));
            }
        }

        //добавить мероприятие
        private RelayCommand importEvents;
        public RelayCommand ImportEvents
        {
            get
            {
                return importEvents ?? (importEvents = new RelayCommand(obj =>
                {
                    MessageBox.Show("Нет команды");
                }));
            }
        }

        //Удалить мероприятие
        private RelayCommand deleteEvent;
        public RelayCommand DeleteEvent
        {
            get
            {
                return deleteEvent ?? (deleteEvent = new RelayCommand(obj =>
                {
                    MessageBox.Show("Нет команды");
                }));
            }
        }
    }
}
