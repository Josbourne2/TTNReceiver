using System;
using System.Collections.Generic;
using System.Text;

namespace TTNReceiver.Core
{
    internal class Measurement
    {
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }
}