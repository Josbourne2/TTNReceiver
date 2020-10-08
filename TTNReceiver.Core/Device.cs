using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TTNReceiver.Core
{
    internal class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EUI { get; set; }
        public DeviceType deviceType;

        public int DeviceTypeId;
    }
}