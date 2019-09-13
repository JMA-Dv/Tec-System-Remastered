using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{

    public class Activities
    {
        private int _IdActivity;
        private String _Name;
        private String _Description;
        private char _Grup;
        private String _Topic;
        private String _Consideration;
        private DateTime _Date;

        public int IdActivity { get => _IdActivity; set => _IdActivity = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Description { get => _Description; set => _Description = value; }
        public char Grup { get => _Grup; set => _Grup = value; }
        public string Topic { get => _Topic; set => _Topic = value; }
        public string Consideration { get => _Consideration; set => _Consideration = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
    }
}
