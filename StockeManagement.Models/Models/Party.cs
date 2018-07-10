using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.Contracts;

namespace StockeManagement.Models.Models
{
    public class Party:IEntityModel,IDeletable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public bool IsDeleted { get; set; }
        public bool Deleted()
        {
            IsDeleted = true;
            return IsDeleted;
        }

        public DateTime DeletedBy { get; set; }
    }
}
