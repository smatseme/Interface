using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    interface IVehicle {

        void changeGear(int x);
        void speedUp(int x);
        void applyBrakes(int x);
    }


    class Bicycle : IVehicle {

        int speed;
        int gear;

        public void applyBrakes(int decreament)
        {
            speed -= decreament;
        }

        public void changeGear(int nextGear)
        {
            gear = nextGear;
        }

        public void speedUp(int increament)
        {
            speed += increament;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed +
                              " gear: " + gear);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            bicycle.changeGear(2);
            bicycle.speedUp(4);
            bicycle.applyBrakes(3);

            Console.WriteLine("Bicycle present state");
            bicycle.printStates();

        }
    }
}
