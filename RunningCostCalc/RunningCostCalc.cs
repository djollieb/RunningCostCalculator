using System.Collections.Generic;

namespace RunningCostCalc
{
    class RunningCostCalc
    {
        static private List<object> cars;

        static void Main(string[] args)
        {
            GetCars();
            DisplayCars();            
            AddCars();
        }

        private static void GetCars()
        {
            cars = new List<object>();
            cars.Add(new DieselCar("Ford", "Focus 1.4d", 50f));
            cars.Add(new DieselCar("Vauxhall", "Adam 1.2d", 57f));
            cars.Add(new DieselCar("Jaguar", "XK 2.4d", 45f));
            cars.Add(new PetrolCar("Seat", "Ibiza 1.1", 45f));
            cars.Add(new PetrolCar("Renault", "Clio 1.4", 40f));
            cars.Add(new PetrolCar("Kia", "Ceed 1.8", 38f));
            //cars.Add(new LPGCar("GazCo", "Gaz 1.1", 55f));
            //cars.Add(new LPGCar("GazCo", "GazPlus 1.8", 45f));
            //cars.Add(new LPGCar("GazCo", "GazSUV 2.4", 40f));
        }

        private static void AddCars()
        {
            System.Console.WriteLine("Would you like to add a petrol of diesel car?");
            string fuelType = System.Console.ReadLine();
            if (fuelType == "diesel" || fuelType == "petrol")
            {
                // do nothing
            }
            else
            {
                System.Console.WriteLine("Error - please enter either 'petrol' or 'diesel'");
                AddCars();
            }
            System.Console.WriteLine("What is the Make of the car?");
            string newMake = System.Console.ReadLine();
            System.Console.WriteLine("What is the Model of the car?");
            string newModel = System.Console.ReadLine();
            System.Console.WriteLine("What is the MPG of the car?");
            float newMPG = float.Parse(System.Console.ReadLine());

            if (fuelType == "diesel")
            {
                cars.Add(new DieselCar(newMake, newModel, newMPG));
                DisplayCars();
            }
            else
            {
                cars.Add(new PetrolCar(newMake, newModel, newMPG));
                DisplayCars();
            }
        }

        private static void DisplayCars()
        {
            System.Console.WriteLine(string.Format("{0}{1}{2}", "Make".PadRight(25), "Model".PadRight(25), "MPG"));
            System.Console.WriteLine("".PadRight(60, '-'));

            foreach (var unknownCar in cars)
            {
                var type = unknownCar.GetType();

                if (type == typeof(DieselCar))
                {
                    var car = (DieselCar)unknownCar;
                    System.Console.WriteLine(string.Format("{0}{1}{2}", car.make.PadRight(25), car.model.PadRight(25), car.milesPerGallon));
                }
                else if (type == typeof(PetrolCar))
                {
                    var car = (PetrolCar)unknownCar;
                    System.Console.WriteLine(string.Format("{0}{1}{2}", car.make.PadRight(25), car.model.PadRight(25), car.milesPerGallon));
                }                
            }
            System.Console.WriteLine("\n\nPress Any Key To Exit");
            System.Console.ReadLine();
        }
    }
    
}
