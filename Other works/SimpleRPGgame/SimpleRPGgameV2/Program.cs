using System;

namespace SimpleRPGgameV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, your name is:");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome to the game, {playerName}! Have fun. :)");

            // player stats
            int playerHP = 100;
            int playerXP = 0;
            int playerLvl = 1;
            int playerAttack = 10;
            int playerCoins = 0;
            bool isAlive = true;

            int roomCount = 0;
            while (isAlive) // gameloop
            {
                roomCount++;
                Console.WriteLine($"=== room {roomCount} ===");
                int roomType = new Random().Next(1, 9);
                switch (roomType)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6: // meet a monster
                        int monsterType = new Random().Next(1, 4);
                        int monsterAttack = 0;
                        int monsterHP = 20;
                        string monsterName = "";
                        bool hasWon = false;
                        switch (monsterType)
                        {
                            case 1:
                                monsterName = "Spider";
                                monsterAttack = 4;
                                monsterHP = 11;
                                break;

                            case 2:
                                monsterName = "Bat";
                                monsterAttack = 6;
                                monsterHP = 24;
                                break;

                            case 3:
                                monsterName = "Wolf";
                                monsterAttack = 11;
                                monsterHP = 38;
                                break;

                        }

                        Console.WriteLine($"You've met a {monsterName}");
                        while (!hasWon && isAlive)
                        {
                            Console.WriteLine("What do you do?");
                            Console.WriteLine("1 - Fight");
                            Console.WriteLine("2 - Escape");
                            int choice = int.Parse(Console.ReadLine());
                            if (choice == 1) // Fight.
                            {
                                while (isAlive && !hasWon)
                                {
                                    monsterHP -= playerAttack;
                                    if (monsterHP <= 0)
                                    {
                                        Console.WriteLine("You won");
                                        playerXP += 1;
                                        if (playerXP > 100) // GainLevel()
                                        {
                                            playerLvl++;
                                            playerAttack += 10;
                                            playerXP -= 100;
                                        }

                                        hasWon = true;
                                        break;
                                    }

                                    playerHP -= monsterAttack;
                                    if (playerHP <= 0)
                                    {
                                        isAlive = false;
                                        break;
                                    }

                                    Console.WriteLine($"Player HP:{playerHP}");
                                    Console.WriteLine($"Monster HP:{monsterHP}");
                                }

                            }
                            else if (choice == 2)
                            {
                                int escapeChance = new Random().Next(1, 4);
                                if (escapeChance == 1)
                                {
                                    Console.WriteLine("You've ran away!");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("You were too slow");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Invalid input! Please use \"1\" or \"2\".");
                                break;
                            }

                        }
                        break;

                    case 7:
                        int chestCoins = new Random().Next(15, 100);
                        playerCoins += chestCoins;
                        Console.WriteLine($"You've found a chest with {chestCoins} coins.");
                        break;

                    case 8:
                        Console.WriteLine($"You've found a potion. Gained +{playerHP} HP.");
                        playerHP += 10;
                        break;

                    case 9:
                        Console.WriteLine("Welcome to the shop!");
                        Console.WriteLine("Buy something with coins or skip the shop with typing \"9\".");
                        Console.WriteLine("Type the number of your desired item: \"1\" - longsword / price 10 , \"2\" - shortsword / price 5,\"3\" - LVL UP / price 15,\"4\"- chest / price 20,\"5\" - shield / price 13,\"9\" - exit.");
                        int shopChoice = int.Parse(Console.ReadLine());
                        switch (shopChoice)
                        {
                            case 1:
                                Console.WriteLine("You've bought a longsword for 10 coins and you gained +15 attack.");
                                playerAttack += 15;
                                playerCoins -= 10;
                                break;
                            case 2:
                                Console.WriteLine("You've bought a shortsword for 5 coins and you gained +8 attack.");
                                playerAttack += 8;
                                playerCoins -= 5;
                                break;
                            case 3:
                                Console.WriteLine("You've bought a LVL UP for 15 coins and you gained +2 levels.");
                                playerLvl += 2;
                                playerCoins -= 15;
                                break;
                            case 4:
                                Console.WriteLine("You've bought a chest for 20 coins and you gained +30 coins.");
                                playerCoins -= 20;
                                playerCoins += 30;
                                break;
                            case 5:
                                Console.WriteLine("You've bought a shield for 13 coins and you gained +13 HP");
                                playerHP += 13;
                                playerCoins -= 13;
                                break;
                            case 9:
                                Console.WriteLine("You're exiting the shop! Thanks for visiting!");
                                continue;
                            default:
                                Console.WriteLine("Invalid input! Please try again!");
                                break;
                        }
                        // Shop
                        // Some items with coins
                        break;

                }

            }

            Console.WriteLine("Game over");
            Console.WriteLine($"Coins: {playerCoins}");
        }
    }
}