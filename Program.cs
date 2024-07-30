namespace Cronometro;

class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        System.Console.WriteLine("1. Start Cronometro");
        System.Console.WriteLine("2. Exit Cronometro");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {   
            case 1: SecondAndMinute(); break;
            case 2: Environment.Exit(0); break;
            default: System.Console.WriteLine("Invalid option"); Thread.Sleep(2000); Menu(); break;
        }
    }

    static void SecondAndMinute()
    {
        Console.Clear();
        System.Console.WriteLine("1. Second");
        System.Console.WriteLine("2. Minute");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1: Second(); break;
            case 2: Minute(); break;
            default: System.Console.WriteLine("Invalid option"); Menu(); break;
        }
    }
    static void Minute()
    {
        System.Console.WriteLine("Starting Cronometro");
        System.Console.WriteLine("Enter minute for stopwatch:");
        int time = int.Parse(Console.ReadLine());
        if(time == 0) 
            System.Environment.Exit(0);
        int currentTimeInMinutes = 0;
        int secondsPerMinute = 60;

        while (currentTimeInMinutes < time)
        {
            for (int currentSecond = 0; currentSecond < secondsPerMinute; currentSecond++)
            {
                Console.Clear();
                System.Console.WriteLine($"{currentTimeInMinutes}:{currentSecond:D2}");
                Thread.Sleep(1000); 
            }
            currentTimeInMinutes++;
        }  
        Thread.Sleep(2500);
        Console.Clear();
        System.Console.WriteLine("Count finished");
        Thread.Sleep(2500);
        Menu();
    }

    static void Second()
    {
        Console.Clear();
        System.Console.WriteLine("Enter second for stopwatch:");
        int time = int.Parse(Console.ReadLine());
        if (time == 0)
            System.Environment.Exit(0);
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            System.Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
        Console.Clear();
        System.Console.WriteLine("Count finished");
        Thread.Sleep(2500);
    }
}