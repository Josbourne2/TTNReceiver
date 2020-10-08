using System;
using System.Collections.Generic;
using System.Text;

namespace TTNReceiver.Core
{
    public class DeviceType : ModelBase
    {
        public string Name { get; set; }
        public string JSDecodeFunction { get; set; }
        public IEnumerable<Device> Devices;
    }
}