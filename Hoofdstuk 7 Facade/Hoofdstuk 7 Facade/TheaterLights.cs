using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_7_Facade
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Lights are turned on");
        }

        public void Dim(int x)
        {
            Console.WriteLine("Lights have been dimmed to " + x);
        }
    }
}
