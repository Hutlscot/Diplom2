using System.Collections.Generic;
using System.Linq;
using Diplom.OtherClasses;

namespace Diplom.VM
{
    public class StudentVM
    {
        //открыть список студентов
        private RelayCommand addStudent;

        //удалить студента
        private RelayCommand deleteStudent;

        //открыть рейтинг
        private RelayCommand openRating;

        public StudentVM()
        {
            var dataContext = new DataContext();
            students = dataContext.Students.ToList();
        }

        public IEnumerable<Students> students { get; set; }

        public Students selectedStudent { get; set; }

        public RelayCommand AddStudent
        {
            get
            {
                return addStudent ??
                       (addStudent = new RelayCommand(obj => { Transfer.GoTo("Добавить студента"); }));
            }
        }

        public RelayCommand OpenRating
        {
            get
            {
                return openRating ??
                       (openRating = new RelayCommand(obj => { Transfer.GoTo("Рейтинг"); }));
            }
        }

        public RelayCommand DeleteStudent
        {
            get
            {
                return deleteStudent ??
                       (deleteStudent = new RelayCommand(obj =>
                       {
                           if (selectedStudent == null)
                           {
                               Mes.ErrorMes("Сначала выберите");
                               return;
                           }
                           var dataContext = new DataContext();
                           dataContext.Students.Remove(dataContext.Students.Find(selectedStudent.Id));
                           dataContext.SaveChanges();
                           Transfer.GoTo("Студенты");
                           Mes.SucMes("Студент успешно удален");
                       }));
            }
        }
    }
}