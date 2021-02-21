using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.VM
{
    using Diplom.OtherClasses;
    using System.Windows;

    public class StudentVM
    {
        public IEnumerable<Students> students { get; set; }

        public Students selectedStudent { get; set; }

        public StudentVM()
        {
            var dataContext = new DataContext();
            students = dataContext.Students.ToList();
        }
        //открыть список студентов
        private RelayCommand addStudent;
        public RelayCommand AddStudent
        {
            get
            {
                return addStudent ??
                       (addStudent = new RelayCommand(obj =>
                       {
                           Transfer.GoTo("Добавить студента");
                       }));
            }
        }
        //открыть рейтинг
        private RelayCommand openRating;
        public RelayCommand OpenRating
        {
            get
            {
                return openRating ??
                       (openRating = new RelayCommand(obj =>
                       {
                           Transfer.GoTo("Рейтинг");
                       }));
            }
        }
        //удалить студента
        private RelayCommand deleteStudent;
        public RelayCommand DeleteStudent
        {
            get
            {
                return deleteStudent ??
                       (deleteStudent = new RelayCommand(obj =>
                       {
                           if (selectedStudent != null)
                           {
                               DataContext dataContext = new DataContext();
                               dataContext.Students.Remove(dataContext.Students.Find(selectedStudent.Id));
                               dataContext.SaveChanges();
                               Transfer.GoTo("Студенты");
                               Mes.SucMes("Студент успешно удален");
                           }
                       }));
            }
        }
    }
}
