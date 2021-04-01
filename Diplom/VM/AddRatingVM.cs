using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.OtherClasses;

namespace Diplom.VM
{
    public class AddRatingVM
    {
        public ObservableCollection<StatusStudent> listStatuses { get; set; }
        public StatusStudent selectedStatus { get; set; }

        public List<Events> listEvents { get; set; }
        public Events selectedEvent { get; set; }

        public Students SelectedStudent { get; set; }

        public Rating AddedRating { get; set; }
        

        public AddRatingVM(Students selectedStudens)
        {
            AddedRating = new Rating();
            SelectedStudent = selectedStudens;
            var dataContext = new DataContext();
            listEvents = dataContext.Events.ToList();
            listStatuses = new ObservableCollection<StatusStudent>
            {
                new StatusStudent("Ведущий", 100),
                new StatusStudent("Экскурсовод", 50),
                new StatusStudent("1 место", 40),
                new StatusStudent("2 место", 30),
                new StatusStudent("3 место", 20),
                new StatusStudent("Участник", 10)
            };
        }

        private RelayCommand addRationg;

        public RelayCommand AddRationg
        {
            get
            {
                return addRationg ?? (addRationg = new RelayCommand(obj =>
                {
                    try
                    {
                        if (selectedEvent == null || selectedStatus == null)
                        {
                            Mes.ErrorMes("Сначала заполните все поля");
                            return;
                        }

                        var listRatingStudent = SelectedStudent.Rating.ToList();
                        if (listRatingStudent.Any(rating => rating.IdEvent == selectedEvent.Id))
                        {
                            Mes.ErrorMes("За это мероприятие студенту уже начислили балы");
                            return;
                        }
                        AddedRating.IdStudent = SelectedStudent.Id;
                        AddedRating.IdEvent = selectedEvent.Id;
                        AddedRating.Count = selectedStatus.Count;
                        AddedRating.Position = selectedStatus.Title;
                        var dataContext = new DataContext();
                        dataContext.Rating.Add(AddedRating);
                        dataContext.SaveChanges();
                        Mes.SucMes("Успешно добавлено");
                        Transfer.GoTo("Рейтинг");
                    }
                    catch
                    {
                        Mes.ErrorMes("Не удалось добавить");
                    }
                }));
            }
        }

    }
}