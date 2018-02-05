using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Metronome.Classes
{
    public class MetronomeClass
    {

        public int BeatsPerMeasure { get; set; }

        public int NoteLength { get; set; }

        public int CurrentBeat { get; set; }

        public MetronomeClass()
        {
            this.CurrentBeat = 1;
        }
       


        public void MetronomeTick()
        {
            if (CurrentBeat != 1)
            {
                Console.Beep(440, 100);
                if (CurrentBeat + 1 <= BeatsPerMeasure)
                {
                    CurrentBeat += 1;
                }
                else
                {
                    CurrentBeat = 1;
                }
            }
            else
            {
                Console.Beep(880, 100);
                if (CurrentBeat + 1 <= BeatsPerMeasure)
                {
                    CurrentBeat += 1;
                }
                else
                {
                    CurrentBeat = 1;
                }
            }
        }


        //static void RunMetronome()
        //{
        //    int currentBeat = 1;



        //    while (currentBeat <= beatsPerMeasure)
        //    {
        //        if (currentBeat == 1)
        //        {
        //            Console.Beep(880, noteLength);
        //            Thread.Sleep(noteLength);
        //            currentBeat += 1;
        //        }
        //        else if (currentBeat != 1)
        //        {
        //            Console.Beep(440, noteLength);
        //            Thread.Sleep(noteLength);
        //            currentBeat += 1;
        //        }
        //    }
        //}
    }
}
