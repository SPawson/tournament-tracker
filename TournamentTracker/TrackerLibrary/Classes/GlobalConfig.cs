using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Interfaces;

namespace TrackerLibrary.Classes
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Setup the sql connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create textfile Connector properly
                TextConnector textConnection = new TextConnector();
                Connections.Add(textConnection);
            }
        }
    }
}
