using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Hash_Code
{
    class Logic
    {
        Input_Service input_Service = new Input_Service();
        Output_Service output_Service = new Output_Service();


        public Logic()
        {
            int time = input_Service.I;

            var cars = input_Service.listOfCars.OrderBy(x => calcTimePerCar(x));

            var trafficLights = CreateObjectsService.CreateLights(input_Service.listOfCrossroads);

            foreach (var car in cars)
            {
                int street_time = 0;

                foreach (var street in car.streets)
                {
                    street_time += street.time;

                    var light = trafficLights.Find(x => x.crossRoad == street.crossroad_2);

                    int seconds = street_time / findFactor(street_time);

                    if (!light.street_GreenLights.ContainsKey(street))
                    {
                        int streetLights_time = 0;
                        foreach (var l in light.street_GreenLights)
                        {
                            streetLights_time += l.Value;
                        }
                        light.street_GreenLights.Add(street, seconds);
                    }
                }
            }

            output_Service.Output(trafficLights);
        }

        public int calcTimePerCar(Car car)
        {
            int time = 0;
            List<Street> list = car.streets;
            foreach (Street street in list)
            {
                time += street.time;
            }

            return time;
        }

        public int findFactor(int val) 
        {
            return val;
        }
    }
}
