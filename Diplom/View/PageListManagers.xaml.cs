using Diplom.VM;
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
    /// Логика взаимодействия для PageListManagers.xaml
    /// </summary>
    public partial class PageListManagers : Page
    {
        public PageListManagers(Directions direction)
        {
            var vm = new ListManagerVM(direction);
            DataContext = vm;
            InitializeComponent();
            grid.ItemsSource = direction.Managers.ToList();
            if(vm.MainManager!=null)
                txt_main_manager.Text = vm.MainManager.InfoMainmanager;
        }
    }
}
