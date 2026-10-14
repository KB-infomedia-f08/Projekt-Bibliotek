namespace Projekt_Bibliotek.Classes
{
    public abstract class Media
    {
        public string Title { get; set; }
        public int Copies { get; set; }


        public Media(string title, int copies)
        {
            Title = title;
            Copies = copies;
        }


        public abstract string GetDetails();
    }
} 
