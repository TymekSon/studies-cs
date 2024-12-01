using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Polimorfizm
{
    public class ev : car
    {
        public override void Start()
        {
            if (engineRunning == false)
            {
                base.Start();
                if (engineRunning == true)
                {
                    Console.WriteLine("\tTurning on the electric motor...");
                }
                else
                {
                    Console.WriteLine("\tCannot start the motor, batteries are discharged");
                }
            }
            else
            {
                Console.WriteLine("\telectric motor is already turned on");
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
                    Console.WriteLine("\tCharging the batteries...");
                }
                else
                {
                    Console.WriteLine("\tCannot charge the batteries");
                }
            }
            else
            {
                Console.WriteLine("\tBatteries are already charged");
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
