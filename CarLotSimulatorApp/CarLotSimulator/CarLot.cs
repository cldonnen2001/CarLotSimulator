﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        //Create a CarLot class
        //It should have at least one property: a List of cars
        

        public static int numberOfCars;
        public List<Car> ListOfCars { get; set; } = new List<Car>();  // initilaze as a new List of Car

    }
}
