using StockeManagement.Models.Models;
using StockManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.BLL.Base;
using StockManagement.Repository.Base;

namespace StockManagement.BLL
{    
    public class PartyManager:Manager<Party>
    {
        private PartyRepository _partyRepository
        {
            get
            {
                PartyRepository partyRepository = (PartyRepository)_repository ;
                return partyRepository;
            }
        }
        public PartyManager() : base(new PartyRepository())
        {
        }
        public override bool Add(Party party)
        {
            if (string.IsNullOrEmpty(party.Name))
            {
                throw new Exception("Party name is not provided");
            }
            if (string.IsNullOrEmpty(party.ContactNo))
            {
                throw new Exception("Party Contact Number Is Not Provided");
            }
            return _partyRepository.Add(party);
        }

        public ICollection<Party> GetByName(string Name)
        {
            return _partyRepository.Get(c => c.Name.Contains(Name));
        } 

    }
}
