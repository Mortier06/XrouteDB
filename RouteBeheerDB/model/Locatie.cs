using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteBeheerDB.model
{
    public class Locatie
    {
        public Locatie(string name)
        {
            Name = name;
        }

        public Locatie(string name, bool isStop)
        {
            Name = name;
            IsStop = isStop;
        }
        public int id { get; set; }
        public string Name { get; set; }
        public bool IsStop { get; set; }
        public override string ToString()
        {
            return $"{id}, {Name}";
        }
    }
}
