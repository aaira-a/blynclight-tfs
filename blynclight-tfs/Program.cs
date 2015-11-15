using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace blynclight_tfs
{
    class Program
    {
        static void Main(string[] args)
        {
            var oBlync = new Blync();

            while (true)
            {
                var numberOfDevices = oBlync.getConnectedBlyncDevices();
                Console.WriteLine("\nNumber of Connected Blync Device(s): " + numberOfDevices);

                if (numberOfDevices > 0)
                {
                    var result = TfsApplication.query(args[0]);

                    if (result > 0)
                    {
                        Console.WriteLine("Number of matching query result(s): " + result);
                        Console.WriteLine("Turning on light");
                        oBlync.TurnOnMagentaLight(0);
                    }

                    if (result == 0)
                    {
                        Console.WriteLine("Number of matching query result(s): " + result);
                        Console.WriteLine("Turning off light");
                        oBlync.ResetLight(0);
                    }

                }

                Thread.Sleep(60000);
            }
        }
    }
}
