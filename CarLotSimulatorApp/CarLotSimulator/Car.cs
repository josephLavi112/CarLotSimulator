using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car() 
        {
            CarLot._numberOfCars++;

        }
        public Car(int year, string make, string model, string EngineNoise, string HonkNoise, bool IsDriveable) 
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = EngineNoise;
            HonkNoise = HonkNoise;

            CarLot._numberOfCars++;
            
        
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; } 
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}");
        }

        public void MakeHonkNoise() 
        {
            Console.WriteLine($"{HonkNoise}");
        }

    }  
}
