
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Employees
    {
        private int _IdEmployee;
        private int _IdPerson;
        private int _IdJob;

        public int IdEmployee { get => _IdEmployee; set => _IdEmployee = value; }
        public int IdPerson { get => _IdPerson; set => _IdPerson = value; }
        public int IdJob { get => _IdJob; set => _IdJob = value; }
    }
}
