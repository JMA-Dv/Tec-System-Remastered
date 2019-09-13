using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class DetActivities
    {
        private int _IdDetActivities;
        private int _Activity;
        private char _Enrollment;
        private String _Calification;
        private DateTime _LimitDate;

        public int IdDetActivities { get => _IdDetActivities; set => _IdDetActivities = value; }
        public int Activity { get => _Activity; set => _Activity = value; }
        public char Enrollment { get => _Enrollment; set => _Enrollment = value; }
        public string Calification { get => _Calification; set => _Calification = value; }
        public DateTime LimitDate { get => _LimitDate; set => _LimitDate = value; }
    }
}
