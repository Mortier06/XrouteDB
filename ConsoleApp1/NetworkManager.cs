using RouteBeheerDB.model;
using RouteBeheerDB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NetworkManager
    {
        private NetwerkRepository repo;

        public NetworkManager(NetwerkRepository repo)
        {
            this.repo = repo;
        }

        public void AddLocation(Locatie location)
        {
            try
            {
                if (repo.HasLocation(location)) throw new NetworkException("AddLocation already exist");
                repo.AddLocation(location);
            }
            catch (Exception ex) { throw new NetworkException("AddLocation", ex); }
            
        }
    }
}
