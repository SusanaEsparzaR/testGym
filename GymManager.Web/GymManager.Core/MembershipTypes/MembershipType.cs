using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.MembershipTypes
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Cost { get; set; }

        public DateTime CreatedOn { get; set; }

        public int Duration { get; set; }
    }
}
