using Diplom.OtherClasses;
using Diplom.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.VM
{
    public class ListManagerVM
    {
        public string Title { get; set; }
        public Managers MainManager { get; set; }

        public Managers selectedItem { get; set; }
        private Directions selectedDirection {get;set;}

        public ListManagerVM(Directions direction)
        {
            selectedDirection = direction;
            MainManager = direction.Managers.SingleOrDefault(x => x.IsMainManager);
            Title = $"Члены органа студенческого совета по направлению '{direction.Name}'";
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                       (addCommand = new RelayCommand(obj => {
                           ManagerFrame.Frame.Navigate(new AddManagersPage(selectedDirection));
                       }));
            }
        }

        private RelayCommand delCommand;
        public RelayCommand DelCommand
        {
            get
            {
                return delCommand ??
                       (delCommand = new RelayCommand(obj => {
                           if (selectedItem == null)
                           {
                               Mes.ErrorMes("Сначала выберите");
                               return;
                           }
                           DataContext db = new DataContext();
                           db.Managers.Remove(db.Managers.Find(selectedItem.Id));
                           db.SaveChanges();
                           Mes.SucMes("Успешно");
                       ManagerFrame.Frame.Navigate(new PageListManagers(db.Directions.FirstOrDefault(x => x.Id == selectedDirection.Id)));
                       }));
            }
        }
    }
}
