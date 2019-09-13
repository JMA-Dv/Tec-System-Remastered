using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Jobs
    {
        private int _IdJob;
        private String _Position;

        public int IdJob { get => _IdJob; set => _IdJob = value; }
        public string Position { get => _Position; set => _Position = value; }
    }
}
