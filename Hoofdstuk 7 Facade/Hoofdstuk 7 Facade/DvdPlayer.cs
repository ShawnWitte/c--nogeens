using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_7_Facade
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("Dvdplayer is now on.");
        }

        public void Play(string movie)
        {
            Console.WriteLine("Now playing " + movie);
        }

        public void Stop()
        {
            Console.WriteLine("Dvd player has stopped");
        }

        public void Eject()
        {
            Console.WriteLine("Dvd ejected");
        }
         
        public void Off()
        {
            Console.WriteLine("Dvd player has turned off");
        }
    }
}
