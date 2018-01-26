using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
            Console.WriteLine("What is your tempo? (bmp): ");
            string answer = Console.ReadLine();
            int tempo = Convert.ToInt32(answer);

            Console.WriteLine("What is your time signature? (2/4, 3/4, 4/4?): ");
            string timeSignature = Console.ReadLine();


            Console.WriteLine("Run The Metronome? (y/n): ");
            answer = Console.ReadLine();

            int noteMil = 60000 / tempo;

            int noteRest = noteMil / 2;



                if (answer == "y")
                {
                    if (timeSignature == "2/4")
                    {
                        while (true)
                        {
                            Console.Beep(880, noteRest);
                            Thread.Sleep(noteRest);
                            Console.Beep(440, noteRest);
                            Thread.Sleep(noteRest);

                        }
                    }
                    else if (timeSignature == "3/4")
                    {
                        while (true)
                        {
                            Console.Beep(880, noteRest);
                            Thread.Sleep(noteRest);
                            Console.Beep(440, noteRest);
                            Thread.Sleep(noteRest);
                            Console.Beep(440, noteRest);
                            Thread.Sleep(noteRest);
                        }
                    }
                    else if (timeSignature == "4/4")
                    {
                        while (true)
                        {
                            Console.Beep(880, noteRest);
                            Thread.Sleep(noteRest);
                            Console.Beep(440, noteRest);
                            Thread.Sleep(noteRest);
                            Console.Beep(440, noteRest);
                            Thread.Sleep(noteRest);
                            Console.Beep(440, noteRest);
                            Thread.Sleep(noteRest);
                        }
                    }
                }
            }
        }
    }
}
