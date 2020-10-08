using System;
using System.Collections.Generic;
using System.Text;

namespace TTNReceiver.Core
{
    public class RawData : ModelBase
    {
        public byte[] Data { get; set; }
        public int? DeviceId { get; set; }
        public DateTime Timestamp { get; set; }
        public Device Device { get; set; }
    }
}