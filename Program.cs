using hometask_7.Models;
namespace hometask_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--------------------\n--1.Add Car\n--2.Show All Cars\n--3.Find Car\n--0.Exit\n--------------------\n");
                Console.Write("Enter key: "); int value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 0:
                        return;
                    case 1:
                        ;
                        Console.Write("\nEnter car name: "); Car car = new(Console.ReadLine());
                        Console.Write("Enter car id:   "); car.Id = int.Parse(Console.ReadLine());
                        Console.Write("Enter car speed:  "); car.Speed = int.Parse(Console.ReadLine());
                        Gallery.AddCar(car);
                        break;
                    case 2:
                        Gallery.ShowAllCars();
                        break;
                    case 3:
                        Console.WriteLine("\nOptions for finding car: \n1.Find car by id\n2.Find ar by car code\n3.Find car by speed interval\n0.Go back\n");
                        Console.Write("Enter key: "); value = int.Parse(Console.ReadLine());
                        if (value == 0)
                            break;
                        else if (value == 1)
                        {
                            Console.Write("\nEnter car id: ");
                            Gallery.FindCarById(int.Parse(Console.ReadLine()));
                        }
                        else if (value == 2)
                        {
                            Console.Write("\nEnter car code: ");
                            Gallery.FindCarByCode(Console.ReadLine());
                        }
                        else if (value == 3)
                        {
                            Console.Write("\nEnter car's minimum and maximum speed: ");
                            Gallery.FindCarsBySpeedInterval(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                        }
                        else
                        {
                            Console.WriteLine("\nenter valid key!");
                            goto case 3;
                        }
                        break;
                    default:
                        Console.WriteLine("\nenter valid key!");
                        break;
                }
            }
        }
    }
}