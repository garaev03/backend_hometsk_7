using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_7.Models
{
    internal class Car:Gallery
    {
        private static int i = 1000;
        private int _speed;
        private string _carCode;
        public int Speed
        {
            get => _speed;
            set
            {
                while (value < 0)
                {

                    value = int.Parse(Console.ReadLine());
                }
                _speed = value;
            }
        }
        public string CarCode
        {
            get => _carCode;
            set
            {
                string firstLetter = value[0].ToUpperAndString();
                string secondLetter= value[1].ToUpperAndString();
                i++;
                _carCode = firstLetter + secondLetter+$"{i}";             
            }
        }

        public Car(string name)
        {
            Name = name;
            CarCode = name;
        }
    }
}
