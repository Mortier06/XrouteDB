using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteBeheerDB.model
{

    public class Segment
    {
        public Segment(Locatie startLocation, Locatie endLocation, double distance, bool fromTo)
        {
            StartLocation = startLocation;
            EndLocation = endLocation;
            Distance = distance;
            FromTo = fromTo;
        }

        public Segment(int id, Locatie startLocation, Locatie endLocation, double distance, bool fromTo)
        {
            this.id = id;
            StartLocation = startLocation;
            EndLocation = endLocation;
            Distance = distance;
            FromTo = fromTo;
        }

        public int id { get; set; }
        public Locatie StartLocation { get; set; }
        public Locatie EndLocation { get; set; }
        public double Distance { get; set; }
        public bool FromTo { get; set; }

    }
}
