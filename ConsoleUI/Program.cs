using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            Car car = new Car()
            {
                HasTrunk = true,
                Year = "2023",
                Make = "Honda",
                Model = "Accord"
            };

            Motorcyle motorcyle = new Motorcyle()
            {
                HasSideCart = true,
                Year = "2001",
                Make = "Kawasaki",
                Model = "Ninja"
            };

            Vehicle car2 = new Car()
            {
                Year = "2020",
                Make = "Ford",
                Model = "Focus"
            };

            Vehicle car3 = new Motorcyle()
            {
                Year = "2010",
                Make = "Toyota",
                Model = "Tacoma"
            };


            vehicles.Add(car);
            vehicles.Add(motorcyle);
            vehicles.Add(car2);
            vehicles.Add(car3);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveAbstract();
                vehicle.DriveVirtual(); 
                Console.WriteLine();    
            }


            /*
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle


            Console.ReadLine();
        }
    }
}
