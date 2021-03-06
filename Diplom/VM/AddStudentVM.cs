using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Diplom.Model;

namespace Diplom.VM
{
    public class AddStudentVM
    {
        public Students student { get; set; }

        public List<Directions> directions { get; set; }

        public Directions selectedDirection { get; set; }

        //список POO
        public ObservableCollection<Item> listPOO { get; set; }
        public Item selectedPOO { get; set; }

        public AddStudentVM()
        {
            var dataContext = new DataContext();
            directions = dataContext.Directions.ToList();
            student = new Students();
            //загрузить POO
            listPOO = OtherData.LoadPOO();
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
                            if (selectedDirection == null || selectedPOO == null)
                            {
                                Mes.ErrorMes("Заполните все данные");
                                return;
                            }
                            student.IdDirection = selectedDirection.Id;
                            student.POO = selectedPOO.Name;
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
