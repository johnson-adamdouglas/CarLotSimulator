using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarCounter.numberOfCars++;
            //ClassName.staticMember
        }

        // Custom Constructor
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            //Property = Parameter
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }


        //Properties:
        //Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //get, set makes it a property, otherwise it's a field
        //get = read function, set = write function
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        public void MakeEngineNoise(string engineNoise) { Console.WriteLine($"{EngineNoise}"); }
        public void MakeHonkNoise(string honkNoise) { Console.WriteLine($"{HonkNoise}"); }

    }
}
