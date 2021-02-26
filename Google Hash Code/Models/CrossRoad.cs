using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Hash_Code
{
    class CrossRoad
    {
        public Light trafficLight { get; set; }
        public int number { get; set; }
        public List<Street> streets { get; set; } = new List<Street> { };

        public CrossRoad(int number)
        {
            this.number = number;
        }
    }
}
