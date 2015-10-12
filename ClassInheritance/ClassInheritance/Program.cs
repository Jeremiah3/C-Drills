using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //New instance or object of Class Car
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            //New instance/Object of Class Truck 
            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;



            myCar.PrintMe();
            myTruck.PrintMe();

            Console.ReadLine();
        }

        private static void someMethod(Car car)
        {
            Console.WriteLine("From someMethod: {0}", car.Make);
        }




    }

    //Serves as the Base class of Classes Car and Truck.
    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract void PrintMe();
    }


    class Car : Vehicle
    {

        public override void PrintMe()
        {
            Console.WriteLine("{0} - {1}", this.Make, this.Model);
        }

    }


    sealed class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }


        public override void PrintMe()
        {
            Console.WriteLine("{0} - {1}", this.Make, this.TowingCapacity.ToString());
        }

    }
}
    

