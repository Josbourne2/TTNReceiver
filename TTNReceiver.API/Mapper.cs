using System;
using System.Collections.Generic;
using System.Text;
using TTNReceiver.Core;

namespace TTNReceiver.API
{
    public static class Mapper
    {
        public static RawData Map(TTNHttpDTO rawMessage)
        {
            byte[] data = System.Convert.FromBase64String(rawMessage.payload_raw);

            return new RawData
            {
                Data = data,
                Timestamp = rawMessage.Metadata.time
            };
            //byte[] data = System.Convert.FromBase64String(dinges.payload_raw);
        }
    }
}