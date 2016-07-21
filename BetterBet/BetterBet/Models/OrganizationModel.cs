using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetterBet.Models
{
    public class Organization
    {
        public string Name { get; set; }

        public Guid Token { get; set; }
    }
}