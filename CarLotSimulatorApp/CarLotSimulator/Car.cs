using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()  // default constructor
        {
            CarLot.numberOfCars++;

        }
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)  // method overloading 2nd constructor,defined in class
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        //properites- need this
        public string Make { get; set; }  //Create a Make property of type string that is public (ge = read, set = write)
        public string Model { get; set; } //Create a Model property of type string that is public
        public int Year { get; set; }//Create a Year property of type int that is public
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

    }

}