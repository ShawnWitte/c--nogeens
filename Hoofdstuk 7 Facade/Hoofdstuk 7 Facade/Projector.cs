using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_7_Facade
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector has turned on");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector set to wide screen mode");
        }

        public void Off()
        {
            Console.WriteLine("Projector has turned off");
        }
    }
}
