using System;
using System.Collections.Generic;
using System.Text;

namespace TTNReceiver.Core
{
    internal class DeviceType
    {
        public string Name { get; set; }
        public string DecodeFunction { get; set; }
        public List<Device> Devices;
    }
}