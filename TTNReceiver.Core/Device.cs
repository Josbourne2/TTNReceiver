using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TTNReceiver.Core
{
    internal class Device
    {
        public string Name { get; set; }
        public string EUI { get; set; }
        public DeviceType deviceType;

        [ForeignKey]
        public int DeviceTypeId;
    }
}