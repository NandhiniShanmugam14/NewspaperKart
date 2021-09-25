using System;
using System.Collections.Generic;

#nullable disable

namespace VendorAPI.CTSModel
{
    public partial class Feedbacktbl
    {
        public int FeedId { get; set; }
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public int TitleId { get; set; }
        public string Issue { get; set; }

        public virtual Customertbl Cust { get; set; }
        public virtual Newspapertbl Title { get; set; }
    }
}
