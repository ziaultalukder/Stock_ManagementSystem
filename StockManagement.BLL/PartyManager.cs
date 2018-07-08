using StockeManagement.Models.Models;
using StockManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.BLL
{    
    public class PartyManager
    {
        PartyRepository _Repository = new PartyRepository();

        public bool Add(Party party)
        {
            if (string.IsNullOrEmpty(party.Name))
            {
                throw new Exception("Party name is not provided");
            }
            if (string.IsNullOrEmpty(party.ContactNo))
            {
                throw new Exception("Party Contact Number Is Not Provided");
            }
            return _Repository.Add(party);
        }
        
        public bool Update(Party party)
        {
            return _Repository.Update(party);
        }

        public bool Remove(Party party)
        {
            return _Repository.Remove(party);
        }

        public List<Party> GetAll (bool withDeleted = false)
        {
            return _Repository.GetAll(withDeleted);
        }

        public Party GetById(int id)
        {
            return _Repository.GetById(id);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
