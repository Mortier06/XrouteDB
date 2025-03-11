using RouteBeheerBL.managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteBeheerBL.interfaces;
using RouteBeheerBL.Exceptions;
using RouteBeheerBL.model;

namespace RouteBeheerBL.managers
{
    public class NetworkManager
    {
        private INetwerkRepository repo;

        public NetworkManager(INetwerkRepository repo)
        {
            this.repo = repo;
        }

        public void AddLocation(Locatie location)
        {
            try
            {
                if (repo.HasLocationName(location)) throw new NetworkException("AddLocation already exist");
                repo.AddLocation(location);
            }
            catch (Exception ex) { throw new NetworkException("AddLocation", ex); }
            
        }
        public void UpdateLocation(Locatie location)
        {
            try
            {
                if (location.id == null) throw new NetworkException("UpdateLocation id is null");
                if (!repo.HasLocationId(location.id)) throw new NetworkException("UpdateLocation id bestaat niet");
                if (repo.HasLocationName(location)) throw new NetworkException("UpdateLocation naam bestaat niet");
                repo.UpdateLocatie(location);
            } catch (Exception ex) { throw new NetworkException("UpdateLocation", ex); }
        }
    }
}
