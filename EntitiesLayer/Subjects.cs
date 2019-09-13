using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{

    public class Subjects
    {
        private char _CveSubject;
        private String _Name;
        private int _TheoreticalHours;
        private int _PracticalHours;
        private int _Credits;
        private int _Career;

        public char CveSubject { get => _CveSubject; set => _CveSubject = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int TheoricalHours { get => _TheoreticalHours; set => _TheoreticalHours = value; }
        public int PracticalHours { get => _PracticalHours; set => _PracticalHours = value; }
        public int Credits { get => _Credits; set => _Credits = value; }
        public int Career { get => _Career; set => _Career = value; }
    }
}
