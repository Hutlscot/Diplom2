using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diplom.View
{
    /// <summary>
    /// Логика взаимодействия для PageChangeStudent.xaml
    /// </summary>
    public partial class PageChangeStudent : Page
    {
        public static DataContext db = new DataContext();
        public PageChangeStudent(int id)
        {
            InitializeComponent();
            var item = db.Students.FirstOrDefault(x => x.Id == id);
            DataContext = item;
            combo.ItemsSource = db.Directions.ToList();
        }

        private void btm_next_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.SaveChanges();
                Mes.SucMes("Сохранено");
                Transfer.GoTo("Студенты");

            }
            catch
            {
                Mes.ErrorMes("Ошибка редактирования, перезагрузитесь и попробуйте снова");
            }
        }
    }
}
