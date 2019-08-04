using System;
using System.Collections.Generic;
using System.Text;

namespace Meteor.Net.EventArgs
{
    public class DdpMeteorErrorEventArgs
    {
        internal DdpMeteorErrorEventArgs(String reason, dynamic originalMessage)
        {
            this.OriginalMessage = originalMessage;
            this.Reason = reason;
        }

        public dynamic OriginalMessage { get; private set; }
        public String Reason { get; private set; }
    }
}
