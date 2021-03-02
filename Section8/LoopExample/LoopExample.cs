using System;

namespace LoopExample
{
    class LoopExample
    {
        static void Example()
        {
            string inValue = "";
            while (inValue != "−99")
            {
                Console.Write("\nEnter value (−99 to exit): ");
                inValue = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
