namespace Projekt_Bibliotek.Classes
{
    public class Newspaper : Media
    {
        public string Date { get; set; }


        public Newspaper(string title, int copies, string date)
            : base(title, copies)
        {
            Date = date;
        }


        public override string GetDetails()
        {
            return $"Date: {Date}";
        }
    }
}
