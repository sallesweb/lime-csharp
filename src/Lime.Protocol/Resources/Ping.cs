﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lime.Protocol.Resources
{
    /// <summary>
    /// Allows the nodes to test 
    /// the network connectivity.
    /// </summary>
    [DataContract(Namespace = "http://limeprotocol.org/2014")]
    public class Ping : Document
    {
        public const string MIME_TYPE = "application/vnd.lime.ping+json";

        public Ping()
            : base(new MediaType(MIME_TYPE))
        {

        }
    }
}