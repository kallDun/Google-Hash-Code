using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Hash_Code
{
    class Light
    {
        public Street activeStreet { get; set; }
        public CrossRoad crossRoad { get; private set; }
        public Dictionary<Street, int> street_GreenLights { get; set; } = new Dictionary<Street, int>();

        public Light(CrossRoad crossRoad)
        {
            this.crossRoad = crossRoad;
        }
    }
}
