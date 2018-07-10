using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Models.Contracts;

namespace StockeManagement.Models.Models
{
    public class Employee:IEntityModel,IDeletable
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Designation { get; set; }
        public bool IsDeleted { get; set; }
        public bool Deleted()
        {
            IsDeleted = true;
            return true;
        }
    }
}
