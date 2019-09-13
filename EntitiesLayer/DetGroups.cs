using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class DetGroups
    {
        private int _IdDetGroup;
        private char _CveGroup;
        private char _Enrollment;
        private char _TypeCourse;

        public int IdDetGroup { get => _IdDetGroup; set => _IdDetGroup = value; }
        public char CveGroup { get => _CveGroup; set => _CveGroup = value; }
        public char Enrollment { get => _Enrollment; set => _Enrollment = value; }
        public char TypeCourse { get => _TypeCourse; set => _TypeCourse = value; }
    }
}
