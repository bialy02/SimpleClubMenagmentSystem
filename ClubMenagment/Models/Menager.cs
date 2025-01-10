using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMenagment.Models
{
    public class Menager
    {
        public int CoachId { get; set; }
       public string FirstName { get; set; }
        public string LastName { get; set; }
        Countries country { get; set; }

        public string PhotoUrl { get; set; }
    }
}
