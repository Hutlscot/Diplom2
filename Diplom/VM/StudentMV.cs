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

        private RelayCommand addCommand;

        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                       (addCommand = new RelayCommand(obj =>
                       {
                           Transfer.GoTo("Добавить студента");
                       }));
            }
        }
    }
}
