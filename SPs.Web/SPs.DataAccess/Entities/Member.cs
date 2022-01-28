using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPs.DataAccess.Entities
{
    public class Member
    {
        public int IdMembers { get; set; }

        public DateTime RegisterDate { get; set; }

        public string Type { get; set; }
    }
}
