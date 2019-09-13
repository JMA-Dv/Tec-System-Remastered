using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Municipalities
    {
        private int _IdMunicipality;
        private int _Number;
        private int _State;
        private String _Name;

        public int IdMunicipality { get => _IdMunicipality; set => _IdMunicipality = value; }
        public int Number { get => _Number; set => _Number = value; }
        public int State { get => _State; set => _State = value; }
        public string Name { get => _Name; set => _Name = value; }
    }
}
