using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Careers
    {
        private int _IdCareer;
        private int _Coordinator;
        private String _Name;

        public int IdCareer { get => _IdCareer; set => _IdCareer = value; }
        public int Coordinator { get => _Coordinator; set => _Coordinator = value; }
        public string Name { get => _Name; set => _Name = value; }
    }
}
