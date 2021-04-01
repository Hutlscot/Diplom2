using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Model
{
    //прочие данные которые нужны для работы приложения
    public static class OtherData
    {
        //public static ObservableCollection<Item> LoadPOO()
        //{
        //    return new ObservableCollection<Item>
        //    {
        //        new Item("ОГБПОУ \"АТпромИС\""),
        //        new Item("ОГБПОУ \"КТПРТ\""),
        //        new Item("ОГБПОУ \"КТАБ\""),
        //        new Item("ОГБПОУ \"КИПТСУ\""),
        //        new Item("ОГБПОУ \"КСПК\""),
        //        new Item("ОГБПОУ \"КАПТ\""),
        //        new Item("ОГБПОУ \"МТОТ\""),
        //        new Item("ОГБПОУ \"ПКТ\""),
        //        new Item("ОГБПОУ \"СПК\""),
        //        new Item("ОГБПОУ \"ТАК\""),
        //        new Item("ОГБПОУ \"ТБМК\""),
        //        new Item("ОГБПОУ \"ТГПК\""),
        //        new Item("ОГБПОУ \"ТомИнТех\""),
        //        new Item("ОГБПОУ \"ТКСТ\""),
        //        new Item("ОГБПОУ \"ТЛТ\""),
        //        new Item("ОГБПОУ \"ТМТТ\""),
        //        new Item("ОГБПОУ \"ТПТ\""),
        //        new Item("ОГБПОУ \"ТПГК\""),
        //        new Item("ОГБПОУ \"ТТВТС\""),
        //        new Item("ОГБПОУ \"ТТИТ\""),
        //        new Item("ОГБПОУ \"ТТСТ\""),
        //        new Item("ОГБПОУ \"ТЭПК\"")
        //    };
        //}

        public static ObservableCollection<Item> loadMenuItems()
        {
            return new ObservableCollection<Item>
            {
                new Item("Главная"),
                new Item("Студенты"),
                new Item("Мероприятия"),
                new Item("Органы студенческого совета")
            };
        }
    }
}
