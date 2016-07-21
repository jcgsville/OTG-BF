using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetterBet.Models
{

    public class Comment
    {
        public UserModel user { get; set; }

        public string content { get; set; }

        public DateTime timestamp { get; set; }
    }
}