namespace Diplom
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Documents;

    public class ManagersVM
    {
        public List<Directions> directions { get; set; }
        public ManagersVM()
        {
            DataContext dataContext = new DataContext();
            directions = dataContext.Directions.ToList();
        }
    }
}