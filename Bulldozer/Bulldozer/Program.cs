using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            var result = worker.AddNumbers(2, 3);

            Console.WriteLine(result.ToString());
            
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }

        public int AddNumbers (int num1, int num2)
        {
            var result = num1 + num2;
            result = result + 100;
            result = result - 100;
            return result;
        }
   
    }
}

//Make a car class that has colour and manafacture. Make car1 object instantiate with color red
// and manufacturer (Toyota), Make a new Saloon Car class that inherits form Car class
// Add new property called numberOfSeats

    // Write 3 constructors to do the following.
    // Constructor 1 allows assignment of numberOfSeats only
    // Constructor 2 allows assignment of manafacturer only
    // Constructor 4 allows assignment of numberOfSeats, manufactuer and color

    // Create object saloonCar1 with 2 Seats
    // Create object saloonCar2 with 3 seats and manufactuer Nissan
    // Create object saloonCar3 with 3 seats manafactuer Ford and color purple