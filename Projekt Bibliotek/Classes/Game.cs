namespace Projekt_Bibliotek.Classes
{
    public class Game : Media
    {
       public string Developer { get; set; }
       public string Platform { get; set; }


       public Game(string title, int copies, string developer, string platform)
                : base(title, copies)
       {
            Developer = developer;
            Platform = platform;
       }


        public override string GetDetails()
        {
            return $"Developer: {Developer}\n" +
                   $"Platform: {Platform}";
        }
    }
}
