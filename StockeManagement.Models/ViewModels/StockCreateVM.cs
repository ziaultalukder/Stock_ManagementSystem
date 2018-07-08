using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockeManagement.Models.Models;

namespace StockeManagement.Models.ViewModels
{
    public class StockCreateVM
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime StocInDate { get; set; }

        [NotMapped]
        public List<Category> Categories { get; set; }
        public List<StockInDetails> StockInDetails { get; set; }


        [Display(Name ="Party")]
        public int? PartyId { get; set; }
        public List<Party> Parties { get; set; }
    }
}
