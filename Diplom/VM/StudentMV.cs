using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.VM
{
    using System.Windows;

    public class StudentMV
    {
        public StudentMV()
        {

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
                           MessageBox.Show("нет команды");
                       }));
            }
        }
    }
}
