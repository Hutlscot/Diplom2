using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    public class RatingVM
    {
        //текст в поле поиска
        public string textSearch;

        public RatingVM()
        {

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
                        Transfer.GoTo("Начислить рейтинг");
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
