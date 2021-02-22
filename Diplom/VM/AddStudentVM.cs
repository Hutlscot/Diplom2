using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    public class AddStudentVM
    {
        public Students student { get; set; }

        public List<Directions> directions { get; set; }

        public Directions selectedDirection { get; set; }

        public AddStudentVM()
        {
            var dataContext = new DataContext();
            directions = dataContext.Directions.ToList();
            student = new Students();

        }

        private RelayCommand addStudent;
        public RelayCommand AddStudent
        {
            get
            {
                return addStudent ??
                    (addStudent = new RelayCommand(obj =>
                    {
                        try
                        {
                            if (selectedDirection == null)
                            {
                                Mes.ErrorMes("Заполните все данные");
                                return;
                            }
                            student.IdDirection = selectedDirection.Id;
                            var dataContext = new DataContext();
                            dataContext.Students.Add(student);
                            dataContext.SaveChanges();
                            Mes.SucMes("Успешно добавлено");
                            Transfer.GoTo("Студенты");
                        }
                        catch
                        {
                            Mes.ErrorMes("Ошибка добавления");
                        }
                    }));
            }
        }
    }
}
