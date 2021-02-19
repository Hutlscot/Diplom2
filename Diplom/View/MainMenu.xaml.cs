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

namespace Diplom
{
    using System.Net;

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ManagerFrame.Frame = frame;
        }

        //переходы по меню
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Transfer.GoTo(((TextBlock)sender).Text);
        }

        //возвращение назад
        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            if (ManagerFrame.Frame.CanGoBack)
            {
                ManagerFrame.Frame.GoBack();
            }
            else
            {
                Close();
            }
        }
    }
}
