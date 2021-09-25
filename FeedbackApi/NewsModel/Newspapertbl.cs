using System;
using System.Collections.Generic;

#nullable disable

namespace FeedbackApi.NewsModel
{
    public partial class Newspapertbl
    {
        public Newspapertbl()
        {
            AddDeliverytbls = new HashSet<AddDeliverytbl>();
            Feedbacktbls = new HashSet<Feedbacktbl>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Price { get; set; }

        public virtual ICollection<AddDeliverytbl> AddDeliverytbls { get; set; }
        public virtual ICollection<Feedbacktbl> Feedbacktbls { get; set; }
    }
}
