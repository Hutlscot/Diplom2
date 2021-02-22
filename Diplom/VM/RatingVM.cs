using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Diplom.OtherClasses;
using Diplom.View;

namespace Diplom.VM
{
    public class RatingVM
    {
        //текст в поле поиска
        public string textSearch { get; set; }

        public Students selectedStudent { get; set; }

        public List<Students> students { get; set; }
        public RatingVM()
        {
            var dataContext = new DataContext();
            students = dataContext.Students.ToList();
        }

        //начислить рейтинг
        private RelayCommand addRating;
        public RelayCommand AddRating
        {
            get
            {
                return addRating ?? (
                    addRating = new RelayCommand(obj =>
                    {
                        if(selectedStudent != null)
                            ManagerFrame.Frame.Navigate(new PageAddRating(selectedStudent));
                        else
                        {
                            Mes.ErrorMes("Сначала выберите студента");
                        }
                    }));
            }
        }

        //команда импорта
        private RelayCommand importRating;
        public RelayCommand ImportRating
        {
            get
            {
                return importRating ?? (
                    importRating = new RelayCommand(obj =>
                    {
                        MessageBox.Show("нет команды");
                    }));
            }
        }
    }
}
