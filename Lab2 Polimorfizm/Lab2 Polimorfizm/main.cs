using System;
using System.Collections.Generic;

namespace Lab2_Polimorfizm
{
    class main
    {
        static void Main(string[] args)
        {
            List<car> cars = new List<car>();

            cars.Add(new lpgCar());
            cars.Add(new gasolineCar());
            cars.Add(new ev());

            foreach (var car in cars)
            {
                car.TestDrive();
            }
        }
    }
}
