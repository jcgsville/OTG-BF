using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetterBet.Models
{
    public class BetModel
    {
        public Guid betId { get; set; }
        public string challenge { get; set; }
        public List<offerModel> offerList { get; set; }
        public List<Comment> commentList { get; set; }
    }
}