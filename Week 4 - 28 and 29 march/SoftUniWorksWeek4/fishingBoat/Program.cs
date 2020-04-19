using System;

namespace fishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());
            double rentBoat = 0;

            switch (season)
            {
                case "Spring":
                    rentBoat = 3000;
                    if (6 >= fishermanCount)
                    {
                        rentBoat *= 0.90;
                    }
                    else if (7 >= fishermanCount && 11 >= fishermanCount)
                    {
                        rentBoat *= 0.85;
                    }
                    else if (fishermanCount >= 12)
                    {
                        rentBoat *= 0.75;

                    }
                    break;

                case "Summer":
                    rentBoat = 4200;
                    if (6 >= fishermanCount)
                    {
                        rentBoat *= 0.90;
                    }
                    else if (7 >= fishermanCount && 11 >= fishermanCount)
                    {
                        rentBoat *= 0.85;
                    }
                    else if (fishermanCount >= 12)
                    {
                        rentBoat *= 0.75;

                    }
                    break;

                case "Autumn":
                    rentBoat = 4200;
                    if (6 >= fishermanCount)
                    {
                        rentBoat *= 0.90;
                    }
                    else if (7 >= fishermanCount && 11 >= fishermanCount)
                    {
                        rentBoat *= 0.85;
                    }
                    else if (fishermanCount >= 12)
                    {
                        rentBoat *= 0.75;

                    }
                    break;

                case "Winter":
                    rentBoat = 2600;
                    if (6 >= fishermanCount)
                    {
                        rentBoat *= 0.90;
                    }
                    else if (7 >= fishermanCount && 11 >= fishermanCount)
                    {
                        rentBoat *= 0.85;
                    }
                    else if (fishermanCount >= 12)
                    {
                        rentBoat *= 0.75;

                    }
                    break;

                default:
                    break;
            }
            //unfinished
        }
    }
}
