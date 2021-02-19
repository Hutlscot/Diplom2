namespace Diplom
{
    using System.Windows;

    using Diplom.View;

    public static class Transfer
    {
        public static void GoTo(string namePage)
        {
            switch (namePage)
            {
                case "Студенты":
                {
                    ManagerFrame.Frame.Navigate(new PageStudents());
                    break;
                }
                case "Мероприятия":
                {
                    ManagerFrame.Frame.Navigate(new PageEvents());
                    break;
                }
                case "Руководители":
                {
                    ManagerFrame.Frame.Navigate(new PageManagers());
                    break;
                }
                case "Добавить студента":
                {
                    ManagerFrame.Frame.Navigate(new PageAddStudent());
                    break;
                }
                case "Рейтинг":
                {
                    ManagerFrame.Frame.Navigate(new PageRating());
                    break;
                }
                default:
                {
                    MessageBox.Show("Такой страницы еще нет");
                    break;
                }
            }
        }
    }
}