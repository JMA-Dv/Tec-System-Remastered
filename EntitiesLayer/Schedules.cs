using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Schedules
    {
        private int _IdSchedule;
        private char _Group;
        private int _Day;
        private int _Time;
        private char _ClassRoom;

        public int IdSchedule { get => _IdSchedule; set => _IdSchedule = value; }
        public char Group { get => _Group; set => _Group = value; }
        public int Day { get => _Day; set => _Day = value; }
        public int Time { get => _Time; set => _Time = value; }
        public char ClassRoom { get => _ClassRoom; set => _ClassRoom = value; }
    }
}
