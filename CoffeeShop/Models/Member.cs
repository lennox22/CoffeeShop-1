using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Member
    {
        
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirm { get; set; }
        public string birthdate { get; set; }
        public string interest { get; set; }
        public bool subscribe { get; set; }
        public static List<Member> AllUsers = new List<Member>();
    }
}
