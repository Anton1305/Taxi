﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args) 
        { 
            //membuat ojek Taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = false;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}