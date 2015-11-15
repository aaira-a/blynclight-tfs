using System;
using System.Collections.ObjectModel;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace blynclight_tfs
{
    class TfsApplication
    {
        public static int query(string uri)
        {
            // Connect to the work item store
            TfsTeamProjectCollection tpc =
                new TfsTeamProjectCollection(
                    new Uri(uri));
                
            WorkItemStore workItemStore = (WorkItemStore)tpc.GetService(typeof(WorkItemStore));

            // Run a query.
            WorkItemCollection queryResults = workItemStore.Query(
               "Select [ID], [Title] " +
               "From WorkItems " +
               "Where [Work Item Type] = 'Support' " +
               "AND [State] = 'New' " +
               "AND [Area Path] = 'Nintex\\NW for O365' " +
               "Order By [ID] Asc");

            return queryResults.Count;
        }
    }
}
