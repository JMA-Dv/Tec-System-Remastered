using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Specialties
    {
        private int _IdSpecialty;
        private String _Name;
        private int _Career;

        public int IdSpecialty { get => _IdSpecialty; set => _IdSpecialty = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int Career { get => _Career; set => _Career = value; }
    }   
}
