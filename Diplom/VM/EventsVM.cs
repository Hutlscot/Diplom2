using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Diplom.OtherClasses;

namespace Diplom.VM
{
    public class EventsVM
    {
        public List<Events> events { get; set; }

        public Events selectedEvent { get; set; }
        public EventsVM()
        {
            var dataContext = new DataContext();
            events = dataContext.Events.ToList();
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
                    try
                    {
                        if (selectedEvent != null)
                        {
                            var dataContext = new DataContext();
                            dataContext.Events.Remove(dataContext.Events.Find(selectedEvent.Id));
                            dataContext.SaveChanges();
                            Mes.SucMes("Успешное удалено");
                            Transfer.GoTo("Мероприятия");
                        }
                        else
                        {
                            Mes.ErrorMes("Сначала выберите");
                        }
                    }
                    catch
                    {
                        Mes.ErrorMes("Не удалось удалить");
                    }

                }));
            }
        }
    }
}
