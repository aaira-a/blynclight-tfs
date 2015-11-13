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
            Console.WriteLine("\nNumber of Connected Blync Device(s): " + Blync.getConnectedBlyncDevices());
        }
    }
}
