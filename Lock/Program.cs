using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;

namespace Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password:");
            Console.Write(">");
            bool switchpass = true;
            int password = 0;
            do
            {
                try
                {
                    password = Convert.ToInt32(Console.ReadLine());
                    switchpass = false;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR! Only nunbers!");
                    Console.WriteLine("Enter Password:");
                    Console.Write(">");
                }
            } while (switchpass);

            bool switchcrackpass = true;
            int crackresp = 0;
            Console.Clear();
            Console.WriteLine("Press any key...");
            Console.ReadLine();
            var sw = Stopwatch.StartNew();
            do
            {
                Console.Clear();
                Console.WriteLine("Crack the Password");
                Console.Write(">");
                try
                {
                    crackresp = Convert.ToInt32(Console.ReadLine());
                    switchcrackpass = false;
                }
                catch (Exception)
                {

                }

            } while (switchcrackpass);
            int switchresp = 0;
            bool switchcrack = true;
            bool switchcrackpass2 = true;
            do
            {
              if (crackresp == password)
                {
                    switchresp = 1;
                    switchcrack = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong try again!");
                    Console.WriteLine("Press Any Key...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Crack the Password");
                    Console.Write(">");
                    do { try { crackresp = Convert.ToInt32(Console.ReadLine()); switchcrackpass2 = false; } catch (Exception) { } } while (switchcrackpass2);
                }
            } while (switchcrack);
            Console.Clear();
            Console.WriteLine("The password was: {0}", password);
            Console.WriteLine("Time elapsed: {0}", sw.Elapsed);
            sw.Stop();
            bool switchend = true;
            do {
                try
                {
                    if(Console.ReadLine() == "exit")
                    {
                        switchend = false;
                    }
                }
                catch (Exception)
                {

                }
            } while (switchend);
       }
    }
}
