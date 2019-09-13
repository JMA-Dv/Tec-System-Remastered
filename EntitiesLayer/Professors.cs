using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Professors
    {
        private String _IdProfessor;
        private int _IdEmployee;
        private int _IdAcademy;
        private int _TypeMemb;

        public string IdProfessor { get => _IdProfessor; set => _IdProfessor = value; }
        public int IdEmployee { get => _IdEmployee; set => _IdEmployee = value; }
        public int IdAcademy { get => _IdAcademy; set => _IdAcademy = value; }
        public int TypeMemb { get => _TypeMemb; set => _TypeMemb = value; }
    }
}
