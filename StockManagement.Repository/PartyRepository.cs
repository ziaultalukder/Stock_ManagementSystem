using StockeManagement.Models.DatabaseContext;
using StockeManagement.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Repository
{
    public class PartyRepository
    {
        StockDBContext db = new StockDBContext();
        public bool Add(Party party)
        {
            db.Parties.Add(party);
            return db.SaveChanges() > 0;
        }

        public bool Update(Party party)
        {
            db.Parties.Attach(party);
            db.Entry(party).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public bool Remove(Party party)
        {
            party.IsDeleted = true;
            party.DeletedBy = DateTime.Now;
            return Update(party);            
        }
        public Party GetById(int id)
        {
            return db.Parties.FirstOrDefault(c => c.Id == id);
        }

        public List<Party> GetAll(bool withDeleted = false)
        {
            return db.Parties.Where(c => c.IsDeleted == withDeleted).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
