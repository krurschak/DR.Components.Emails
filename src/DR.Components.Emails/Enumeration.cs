using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Emails
{
    public class Enumeration
    {
        public enum EmailStatus
        {
            Pending = 1,
            Scheduled = 2,
            Sent = 3,
            Failed = 4
        }
    }
}
