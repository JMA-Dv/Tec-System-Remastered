using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Califications
    {
        private int IdCalification;
        private char _Group;
        private char _Enrollment;
        private int _Topic;
        private float _Calification;
        private char _TypeEvaluation;

        public int IdCalification1 { get => IdCalification; set => IdCalification = value; }
        public char Group { get => _Group; set => _Group = value; }
        public char Enrollment { get => _Enrollment; set => _Enrollment = value; }
        public int Topic { get => _Topic; set => _Topic = value; }
        public float Calification { get => _Calification; set => _Calification = value; }
        public char TypeEvaluation { get => _TypeEvaluation; set => _TypeEvaluation = value; }
    }
}
