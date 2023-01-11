using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

//class program
//{
//static void Main()
//{
//    Console.WriteLine("Enter X coordinate:");
//    int x = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter Y coordinate:");
//    int y = Convert.ToInt32(Console.ReadLine());

//    if (x > 0 && y > 0)
//    {
//        Console.WriteLine("1st Quadrant");
//    }
//    else if (x > 0 && y < 0)
//    {
//        Console.WriteLine("2nd Quadrant");
//    }
//    else if (x < 0 && y > 0)
//    {
//        Console.WriteLine("3rd Quadrant");
//    }
//    else if (x < 0 && y < 0)
//    {
//        Console.WriteLine("4th Quadrant");
//    }
//    else
//    {
//        Console.WriteLine("Coordinates are on the axis");
//    }
//}

//static void Main()
//{
//    Console.Write("Spaces: ");
//    int spaces = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Stars: ");
//    int stars = Convert.ToInt32(Console.ReadLine());

//    string result = output(stars, spaces);
//}

//static string output(int stars, int spaces)
//{
//    string starOutput = stars * "_";
//    Console.WriteLine();

//    return starOutput;
//}

//static void Main()
//{
//    Console.Write("Base length:");
//    int baseLength = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Height length:");
//    int heightLength = Convert.ToInt32(Console.ReadLine());

//    int result = triangleArea(baseLength, heightLength);

//    Console.WriteLine(result);
//}

//static int triangleArea(int triangleHeight, int triangleBase)
//{
//    int triangleArea = (triangleHeight * triangleBase) / 2;
//    return triangleArea;
//}

//static void Main()
//{
//    Console.Write("Date:");
//    string date = Console.ReadLine();

//    DateTime dateInput = DateTime.Parse(date);

//    string result = USorUK(dateInput);
//}

//static string USorUK(DateTime date)
//{
//    string format;

//    format = "dd/mm/yyyy";
//    date = date.ToString(format);

//    if ()
//    {

//    }

//static void Main()
//{
//    Console.Write("Enter yes when ready to begin: ");
//    string ready = Console.ReadLine();

//    Stopwatch stopwatch = new Stopwatch();

//    if (ready == "yes")
//    {
//        stopwatch.Start();

//        for (int i = 0; i < 1000; i++)
//        {
//            Thread.Sleep(1);
//        }
//    }

//    int x = 0;

//    while (x < 5)
//    {
//        Random random = new Random();
//        int challenge = random.Next(1, 100);

//        Console.WriteLine(challenge + ":");
//        int input = Convert.ToInt32(Console.ReadLine());

//        if (input == challenge)
//        {
//            x = +1;
//        }
//    }

//    if (x == 5)
//    {
//         stopwatch.Stop();
//         Console.WriteLine("Time taken: {0}",stopwatch.Elapsed);
//    }
//}

//enum Days
//{
//    Monday,
//    Tuesday,
//    Wedenesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}
//enum Months
//{
//    January,
//    February,
//    March,
//    April,
//    May,
//    June,
//    July,
//    August,    
//    September,
//    October,
//    November,
//    December
//}
//enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}
//enum Levels
//{
//    Low,
//    Medium,
//    High
//}
//enum planets
//{
//    Mercury,
//    Venus,
//    Earth,
//    Mars,
//    Jupiter,
//    Saturn,
//    Neptune,
//    Uranus
//}

//static void Main()
//{
//    int day = (int)Days.Tuesday;
//    Console.WriteLine(day);

//    Months month = Months.November;
//    Console.WriteLine(month);

//    Season season = Season.Autumn;
//    Console.WriteLine(season);


//    Random random = new Random();
//    int level = random.Next(1, 3);

//    Levels myVar;

//    if (level == 1)
//    {
//        myVar = Levels.Low;
//    }
//    else if (level == 2)
//    {
//        myVar = Levels.Medium;
//    }
//    else
//    {
//        myVar = Levels.High;
//    }

//    switch (myVar)
//    {
//        case Levels.Low:
//            Console.WriteLine("Beginner level");
//            break;
//        case Levels.Medium:
//            Console.WriteLine("Normal level");
//            break;
//        case Levels.High:
//            Console.WriteLine("Master level");
//            break;
//    }

//    Console.WriteLine(Enum.GetName(typeof(Days),2));

//    Console.WriteLine("Months:");
//    foreach (string str in Enum.GetNames(typeof(Months)))
//        Console.WriteLine(str);

//    Console.WriteLine("Enum.TryParse():");
//    Months wdEnum;
//    Enum.TryParse<Months>("3", out wdEnum);
//    Console.WriteLine(wdEnum);
//}

//static void Main()
//{
//    Console.WriteLine("Date of birth - Date:");
//    string day = Console.ReadLine();

//    Console.WriteLine("Date of birth - Month:");
//    int month = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Date of birth - Year:");
//    int year = Convert.ToInt32(Console.ReadLine());

//    DateTime date = DateTime.Now;
//    date.ToString("yyyy");
//    date.ToString("MM");
//    date.ToString("d");
//}

//static void Main()
//{
//    Console.WriteLine("Number1:");
//    int num1 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Number2:");
//    int num2 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("+ - x /?");
//    string method = Console.ReadLine();


//    try
//    {

//        switch (method)
//        {
//            case "+":
//                int result1 = num1 + num2;
//                Console.WriteLine(result1);
//                break;
//            case "-":
//                int result2 = num1 - num2;
//                Console.WriteLine(result2);
//                break;
//            case "x":
//                int result3 = num1 * num2;
//                Console.WriteLine(result3);
//                break;
//            case "/":
//                int result4 = num1 / num2;
//                Console.WriteLine(result4);
//                break;
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("HelpLink = {0}", ex.HelpLink);
//        Console.WriteLine("Message = {0}", ex.Message);
//        Console.WriteLine("Source = {0}", ex.Source);
//        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
//        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
//    }
//}

//static void Main()
//{
//    StreamWriter writer;
//    writer = new StreamWriter("test.txt");

//    writer.WriteLine("kagari was here");
//    writer.Close();

//    StreamReader reader = new StreamReader("test.txt");
//    string read = reader.ReadLine();

//    Console.WriteLine(read);
//    reader.Close();


//    VCard vc = new VCard();

//    string path = @"D:Example.txt";

//    using (StreamWriter paths = File.AppendText(path))
//    {
//        paths.WriteLine("kagari was here");
//        paths.Close();
//        Console.WriteLine(File.ReadAllText(path));
//    }
//}

//static void Main()
//{
//    int x = 0;
//    int y = 1;
//    int z = 2;

//    while (z < 50)
//    {
//        y = x + y;
//        z++;
//        Console.WriteLine(y);

//        x = y + x;
//        z++;
//        Console.WriteLine(x);
//    }
//}

//    static void Main()
//    {
//        string[] pokemon = {"-","-","-","-","-","-"};

//        Console.WriteLine("Slot:");
//        int slot = Convert.ToInt32(Console.ReadLine());
//        slot =- 1;

//        Console.WriteLine("Pokemon:");
//        pokemon = 
//    }
//}

namespace pokemon
{
    class tinkaton
    {
        public void desc()
        {
            Console.WriteLine("Tinkaton aims to knock out Corviknight in the sky to by \n" +
                "knocking rosks with it's hammer. It is also known to steal anything it \n" +
                "sees.");
        }

        public void stats()
        {

        }
    }

    class cyclizar
    {
        public void desc()
        {
            Console.WriteLine("Cyclizar has been used as a ride Pokemon since ancient times. \n" +
                "It is known to sprint over 70 mph while carrying luggage. Cyclizar's spirit \n" +
                "is lifted when carrying humans.");
        }
    }
}

namespace program
{
    class program
    {
        static void Main()
        {
            pokemon.tinkaton tinkaton = new pokemon.tinkaton();
            pokemon.cyclizar cyclizar = new pokemon.cyclizar();

            tinkaton.desc();
            cyclizar.desc();
        }
    }
}