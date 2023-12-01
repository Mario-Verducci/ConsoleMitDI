namespace ConsoleMitDI.Services
{
    public interface IDatabase
    {
        string GetIrgendwas();
    }

    public class Database : IDatabase
    {
        public string GetIrgendwas()
        {
            return "irgendwas aus Database";
        }
    }

    public class Database2 : IDatabase
    {
        public string GetIrgendwas()
        {
            return "irgendwas aus Database2";
        }
    }
}