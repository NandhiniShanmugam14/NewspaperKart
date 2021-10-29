using System;
using System.Collections.Generic;

#nullable disable

namespace AddDeliveryPartner.NewsModel
{
    public partial class Paymenttbl
    {
        public int PayId { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
        public DateTime ExpDate { get; set; }
        public int Cvc { get; set; }
    }
}
