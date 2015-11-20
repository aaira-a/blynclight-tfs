using System;
using System.Threading;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace blynclight_tfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute(args);
        }

        static void Execute(string[] args)
        {
            var oBlync = ActualControllerFactory.Create();

            while (true)
            {
                var numberOfDevices = oBlync.InitBlyncDevices();
                Console.WriteLine("\nNumber of Connected Blync Device(s): " + numberOfDevices);

                if (numberOfDevices > 0)
                {
                    var queryResults = TfsApplication.query(args[0], args[1]);
                    Console.WriteLine("Last query: " + DateTime.Now.ToString("HH:mm:ss tt"));
                    TfsApplication.print(queryResults, args[0], args[1]);

                    if (queryResults.Count > 0)
                    {                        
                        Console.WriteLine("Turning on light");
                        oBlync.TurnOnMagentaLight(0);
                    }

                    if (queryResults.Count == 0)
                    {
                        Console.WriteLine("Turning off light");
                        oBlync.ResetLight(0);
                    }

                }

                Thread.Sleep(60000);
            }
        }
    }
}
