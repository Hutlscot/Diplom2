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
        public AddStudentVM()
        {

        }

        private RelayCommand addStudent;
        public RelayCommand AddStudent
        {
            get
            {
                return addStudent ??
                    (addStudent = new RelayCommand(obj=>
                    {
                        MessageBox.Show("нет команды");
                    }));
            }
        }
    }
}
