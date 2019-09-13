using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{

    public class Locations
    {
        private int _IdLocations;
        private int _Municipality;
        private String _Name;
        private int _Type;

        public int IdLocations { get => _IdLocations; set => _IdLocations = value; }
        public int Municipality { get => _Municipality; set => _Municipality = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int Type { get => _Type; set => _Type = value; }
    }
}
