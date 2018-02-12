using Metronome.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Metronome
{
    class Program
    {

        static MetronomeClass metronome = new MetronomeClass();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What is your tempo? (bpm): ");
                string answer = Console.ReadLine();
                int tempo = Convert.ToInt32(answer);

                Console.WriteLine("What is your time signature? (?/4, ?/8, etc?): ");
                answer = Console.ReadLine();
                int beatsPerMeasure = Convert.ToInt32(answer);
                metronome.BeatsPerMeasure = beatsPerMeasure;


                Console.WriteLine("Run The Metronome? (y/n): ");
                answer = Console.ReadLine();

                if (answer == "y")
                {


                    int noteMil = 60000 / tempo;
                    

                    int noteRest = noteMil / 2;
                    metronome.NoteLength = noteRest;


                    Timer tick = new Timer(noteMil);

                    tick.Elapsed += EventHandler;

                    tick.AutoReset = true;
                    tick.Enabled = true;

                    Console.WriteLine("Press Any Key to Quit");

                    answer = Console.ReadKey().ToString();
                    Console.Clear();
                    if (answer != "")
                    {
                        tick.Dispose();
                    }
                }


            }


        }
        
        static void EventHandler(Object source, ElapsedEventArgs e)
        {
            metronome.MetronomeTick();
        }

        //static void RunMetronome(int beatsPerMeasure, int noteRest, int currentBeat)
        //{

        //    Console.Beep(440, noteRest);

            
            
            //while (currentBeat <= beatsPerMeasure)
            //if (currentBeat == 1)
            //{
            //    Console.Beep(880, noteRest);
            //    currentBeat += 1;

            //}
            //else if (currentBeat != 1)
            //{
            //    Console.Beep(440, noteRest);
            //    currentBeat += 1;

            //}

        //}

    }
}
