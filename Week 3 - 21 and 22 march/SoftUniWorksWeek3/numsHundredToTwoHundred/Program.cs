using System;

namespace numsHundredToTwoHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            if (n1 >= 100 && n1 <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (n1 < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (n1 > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
