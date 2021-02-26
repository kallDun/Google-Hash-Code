using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Google_Hash_Code
{
    class Output_Service : InputOutput_Parent
    {
        public void Output(List<Light> lights)
        {
            using (StreamWriter streamWriter = new StreamWriter(Output_Path))
            {
                lights = lights.Where(x => x.street_GreenLights.Count() != 0).ToList();
                streamWriter.WriteLine(lights.Count());

                for(int i = 0; i < lights.Count; i++)
                {
                    Dictionary<Street, int> streets = lights[i].street_GreenLights;

                    streamWriter.WriteLine(lights[i].crossRoad.number);
                    streamWriter.WriteLine(streets.Count);
                    foreach (var street in streets)
                    {
                        string text = street.Key.Name + " " + street.Value;
                        streamWriter.WriteLine(text);
                    }
                }

            }
        }
    }
}
