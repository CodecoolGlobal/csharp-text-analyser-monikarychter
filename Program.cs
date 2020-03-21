using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_text_analyser_monikarychter
{
    class Aplication
    {
        private const string Fpath = "tekst.txt";
        private static View view1;
        // Please use significant names of variables, non 1 character
        private static Iterator I;

        static void Main(string[] args)

        {
            // TODO
            // Please uncomment to create file instance
            
            //FileContent file = new FileContent("test.txt"); 
            
            // TODO
            // Please add both iterators instances creation here
            
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

           //StatisticAnaliysis stat = new StatisticAnaliysis(iterator: I,view1);
        } 
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) String");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("String:");
                    string String = Console.ReadLine();
                    StatisticAnaliysis stat = new StatisticAnaliysis(iterator: I,view1);
                    stat.CountOf("love");

                    return true;
                case "2":

                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }

        }


    }
}

