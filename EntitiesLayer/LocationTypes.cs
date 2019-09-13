using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{

    public class LocationTypes
    {
        private int _LocationType;
        private String _Type;

        public int LocationType { get => _LocationType; set => _LocationType = value; }
        public string Type { get => _Type; set => _Type = value; }
    }
}
