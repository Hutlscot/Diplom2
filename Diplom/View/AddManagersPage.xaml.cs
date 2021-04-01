using Diplom.Model;
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
    /// Логика взаимодействия для AddManagersPage.xaml
    /// </summary>
    public partial class AddManagersPage : Page
    {
        private static DataContext db = new DataContext();
        private Directions selectedDirection;
        public AddManagersPage(Directions directions)
        {
            InitializeComponent();
            selectedDirection = directions;
            combo.ItemsSource = db.Students.Where(stud => stud.IdDirection==directions.Id).ToList();
            cmb_position.ItemsSource = OtherData.LoadPositions();
        }

        private void btm_next_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var studetn = combo.SelectedItem as Students;
                var position = cmb_position.SelectedItem as Item;
                var manager = new Managers();
                manager.Name = studetn.Name;
                manager.LastName = studetn.LastName;
                manager.MiddleName = studetn.MiddleName;
                manager.Position = position.Name;
                manager.IsMainManager = false;
                manager.Contacts = contacts.Text;
                manager.Directions.Add(studetn.Directions);
                db.Managers.Add(manager);
                db.SaveChanges();
                Mes.SucMes("Сохранено");
                ManagerFrame.Frame.Navigate(new PageListManagers(db.Directions.Find(selectedDirection.Id)));
            }
            catch
            {
                Mes.ErrorMes("Ошибка добавления, перезагрузитесь");
            }

        }
    }
}
