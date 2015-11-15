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
            var numberOfDevices = oBlync.getConnectedBlyncDevices();
            Console.WriteLine("\nNumber of Connected Blync Device(s): " + numberOfDevices);

            if (numberOfDevices > 0)
            {
                var result = TfsApplication.query(args[0]);

                if (result > 0)
                {
                    oBlync.TurnOnMagentaLight(0);
                }

                if (result == 0)
                {
                    oBlync.ResetLight(0);
                }

            }
        }
        
    }
}
