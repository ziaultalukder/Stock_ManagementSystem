using StockeManagement.Models.DatabaseContext;
using StockeManagement.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Repository.Base;

namespace StockManagement.Repository
{
    public class PartyRepository:Repository<Party>
    {
        //public override ICollection<Party> GetAll(bool withDeleted = false)
        //{
        //    return db.Parties.Where(c => c.IsDeleted == false || c.IsDeleted == withDeleted).ToList();
        //}
    }
}
