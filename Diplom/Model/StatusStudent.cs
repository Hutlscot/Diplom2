namespace Diplom
{
    public class StatusStudent
    {
        public string Title { get; set; }

        public int Count { get; set; }

        public string Info => $"{Title} - {Count} баллов";

        public StatusStudent(string title, int count)
        {
            Title = title;
            Count = count;
        }
    }
}