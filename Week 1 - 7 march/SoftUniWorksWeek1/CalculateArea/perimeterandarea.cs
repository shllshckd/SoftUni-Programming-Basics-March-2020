﻿using System;

namespace CalculateArea
{
    class perimeterandarea
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());

            int area = sideA * sideB;
            int perimeter = 2 * (sideA + sideB);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
