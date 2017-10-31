using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace InfobipClient.infobip.api.model.sms.mo.reports
{
    /// <summary>
    /// This is a generated class and is not intended for modification!
    /// </summary>
    public class GetReceivedMessagesExecuteContext
    {
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        public override bool Equals(object obj)
        {
            var thisClass = obj as GetReceivedMessagesExecuteContext;
            return thisClass != null &&
                EqualityComparer<int?>.Default.Equals(Limit, thisClass.Limit);
        }

        public override int GetHashCode()
        {
            var hashCode = -1559463931;
            hashCode = hashCode * -1521134295 +  EqualityComparer<int?>.Default.GetHashCode(Limit);
            return hashCode;
        }
    }
}