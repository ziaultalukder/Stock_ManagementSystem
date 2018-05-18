using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockeManagement.Models.Models
{
    public class StockIn
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StocInDate { get; set; }
        public List<StockInDetails> StockInDetailses { get; set; }
    }
}
