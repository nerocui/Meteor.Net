using System;
using System.Collections.Generic;
using System.Text;

namespace Meteor.Net.EventArgs
{
    public class DdpEventArgs
    {
        public dynamic Data { get; private set; }

        internal DdpEventArgs(dynamic data)
        {
            this.Data = data;
        }
    }
}
