
namespace Projekt_Bibliotek.Classes
{
    public class Audiobook : Media
    {
        public string Author { get; set; }
        public string Narrator { get; set; }


public Audiobook(string title, int copies, string author, string narrator)
            : base(title, copies)
        {
            Author = author;
            Narrator = narrator;
        }


        public override string GetDetails()
        {
            return $"Author: {Author}\n" +
                $"Narrator: {Narrator}";
        }
    }
}
