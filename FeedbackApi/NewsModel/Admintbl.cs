using System;
using System.Collections.Generic;

#nullable disable

namespace FeedbackApi.NewsModel
{
    public partial class Admintbl
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
