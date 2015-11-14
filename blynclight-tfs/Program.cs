using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blynclight_tfs
{
    class Program
    {
        static void Main(string[] args)
        {
            var oBlync = new Blync();
            Console.WriteLine("\nNumber of Connected Blync Device(s): " + oBlync.getConnectedBlyncDevices());
        }
    }
}
