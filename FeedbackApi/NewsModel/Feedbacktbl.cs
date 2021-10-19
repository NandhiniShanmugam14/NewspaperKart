using System;
using System.Collections.Generic;

#nullable disable

namespace FeedbackApi.NewsModel
{
    public partial class Feedbacktbl
    {
        public int FeedId { get; set; }
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public string Issue { get; set; }
        public string Title { get; set; }

        public virtual Customertbl Cust { get; set; }
    }
}
