using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Groups
    {
        private char _CveGroup;
        private char _Subjects;
        private String _Professor;

        public char CveGroup { get => _CveGroup; set => _CveGroup = value; }
        public char Subjects { get => _Subjects; set => _Subjects = value; }
        public string Professor { get => _Professor; set => _Professor = value; }
    }
}
