using System;
using System.Collections.Generic;
using System.Text;

namespace TTNReceiver.Core
{
    public class DeviceType : ModelBase
    {
        public string Name { get; set; }
        public string JSDecoderFunction { get; set; }
        public IEnumerable<Device> Devices;
    }
}