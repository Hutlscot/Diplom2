using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.OtherClasses
{
    public static class Mes
    {
        public static void ErrorMes(string mes)
        {
            MessageBox.Show(mes, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void SucMes(string mes)
        {
            MessageBox.Show(mes, "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
