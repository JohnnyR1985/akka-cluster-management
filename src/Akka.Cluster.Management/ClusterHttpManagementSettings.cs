﻿using Akka.Configuration;

namespace Akka.Cluster.Http.Management
{
    public class ClusterHttpManagementSettings
    {
        public static readonly string ConfigPath = "akka.cluster.http.management";

        public int ClusterHttpManagementPort { get; }
        public string ClusterHttpManagementHostname { get; }

        public ClusterHttpManagementSettings(Config config)
        {
            ClusterHttpManagementPort = config.GetInt("port");
            ClusterHttpManagementHostname = config.GetString("hostname");
        }
    }
}
