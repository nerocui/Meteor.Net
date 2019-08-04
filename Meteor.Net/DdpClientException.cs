using System;
using System.Collections.Generic;
using System.Text;

namespace Meteor.Net
{
    [Serializable]
    public class DdpClientException : ApplicationException
    {
        public DdpClientException(String message) : base(message) { }
    }
}
