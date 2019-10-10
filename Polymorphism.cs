 using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(5);

            worker.Count(4.5f);

            worker.Count(4, 5, 11.2);
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }
        public void Count (int number)
        {
            if (Total == null)
                Total = 0;

            Total = Total + Convert.ToSingle(number);
            Console.WriteLine(Total.ToString());
        }
        // Polymorphism
        // this method Count is only called when passed a float
        public void Count(float number)
        {
            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }

        public void Count (int num1, float num2, double num3)
        {
            // code to add all three
            // add to Total
            Total = Total + num1 + num2 + Convert.ToSingle(num3);
            Console.WriteLine(Total.ToString());
        }
        // class variable
        public float Total { get; set; }
    }
}
