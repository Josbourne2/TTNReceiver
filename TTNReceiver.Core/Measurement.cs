using System;
using System.Collections.Generic;
using System.Text;

namespace TTNReceiver.Core
{
    internal class Measurement
    {
        public Device Device;
        public string Name { get; set; } //Kunnen we platter maken door measurement type te maken maar nu ff niet
        public double Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}