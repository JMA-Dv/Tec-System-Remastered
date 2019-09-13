using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Persons
    {
        private int _IdPerson;
        private String _Names;
        private String _FatherLastName;
        private String _MatherLastName;
        private DateTime _BirthDay;
        private int _Gender;
        private char _Curp;
        private String _Phone;
        private int _IdStreet;
        private String _ExtNumber;
        private String _IntNumber;
        private String _PostalCode;
        private String _MaritalStatus;
        private int _Disability;

        public int IdPerson { get => _IdPerson; set => _IdPerson = value; }
        public string Names { get => _Names; set => _Names = value; }
        public string FatherLastName { get => _FatherLastName; set => _FatherLastName = value; }
        public string MatherLastName { get => _MatherLastName; set => _MatherLastName = value; }
        public DateTime BirthDay { get => _BirthDay; set => _BirthDay = value; }
        public int Gender { get => _Gender; set => _Gender = value; }
        public char Curp { get => _Curp; set => _Curp = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public int IdStreet { get => _IdStreet; set => _IdStreet = value; }
        public string ExtNumber { get => _ExtNumber; set => _ExtNumber = value; }
        public string IntNumber { get => _IntNumber; set => _IntNumber = value; }
        public string PostalCode { get => _PostalCode; set => _PostalCode = value; }
        public string MaritalStatus { get => _MaritalStatus; set => _MaritalStatus = value; }
        public int Disability { get => _Disability; set => _Disability = value; }
    }
}
