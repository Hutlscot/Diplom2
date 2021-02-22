using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom
{
    public class AddEventVM
    {
        public Events eventAdded { get; set; }

        public List<Directions> directions { get; set; }

        public Directions selectedDirection { get; set; }

        public List<Сompetencies> сompetencies { get; set; }

        public ObservableCollection<Сompetencies> selectedListСompetencies { get; set; }

        public Сompetencies selectedCompetencion { get; set; }

        public AddEventVM()
        {
            var dataContext = new DataContext();
            directions = dataContext.Directions.ToList();
            сompetencies = dataContext.Сompetencies.ToList();
            selectedListСompetencies = new ObservableCollection<Сompetencies>();
            eventAdded = new Events();
        }

        private RelayCommand addEvent;
        public RelayCommand AddEvent
        {
            get
            {
                return addEvent ?? (addEvent = new RelayCommand(obj =>
                  {
                      if (selectedDirection == null)
                      {
                          Mes.ErrorMes("Заполните все данные");
                          return;
                      }
                      eventAdded.IdDirection = selectedDirection.Id;
                      var dataContext = new DataContext();
                      foreach (var g in selectedListСompetencies)
                      {
                          eventAdded.Сompetencies.Add(dataContext.Сompetencies.Find(g.Id));
                      }
                      
                      dataContext.Events.Add(eventAdded);
                      dataContext.SaveChanges();
                      Mes.SucMes("Успешно добавлено");
                      Transfer.GoTo("Мероприятия");
                  }));
            }
        }

        private RelayCommand addCompetencion;
        public RelayCommand AddCompetencion
        {
            get
            {
                return addCompetencion ?? (addCompetencion = new RelayCommand(obj =>
                {
                    if (selectedCompetencion != null)
                    {
                        if (selectedListСompetencies.Any(x => x.Id == selectedCompetencion.Id))
                        {
                            Mes.ErrorMes("Этот элемент уже есть в списке");
                            return;
                        }
                        selectedListСompetencies.Add(selectedCompetencion);
                        Mes.SucMes("Успешно добавлено");
                    }
                    else
                    {
                        Mes.ErrorMes("Сначала выберите");
                    }
                }));
            }
        }
    }
}
