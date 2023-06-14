using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carlot = new CarLot();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car lambo = new Car();
            lambo.Year = 2010;
            lambo.Make = "Lamborghini";
            lambo.Model = "Gallardo";
            lambo.EngineNoise = "vrrrrooom";
            lambo.HonkNoise = "boom";
            lambo.IsDriveable = false;
            lambo.MakeEngineNoise();
            lambo.MakeHonkNoise();

            Console.WriteLine($"number of cars at this point {CarLot._numberOfCars}");

            carlot.CarList.Add(lambo);

            Car ford = new Car();
            ford.Year = 1980;
            ford.Make = "Ford";
            ford.Model = "Taurus";
            ford.EngineNoise = "clunk clunk";
            ford.HonkNoise = "buhhh buhhhh";
            ford.IsDriveable = true;
            ford.MakeEngineNoise();
            ford.MakeHonkNoise();

            Console.WriteLine($"number of cars at this point {CarLot._numberOfCars}");

            carlot.CarList.Add(ford);

            Car vw = new Car();
            vw.Year = 2004;
            vw.Make = "Volkswagon";
            vw.Model = "Punchbug";
            vw.EngineNoise = "brauuuuuu";
            vw.HonkNoise = "beep";
            vw.IsDriveable = true;

            vw.MakeEngineNoise();
            vw.MakeHonkNoise();
            carlot.CarList.Add(vw);



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car ford2 = new Car()

            {
                Year = 1980,
                Make = "Ford",
                Model = "Taurus",
                EngineNoise = "clunk clunk",
                HonkNoise = "buhhh buhhhh",
                IsDriveable = true,

            };
           
            Console.WriteLine($"number of cars at this point {CarLot._numberOfCars}");

            ford.MakeEngineNoise();
            ford.MakeHonkNoise();

            Car lambo2 = new Car(2010, "Lamborghini", "Gallardo", "vrrrrooom", "boom", false);


            {
                lambo2.MakeEngineNoise();
                lambo2.MakeHonkNoise();
            }
            
            Console.WriteLine($"number of cars at this point {CarLot._numberOfCars}");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var Car in carlot.CarList)
            {
                Console.WriteLine($"{Car.Year} {Car.Make} {Car.Model}");
            }



        }
    }
}
