using System;
using System.Collections.ObjectModel;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace TfsApplication
{
    class Program
    {
        static void Main(String[] args)
        {
            // Connect to the work item store
            TfsTeamProjectCollection tpc =
                new TfsTeamProjectCollection(
                    new Uri(args[0]));
                
            WorkItemStore workItemStore = (WorkItemStore)tpc.GetService(typeof(WorkItemStore));

            // Run a query.
            WorkItemCollection queryResults = workItemStore.Query(
               "Select [ID], [Title] " +
               "From WorkItems " +
               "Where [Work Item Type] = 'Support' " +
               "AND [State] = 'New' " +
               "AND [Area Path] = 'Nintex\\NW for O365' " +
               "Order By [ID] Asc");

            Console.WriteLine(queryResults.Count);
        }
    }
}
namespace blynclight_tfs
{
    class TFS
    {
    }
}
