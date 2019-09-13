using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Academies
    {
        private int _IdAcademy;
        private String _Name;

        public int IdAcademy { get => _IdAcademy; set => _IdAcademy = value; }
        public string Name { get => _Name; set => _Name = value; }
    }
}
