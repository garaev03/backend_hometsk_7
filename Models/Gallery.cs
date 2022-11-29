using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_7.Models
{
    internal class Gallery
    {
        private int _id;
        private string _name;
        static Car[] cars = new Car[0];

        public string Name
        {
            get => _name;
            set
            {
                while (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    Console.Write("Please enter valid car name: ");
                    value = Console.ReadLine();
                }
                string firstLetter = value[0].ToUpperAndString();
                value = value.Remove(0, 1);
                _name = firstLetter + value;
            }
        }
        public int Id
        {
            get => _id;
            set
            {
                while (value < 0)
                {
                    Console.Write("\nPlease enter valid id: ");
                    value = int.Parse(Console.ReadLine());
                }
                foreach (var car in cars)
                {
                    if (value == car.Id)
                        Console.WriteLine("\nThere is car with this id!");
                    while (value == car.Id || value < 0)
                    {
                        Console.Write("\nPlease enter valid id: ");
                        value = int.Parse(Console.ReadLine());
                    }
                }
                _id = value;
            }
        }

        public static void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;
        }
        public static void ShowAllCars()
        {
            foreach (var car in cars)
                Console.WriteLine("Car: " + car.Name);
        }
        public static Car[] GetAllCars()
        {
            Car[] AllCars = cars;
            return AllCars;
        }
        public static void FindCarById(int value)
        {
            foreach (var car in cars)
            {
                if (car.Id == value)
                {
                    Console.WriteLine($"{value} Car: " + car.Name);
                    return;
                }
            }
            Console.WriteLine("\nThere is no car identified with entered id!");
        }
        public static void FindCarByCode(string code)
        {
            foreach (var car in cars)
            {
                if (car.CarCode == code)
                {
                    Console.WriteLine($"{code} Car: " + car.Name);
                    return;
                }
            }
            Console.WriteLine("\nThere is no car identified with entered car code!");
        }
        public static void FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            Console.WriteLine($"Cars between {minSpeed} and {maxSpeed} : ");
            foreach (var car in cars)
            {
                if (car.Speed <= maxSpeed && car.Speed >= minSpeed)
                    Console.WriteLine("Car: " + car.Name);
            }
        }
    }
}
