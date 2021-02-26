using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Hash_Code
{
    static class CreateObjectsService
    {

        public static List<CrossRoad> CreateCrossRoads(int number)
        {
            var crossRoads = new List<CrossRoad> { };

            for (int i = 0; i < number; i++)
            {
                crossRoads.Add(new CrossRoad(i));
            }

            return crossRoads;
        }

        public static List<Light> CreateLights(List<CrossRoad> crossroads)
        {
            var lights = new List<Light> { };

            for (int i = 0; i < crossroads.Count; i++)
            {
                lights.Add(new Light(crossroads[i]));
            }

            return lights;
        }

        public static void ClearLightWIthoutDict(ref List<Light> lights)
        {
            for (int i = lights.Count - 1; i >= 0; i--)
            {
                if (lights[i].street_GreenLights.Count == 0) lights.Remove(lights[i]);
            }
        }

    }
}
