using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class States
    {
        private int _IdState;
        private String _Name;

        public int IdState { get => _IdState; set => _IdState = value; }
        public string Name { get => _Name; set => _Name = value; }
    }
}
