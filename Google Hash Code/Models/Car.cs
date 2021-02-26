using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Hash_Code
{
    class Car
    {
        public List<Street> streets;
        public Street street_now;
        public int time_to_intersection;

        public Car(List<Street> street)
        {
            this.streets = street;
            street_now = street.First();
        }
    }
}
