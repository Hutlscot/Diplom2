using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.OtherClasses;

namespace Diplom.VM
{
    public class AddRatingVM
    {
        public ObservableCollection<StatusStudent> listStatuses { get; set; }

        public List<Events> listEvents { get; set; }

        public Students SelectedStudent { get; set; }

        public Rating AddedRating { get; set; }

        public AddRatingVM(Students selectedStudens)
        {
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
                    Mes.ErrorMes("sdfsdf");
                }));
            }
        }

    }
}