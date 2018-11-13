using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_7_Facade
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Screen has gone up");
        }

        public void Down()
        {
            Console.WriteLine("Screen has gone down");
        }
    }
}
