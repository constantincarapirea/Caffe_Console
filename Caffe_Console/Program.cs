using System;

namespace Caffe_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MainMenu();
        }
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello my dear guest\n");
            Console.WriteLine("1-->Show all Food");
            Console.WriteLine("0-->Exit");
            string options;
            options = Console.ReadLine();

            switch (options)
            {
                case "1":
                    Implement();
                    break;
                case "0":
                    Exit();
                    break;
            }
            MainMenu();
        }
        static void Implement()
        {
            Repository repository = new Repository(5);
            repository.Print($"{"This is Food",20}\n");
            Console.ReadKey();

        }

        static void Exit()
        {
            Console.WriteLine("Are you sure you would like to exit the program?");
            Console.WriteLine("Pless the enter Y/N");
            string key = Console.ReadLine();
            if (key == "Y"|| key=="y") System.Environment.Exit(1);
            else if (key=="N" || key=="n")MainMenu();
        }
    }
}
