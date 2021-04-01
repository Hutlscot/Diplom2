using System.Collections.ObjectModel;
using System.Linq;

namespace Diplom
{
    partial class Students
    {
        //получить компетенции строкой
        public string competentciesRating
        {
            get
            {
                var result = "";
                var dataContext = new DataContext();
                var listCompetencies = dataContext.Сompetencies.ToList();
                foreach (var competency in listCompetencies)
                {
                    var count = 0;
                    foreach (var eventss in competency.Events)
                    {
                        count += eventss.Rating.Where(x => x.IdStudent == Id).Select(x => x.Count).SingleOrDefault();
                    }
                    if (count != 0)
                        result += $"{competency.Name},\n";
                }

                if (result == "")
                    result = "нет компетенций";
                return result;
            }
        }

        ////получить мероприятия списком
        //public ObservableCollection<Events> Events
        //{
        //    get
        //    {
        //        var events = new ObservableCollection<Events>();
        //        if (Rating.Any())
        //        {
        //            foreach (var rat in Rating)
        //            {
        //                events.Add(rat.Events);
        //            }
        //        }
        //        return events;
        //    }
        //}

        //получить мероприятия списком
        public string Events
        {
            get
            {
                var s = "";
                if (Rating.Any())
                {
                    foreach (var rat in Rating)
                    {
                        s+= rat.Events.Name +" "+ rat.Events.Description +" "+ rat.Position+"\n\n";
                    }
                }
                return s;
            }
        }


        //получить мероприятия строкой
        //для экспорта
        public string EventsToString
        {
            get
            {
                var events = "";
                if (Rating.Any())
                {
                    foreach (var rat in Rating)
                    {
                        events += $"{rat.Events.Name} {rat.Events.Description},\n";
                    }
                }

                if (events == "")
                    events = "нет мероприятий";
                return events;
            }
        }

        //получить сумму балолов рейтинга
        public int OverAllRating
        {
            get
            {
                int sum = 0;
                if (Rating.Any())
                {
                    foreach (var rating in Rating)
                    {
                        sum += rating.Count;
                    }
                }
                return sum;
            }
        }

    }
}