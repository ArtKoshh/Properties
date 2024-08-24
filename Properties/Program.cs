using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Box box = new Box(3,4,5);   
           
            /*
            Box box = new Box();
            box.Setlength(4);
            box.Height = -4;
            box.Width = 5;
            */
            
            Console.WriteLine("Box Width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("Box Width is " + box.Width);
            Console.WriteLine("Box volume is " + box.Volume);
            box.DisplayInfo();
        }

    }
}
