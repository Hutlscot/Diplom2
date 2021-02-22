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
using Diplom.VM;

namespace Diplom.View
{
    /// <summary>
    /// Логика взаимодействия для PageAddRating.xaml
    /// </summary>
    public partial class PageAddRating : Page
    {
        public PageAddRating(Students selectedStudent)
        {
            var vm = new AddRatingVM(selectedStudent);
            DataContext = vm;
            InitializeComponent();
            

        }
    }
}
