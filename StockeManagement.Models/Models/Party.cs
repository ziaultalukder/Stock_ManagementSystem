using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockeManagement.Models.Models
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedBy { get; set; }
    }
}
