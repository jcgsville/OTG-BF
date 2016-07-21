using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetterBet.Models
{
    public class CommentModels
    {
    }

    public class Comment
    {
        public User user { get; set; } //I don't know what the user model looks like right now

        public string content { get; set; }

        public DateTime timestamp { get; set; }
    }
}