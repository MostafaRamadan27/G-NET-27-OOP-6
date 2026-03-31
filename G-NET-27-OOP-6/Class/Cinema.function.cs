using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_6
{
    public partial class Cinema 
    {
        public void OpenCinema()
        {
            Console.WriteLine($"Opening {CinemaName}...");
            _projector.Start();
        }
        public void CloseCinema()
        {
            Console.WriteLine($"Closing {CinemaName}...");
            _projector.Stop();
        }

    }
}
