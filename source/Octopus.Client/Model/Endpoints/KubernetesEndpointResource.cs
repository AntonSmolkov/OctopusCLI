﻿using Octopus.Client.Extensibility.Attributes;

namespace Octopus.Client.Model.Endpoints
{
    public class KubernetesEndpointResource : AgentlessEndpointResource
    {
        public override CommunicationStyle CommunicationStyle => CommunicationStyle.Kubernetes;

        [Trim]
        [Writeable]
        public string AccountId { get; set; }

        [Trim]
        [Writeable]
        public string ClusterUrl { get; set; }
    }
}
