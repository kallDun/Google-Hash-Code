using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Hash_Code
{
    class Street
    {
        public CrossRoad crossroad_1 { get; private set; }
        public CrossRoad crossroad_2 { get; private set; }
        public string Name { get; private set; }
        public int time { get; private set; }

        public Street(CrossRoad crossroad_1, CrossRoad crossroad_2, string name, int time)
        {
            this.crossroad_1 = crossroad_1;
            this.crossroad_2 = crossroad_2;
            Name = name;
            this.time = time;
        }
    }
}
