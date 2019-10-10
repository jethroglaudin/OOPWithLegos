using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* Instantiate the BullDozer class.
             * Make a copy of the blueprint for each dozer */
            var dozer = new BullDozer ("Yellow", "Mini");
            
            var dozer2 = new BullDozer("Red", "Large");
            

            Console.WriteLine("Bulldozer is: " + dozer.color);
            Console.WriteLine("Bulldozer2 is: " + dozer2.color);
        }
    }

    public class BullDozer
    {
        // Constructor will have the same name as the class
        public BullDozer (string _color, string _size)
        {
            this.color = _color;
            this.size = _size;
        }

        public string color { get; set; }
        public string size { get; set; }
    }
}
