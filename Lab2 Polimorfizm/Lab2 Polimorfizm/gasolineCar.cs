﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Polimorfizm
{
    public class gasolineCar : car
    {
        public override void Start()
        {
            if (engineRunning == false)
            {
                base.Start();
                if (engineRunning == true)
                {
                    Console.WriteLine("\tTurning on the gasoline engine...");
                }
                else
                {
                    Console.WriteLine("\tCannot start the engine, gasoline tank is empty");
                }
            }
            else
            {
                Console.WriteLine("\tGasoline engine is already running");
            }
        }

        public override void Stop()
        {
            if (engineRunning == true)
            {
                base.Stop();
                Console.WriteLine("\tStopping the car...");
            }
            else
            {
                Console.WriteLine("\tCar is already stopped");
            }
        }

        public override void Fill()
        {
            if (tankFilled == false)
            {
                base.Fill();
                if (tankFilled == true)
                {
                    Console.WriteLine("\tFilling the tank...");
                }
                else
                {
                    Console.WriteLine("\tCannot fill the tank");
                }
            }
            else
            {
                Console.WriteLine("\tTank is already filled");
            }
        }
        public override void Drive()
        {
            if (driving == false)
            {
                base.Drive();
                if (driving == true)
                {
                    Console.WriteLine("\tWe start driving...");
                }
                else
                {
                    Console.WriteLine("\tCannot drive the car");
                }
            }
            else
            {
                Console.WriteLine("\tCar is moving already");
            }
        }
    }
}
