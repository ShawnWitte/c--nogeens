using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_7_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            DvdPlayer dvd = new DvdPlayer();
            PopcornPopper pop = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            HomeTheaterFacade theater = new HomeTheaterFacade(amp, dvd, projector, screen, lights, pop);

            theater.WatchMovie("Frozen");
            theater.EndMovie();

            Console.ReadLine();
        }
    }
}
