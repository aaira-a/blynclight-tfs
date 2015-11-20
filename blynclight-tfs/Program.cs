using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace blynclight_tfs
{
    class Program
    {
        static void Main(string[] args)
        {
            var oBlync = ActualControllerFactory.Create();

            while (true)
            {
                var numberOfDevices = oBlync.InitBlyncDevices();
                Console.WriteLine("\nNumber of Connected Blync Device(s): " + numberOfDevices);

                if (numberOfDevices > 0)
                {
                    var queryResults = TfsApplication.query(args[0]);
                    Console.WriteLine("Last query: " + DateTime.Now.ToString("HH:mm:ss tt"));

                    if (queryResults.Count > 0)
                    {
                        Console.WriteLine("Number of matching query result(s): " + queryResults.Count);
                        foreach (WorkItem item in queryResults)
                        {
                            Console.WriteLine(item.Uri);
                        }
                        Console.WriteLine("Turning on light");
                        oBlync.TurnOnMagentaLight(0);
                    }

                    if (queryResults.Count == 0)
                    {
                        Console.WriteLine("Number of matching query result(s): " + queryResults.Count);
                        Console.WriteLine("Turning off light");
                        oBlync.ResetLight(0);
                    }

                }

                Thread.Sleep(60000);
            }
        }
    }
}
