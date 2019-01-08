﻿using System;
using System.Collections.Generic;

namespace Tars.Net.Configurations
{
    public class RpcConfiguration
    {
        public int Port { get; set; } = 8989;

        public int QuietPeriodSeconds { get; set; } = 1;

        public TimeSpan QuietPeriodTimeSpan => TimeSpan.FromSeconds(QuietPeriodSeconds);

        public int ShutdownTimeoutSeconds { get; set; } = 3;

        public TimeSpan ShutdownTimeoutTimeSpan => TimeSpan.FromSeconds(ShutdownTimeoutSeconds);
        public int SoBacklog { get; set; } = 8192;
        public bool TcpNodelay { get; set; }
        public int MaxFrameLength { get; set; } = 5 * 1024 * 1024;

        public int LengthFieldLength { get; set; } = 4;

        public Dictionary<string, ClientConfiguration> ClientConfig { get; set; } = new Dictionary<string, ClientConfiguration>(StringComparer.OrdinalIgnoreCase);

        public List<ServiceConfiguration> ServiceConfig { get; set; } = new List<ServiceConfiguration>();

        public int EventLoopCount { get; set; } = Environment.ProcessorCount;

        public int UdpLocalPort { get; set; } = 8787;
    }
}