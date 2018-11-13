using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_7_Facade
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn machine turned on");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn has been popped");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn machien turned off");
        }
    }
}
