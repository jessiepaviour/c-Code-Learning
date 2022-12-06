using ProgrammingChallenges;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

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
//class program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Enter a number:");
//        int num1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter a number:");
//        int num2 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter a number:");
//        int num3 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter a number:");
//        int num4 = Convert.ToInt32(Console.ReadLine());

//        int result = Calc(num1, num2, num3, num4);
//        Console.WriteLine(result);

//        bool evenOrOdd = evod(result);
//        Console.WriteLine(evenOrOdd);

//        bool Over10 = large(result);
//        Console.WriteLine(Over10);
//    }

//    public static int Calc(int num1, int num2, int num3, int num4)
//    {
//            int result;
//        result = num1 + num2 + num3 + num4;

//        return result;
//    }
//    public static bool evod(int result)
//    {
//        bool evenOrOdd;
//        int evenodd = result % 2;
//        if (evenodd == 0)
//        {
//            evenOrOdd = true;
//            Console.WriteLine("Is number even:{0}", evenOrOdd);
//        }
//        else
//        {
//            evenOrOdd = false;
//            Console.WriteLine("Is number even:{0}", evenOrOdd);
//            result = result++;
//        }
//        return evenOrOdd;
//    }
//    public static bool large(int result)
//    {
//        bool Over10;
//        if (result > 10)
//        {
//            Over10 = true;
//            Console.WriteLine("Number is over 10:{0}",Over10);
//        }
//        else
//        {
//            Over10 = false;
//            Console.WriteLine("Number is over 10:{0}", Over10);
//        }
//        return Over10;
//    }
//}


//2.3
//class program
//{
//    static int invalid;
//    public static void Main()
//    {
//        var names = new List<string>() { "Biff", "Chip", "Kipper", "Hans", "Super" };

//        foreach (string name in names)
//            if (name.Length != 4)
//            {
//                Console.WriteLine("invalid");
//                invalid++;
//                names.Remove(name);
//            }
//            else
//            {
//                Console.WriteLine(name);
//            }
//    }
//}

//3.1
//public class program
//{
//    static void Main()
//    {
//        Game game = new Game();

//        game.Start();
//    }
//}

//5.1
//class program
//{
//    static void Main()
//    {
//        car car = new car();

//        car.Move();
//        car.StoreItemsInBoot();
//    }
//}

class game
{
    static void Main()
    {
        AstroShip astro = new AstroShip();


        AstroShip.distance();
        StellarShip.distance();
    }
}