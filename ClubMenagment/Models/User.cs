using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMenagment.Models
{
    internal class User
    {
        public int UserId { get; set; }
       
        public string Username { get; set; }
      
        public string Name { get; set; }
      
        public string Password_hash { get; set; }

        public string Role { get; set; }
    }
}
