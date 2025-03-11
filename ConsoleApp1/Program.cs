using RouteBeheerDB.model;
using RouteBeheerDB.Repository;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=PF4RK5Y6\\SQLEXPRESS;Initial Catalog=XrouteTest;Integrated Security=True;Trust Server Certificate=True";           
            Locatie location = new Locatie("Gent");
            NetwerkRepository nrepo = new NetwerkRepository(connectionString);
            NetworkManager nwm = new NetworkManager(nrepo);
            nwm.AddLocation(location);
            Console.WriteLine(location);
        }
    }
}
