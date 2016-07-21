using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetterBet.Models
{
    public class OfferModel
    {
        public UserModel user { get; set; }
        public UInt32 amount { get; set; }
        public Organization charity { get; set; }
        public String condition { get; set; }
    }
}