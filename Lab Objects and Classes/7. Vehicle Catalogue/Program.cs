using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace _7._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();           
            string input = Console.ReadLine();
            while (input != "end") 
            {
                string[] tokens = input.Split("/");

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                
                switch(type)
                {
                    case "Car":
                        Car car = new Car();
                        car.Brand = brand;
                        car.Model = model;
                        car.HorsePower = int.Parse(tokens[3]);
                        cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck();
                        truck.Brand = brand;
                        truck.Model = model;
                        truck.Weight = int.Parse(tokens[3]);
                        trucks.Add(truck);
                        break;

                }

                input = Console.ReadLine();
                                            
            }

            cars = cars.OrderBy(car => car.Brand).ToList();
            trucks = trucks.OrderBy(truck => truck.Brand).ToList();
            Catalog catalog = new Catalog(cars, trucks);    
            if (catalog.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
            
        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    public class Car 
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class Catalog
    {

       
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set;}
        public Catalog(List<Car> cars , List<Truck> trucks)
        {
            this.Trucks = trucks;
            this.Cars = cars;
        }
    }
}

