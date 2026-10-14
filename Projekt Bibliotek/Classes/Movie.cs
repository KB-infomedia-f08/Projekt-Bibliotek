namespace Projekt_Bibliotek.Classes
{
    public class Movie : Media
    {
        public string Director { get; set; }
        public int ReleaseYear { get; set; }


        public Movie(string title, int copies, string director, int releaseYear)
            : base(title, copies)
        {
            Director = director;
            ReleaseYear = releaseYear;
        }


        public override string GetDetails()
        {
           return $"Director: {Director}\n" +
                  $"Release year: {ReleaseYear}";
        }
    }
}
