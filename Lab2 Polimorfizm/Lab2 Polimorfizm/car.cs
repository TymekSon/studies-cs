using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Polimorfizm
{
    public abstract class car
    {

        public bool engineRunning = false;
        public bool tankFilled = false;
        public bool driving = false;
        public virtual void Fill()
        {
            if (driving == false && engineRunning == false)
            {
                tankFilled = true;
            }
        }

        public virtual void Start()
        {
            if (tankFilled)
            {
                engineRunning = true;
            }
        }

        public virtual void Stop()
        {
            engineRunning = false;
        }

        public virtual void Drive()
        {
            if (engineRunning)
            {
                driving = true;
                tankFilled = false;
            }
        }

        public virtual void TestDrive()
        {
            Console.WriteLine($"{this} test drive:");
            Console.WriteLine();
            this.Fill();
            this.Fill();
            this.Drive();
            this.Start();
            this.Start();
            this.Drive();
            this.Drive();
            this.Stop();
            this.Stop();
            Console.WriteLine();
        }
    }
}
