using System;
using System.Collections.Generic;
using System.Text;

namespace Meteor.Net.EventArgs
{
    public class DdpMethodUpdatedEventArgs
    {
        internal DdpMethodUpdatedEventArgs(String[] callIds)
        {
            this.CallIds = callIds;
        }

        public String[] CallIds { get; private set; }
    }
}
