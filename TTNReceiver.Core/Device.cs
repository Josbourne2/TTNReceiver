using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TTNReceiver.Core
{
    public class Device : ModelBase
    {
        public string Name { get; set; }
        public string DeviceKey { get; set; }
        public DeviceType DeviceType { get; set; }
        public int? DeviceTypeId { get; set; }
        public IEnumerable<RawData> RawData { get; set; }
        public IEnumerable<Measurement> Measurements { get; set; }
    }
}