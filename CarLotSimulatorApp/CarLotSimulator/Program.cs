using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
          
            CarLot lot = new CarLot();
           
            {  //dot. notation way
                Car firstCar = new Car();
                firstCar.Make = "Honda";
                firstCar.Model = "Element";
                firstCar.Year = 2008;
                firstCar.EngineNoise = "Yikes";
                firstCar.HonkNoise = "bleep";
                firstCar.IsDriveable = false;

                lot.ListOfCars.Add(firstCar);// .Add adds to list  put here after it is declared (really line 17)
                Console.WriteLine($"Numbe of Cars: {CarLot.numberOfCars}");

                // 2nd car object initilizer way
                var secondCar = new Car()  // new object called Mazda, usec Car class as blueprint
               {
                Make = "Jeep",
                Model = "Wrangler",
                Year = 2050,
                EngineNoise = "Grrrrr",
                HonkNoise = "yeah-haw",
                IsDriveable = true,
               };
               lot.ListOfCars.Add(secondCar);// .Add adds/put to list
                Console.WriteLine($"Numbe of Cars: {CarLot.numberOfCars}");


                //3rd way passing thru constructor way
                var thirdCar = new Car();
                thirdCar.Make = "VW";
                thirdCar.Model = "Bug";
                thirdCar.Year = 2001;
                thirdCar.EngineNoise = "hickup";
                thirdCar.HonkNoise = "brump";
                thirdCar.IsDriveable = true;
                               
                lot.ListOfCars.Add(thirdCar);// .Add adds to list
                Console.WriteLine($"Numbe of Cars: {CarLot.numberOfCars}");


                //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                //At the end iterate through the list printing each of car's Year, Make, and Model to the console

                //var carList = new List<Car>() { firstCar, secondCar, thirdCar };

                foreach (var carInfo in lot.ListOfCars)
                {
                    Console.WriteLine($"{carInfo.Make} {carInfo.Model} {carInfo.Year} {carInfo.EngineNoise} {carInfo.HonkNoise} {carInfo.IsDriveable}");
                }

                //*************BONUS*************//

                // Set the properties utilizing the 3 different ways we learned about, one way for each car

                //*************BONUS X 2*************//

            }
        }
    }
}
