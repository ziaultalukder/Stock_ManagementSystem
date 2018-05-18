using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockeManagement.Models.Models
{
    public class StockOut
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StockOutDate { get; set; }
        public List<StockOutDetails> StockOutDetailses { get; set; }
    }
}
