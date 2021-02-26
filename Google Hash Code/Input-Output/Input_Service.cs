using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Hash_Code
{
    class Input_Service : InputOutput_Parent
    {
        public Input_Service() => Input();

        public int D {get; set;}
        public int I {get; set;}
        public int F {get; set;}
        public List<Street> listOfStreets { get; set; } = new List<Street>();
        public List<CrossRoad> listOfCrossroads { get; set; }
        public List<Car> listOfCars { get; set; } = new List<Car>();

        private void Input()
        {
            using (StreamReader streamReader = new StreamReader(Input_Path))
            {
                var data = streamReader.ReadLine().Split().Select(int.Parse).ToArray();

                D = data[0];
                I = data[1];
                listOfCrossroads = CreateObjectsService.CreateCrossRoads(I);
                int S = data[2];
                int V = data[3];
                F = data[4];
                for (int i = 0; i < S; i++) 
                {
                    string[] s = streamReader.ReadLine().Split();
                    int crossroad_1 = int.Parse(s[0]);
                    int crossroad_2 = int.Parse(s[1]);
                    string name = s[2];
                    int time = int.Parse(s[3]);
                    var cross_1 = listOfCrossroads.Find(x => x.number == crossroad_1);
                    var cross_2 = listOfCrossroads.Find(x => x.number == crossroad_2);
                    Street street = new Street(cross_1, cross_2, name, time);
                    cross_1.streets.Add(street);
                    cross_2.streets.Add(street);
                    listOfStreets.Add(street);
                }
                for (int i = 0; i < V; i++) 
                {
                    List<Street> streets = new List<Street>();
                    string[] s = streamReader.ReadLine().Split();
                    int length = int.Parse(s[0]);
                    for (int j = 1; j < length; j++) 
                    {
                        Street street = listOfStreets.Where(temp => temp.Name.Equals(s[j])).First();
                        streets.Add(street);
                    }
                    Car car = new Car(streets);
                    listOfCars.Add(car);
                }
            }
        }
    }
}
