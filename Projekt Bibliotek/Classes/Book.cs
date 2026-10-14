 namespace Projekt_Bibliotek.Classes
{
    public class Book : Media
    {
        public string Author { get; set; }
        public int PublicationYear { get; set; }


        public Book(string title, int copies, string author, int publicationYear)
            : base(title, copies)
        {
            Author = author;
            PublicationYear = publicationYear;
        }


        public override string GetDetails()
        {
            return $"Author: {Author}\n" +
                $"Publication year: {PublicationYear}";
        }
    }
}
