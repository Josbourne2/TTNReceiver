using System;
using System.Collections.Generic;
using System.Text;

namespace TTNReceiver.Core
{
    internal class Measurement
    {
        public Device Device;
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}