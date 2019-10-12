using System;

namespace Cars
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var car1 = new Car("Red", "Toyota");
            var car1 = new Car();
            car1.color = "Red";
            car1.manufacturer = "Toyota";
            //Console.WriteLine("Car's color is: " + car1.color);
            //Console.WriteLine("The manufacturer is: " + car1.manufacturer);

            var saloonCar1 = new SaloonCar();
            saloonCar1.Constructor1(2);

            var saloonCar2 = new SaloonCar();
            saloonCar2.Constructor2(3, "Nissan");

            var saloonCar3 = new SaloonCar();
            saloonCar3.Constructor3(4, "Ford", "Purple");


        }
    }

    public class Car
    {
        //public Car(string _color, string _manufacturer)
        public Car()
        {
            //this.color = _color;
            //this.manufacturer = _manufacturer;

        }
        public string color { get; set; }
        public string manufacturer { get; set; }
    }

    public class SaloonCar : Car
    {
        public SaloonCar()
        {
            
        }
        public int numberOfSeats { get; set; }

        public void Constructor1 (int number)
        {
            Seats = Seats + number;
            Console.WriteLine(Seats.ToString());
        }

        public void Constructor2(int number, string input)
        {
            Seats = Seats + number;
            Manufacturer = input;
            Console.WriteLine(Seats.ToString());
            Console.WriteLine(Manufacturer);
        }

        public void Constructor3(int number, string input, string input2)
        {
            Seats = Seats + number;
            Manufacturer = input;
            CarColor = input2;

            Console.WriteLine(Seats.ToString());
            Console.WriteLine(Manufacturer);
            Console.WriteLine(CarColor);
        }


        public int Seats { get; set; }
        public string Manufacturer { get; set; }
        public string CarColor { get; set; }
    }


}
