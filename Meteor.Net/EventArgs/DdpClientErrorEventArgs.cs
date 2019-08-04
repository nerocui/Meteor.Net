using System;

namespace Meteor.Net.EventArgs
{
    public class DdpClientErrorEventArgs
    {
        public Exception Exception { get; private set; }
        internal DdpClientErrorEventArgs(Exception x)
        {
            this.Exception = x;
        }

    }
}
