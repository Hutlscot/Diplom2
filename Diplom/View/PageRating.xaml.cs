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
using TextBox = System.Windows.Controls.TextBox;

namespace Diplom.View
{
    /// <summary>
    /// Логика взаимодействия для PageRating.xaml
    /// </summary>
    public partial class PageRating : Page
    {
        private readonly DataContext dataContext;
        private readonly List<Students> students;
        public PageRating()
        {
            InitializeComponent();
            dataContext = new DataContext();
            students = dataContext.Students.ToList();
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var textSearch = ((TextBox) sender).Text;
            grid.ItemsSource = students.Where(x => x.LastName.ToLower().Contains(textSearch.ToLower())).ToList();
        }
    }
}
