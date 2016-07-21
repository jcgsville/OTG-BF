using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetterBet.Models
{
    public class UserModel
    {
        public string name { get; set; }
        public Guid cardToken { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public List<offerModel> offerList { get; set;}
    }
}