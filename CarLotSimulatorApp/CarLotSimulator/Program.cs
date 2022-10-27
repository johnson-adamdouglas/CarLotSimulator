using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot myLot = new CarLot();
            


            Car myCar = new Car();
            myCar.Year = 2015;
            myCar.Make = "Ford";
            myCar.Model = "Expedition";
            myCar.EngineNoise = "Vrooom!";
            myCar.HonkNoise = "Honk! Honk! Honk!";
            myCar.IsDriveable = true;
            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();
            myLot.CarList.Add(myCar);

            Console.WriteLine();

            Car notMyCar = new Car()
            {
                Year = 1984,
                Make = "Ford",
                Model = "Pinto",
                EngineNoise = "Put put ptdaplop put",
                HonkNoise = "Beep beep ahooooga",
                IsDriveable = true
            };
            notMyCar.MakeEngineNoise();
            notMyCar.MakeHonkNoise();
            myLot.CarList.Add(notMyCar);

            Console.WriteLine();

            Car dreamCar = new Car(2050, "Ford", "Mustang", "Ziiiipppyyyyy!", "Getouttamyway!!!!!", true);
            dreamCar.MakeEngineNoise();
            dreamCar.MakeHonkNoise();
            myLot.CarList.Add(dreamCar);

            Console.WriteLine();

            foreach(Car car in myLot.CarList)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine(car.EngineNoise);
                Console.WriteLine(car.HonkNoise);
                Console.WriteLine();
            }



            //TODO

            //DONE-Create a seperate class file called Car
            //DONE-Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE-Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE-The methods should take one string parameter: the respective noise property


            //DONE-Now that the Car class is created we can instanciate 3 new cars
            //DONE-Set the properties for each of the cars
            //DONE-Call each of the methods for each car

            //*************BONUS*************//

            // DONE-Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE-Create a CarLot class
            //DONE-It should have at least one property: a List of cars
            //DONE-Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //DONE-At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
