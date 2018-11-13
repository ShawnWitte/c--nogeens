using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_7_Facade
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }

        public void SetDvd(string dvd)
        {
            Console.WriteLine("Dvd set to " + dvd);
        }

        public void SetVolume(int x)
        {
            Console.WriteLine("Volume set to " + x);
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Surroundsound turned on");
        }


    }
}
