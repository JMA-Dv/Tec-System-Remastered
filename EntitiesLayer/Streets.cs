using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Streets
    {
        private int _IdStreet;
        private int _Location;
        private String _Name;

        public int IdStreet { get => _IdStreet; set => _IdStreet = value; }
        public int Location { get => _Location; set => _Location = value; }
        public string Name { get => _Name; set => _Name = value; }
    }
}
