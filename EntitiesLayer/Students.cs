using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Students
    {
        private int _Enrollment;
        private int _IdPerson;
        private int _IdCarrer;
        private int _Tutor;
        private int _IdSpeciality;
        private int _Status;

        public int Enrollment { get => _Enrollment; set => _Enrollment = value; }
        public int IdPerson { get => _IdPerson; set => _IdPerson = value; }
        public int IdCarrer { get => _IdCarrer; set => _IdCarrer = value; }
        public int Tutor { get => _Tutor; set => _Tutor = value; }
        public int IdSpeciality { get => _IdSpeciality; set => _IdSpeciality = value; }
        public int Status { get => _Status; set => _Status = value; }
    }
}
