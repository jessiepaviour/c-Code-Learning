using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

//class program
//{
    //0.2

    //static int enemyHealth = 100;
    //static int charge = 0;
    //static void Main()
    //{
    //    Random random = new Random();
    //    Console.WriteLine("Enemy health is {0}",enemyHealth);
    //    Console.WriteLine("1 - Basic\n2 - Ranged\n3 - Charged(5)\n4 - Multishot(3)\n5 - Rest\nCharge: {0}",charge);
    //    Console.WriteLine("What do you do?");
    //    int attack = Convert.ToInt32(Console.ReadLine());
    //    switch (attack)
    //    {
    //        case 1:
    //            enemyHealth -= 5;
    //            charge += 1;
    //            Console.WriteLine("\nEnemy hit\n");
    //            break;
    //        case 2:
    //            int range = random.Next(3, 8);
    //            enemyHealth -= range;
    //            charge += 1;
    //            Console.WriteLine("\nEnemy hit at range\n");
    //            break;
    //        case 3:
    //            enemyHealth -= 20;
    //            charge -= 5;
    //            Console.WriteLine("\nEnemy hit with great power\n");
    //            break;
    //        case 4:
    //            int hits = random.Next(3, 9);
    //            enemyHealth -= hits*2;
    //            charge -= 3;
    //            Console.WriteLine("\n{0} shots hit\n", hits);
    //            break;
    //        case 5:
    //            charge += 2;
    //            Console.WriteLine("\nStrength rested\n");
    //            break;
    //        default:
    //            Console.WriteLine("\nFailed action\n");
    //            break;
    //    }
    //    if (enemyHealth > 0) 
    //    {
    //        Main();
    //    }
    //}



    //1.2
    //static int result;

    //static int resolve(int result)
    //{
    //    int x;
    //    x = 0;
    //    do
    //    {
    //        Console.WriteLine("Enter number:");
    //        int number = Convert.ToInt32(Console.ReadLine());
    //        result = result + number;
    //        x = x + 1;
    //    }
    //    while (x < 4);

    //    Console.WriteLine(result);
    //    return result;
    //}

    //public static void Main()
    //{
    //    resolve(result);
    //    if (result % 2 == 0)
    //    {
    //        Console.WriteLine("Even");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Odd");
    //    }
    //}
//}

//3.1
class Game
{
    static void Start()
    {
        Console.WriteLine("Game Started")
    }
}

class program
{
    static void Main()
    {
        Game.Start();
    }
}