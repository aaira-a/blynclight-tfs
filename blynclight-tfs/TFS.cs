﻿using System;
using System.Collections.ObjectModel;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace blynclight_tfs
{
    class TfsApplication
    {
        public static WorkItemCollection query(string tfsUri, string tfsCollection)
        {
            // Connect to the work item store
            TfsTeamProjectCollection tpc =
                new TfsTeamProjectCollection(
                    new Uri(tfsUri + "/" + tfsCollection));
                
            WorkItemStore workItemStore = (WorkItemStore)tpc.GetService(typeof(WorkItemStore));

            // Run a query.
            WorkItemCollection queryResults = workItemStore.Query(
               "Select [ID], [Title] " +
               "From WorkItems " +
               "Where [Work Item Type] = 'Support' " +
               "AND [State] = 'New' " +
               "AND [Area Path] = 'Nintex\\NW for O365' " +
               "Order By [ID] Asc");

            return queryResults;
        }
        
        public static void print(WorkItemCollection queryResults)
        {
            Console.WriteLine("Number of matching query result(s): " + queryResults.Count);
            foreach (WorkItem item in queryResults)
            {
                Console.WriteLine(item.Uri);
            }
        }
    }
}
