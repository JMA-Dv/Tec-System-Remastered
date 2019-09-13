using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Absences
    {
        private int _IdAbsence;
        private char _Group;
        private char _Enrollment;
        private DateTime _Date;
        private int _AbsenceType;

        public int IdAbsence { get => _IdAbsence; set => _IdAbsence = value; }
        public char Group { get => _Group; set => _Group = value; }
        public char Enrollment { get => _Enrollment; set => _Enrollment = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public int AbsenceType { get => _AbsenceType; set => _AbsenceType = value; }
    }
}

