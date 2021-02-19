namespace Diplom
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Documents;

    public class ManagersVM
    {
        public ObservableCollection<MenuItem> MenuItems { get; set; }

        public ManagersVM()
        {
            MenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem("Волонтерство"),
                new MenuItem("Творчество"),
                new MenuItem("Специалисты будущего"),
                new MenuItem("Патриотическое"),
                new MenuItem("Студенческий совет"),
            };
        }
    }
}