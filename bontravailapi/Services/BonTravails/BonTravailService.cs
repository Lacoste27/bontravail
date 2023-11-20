using bontravailapi.Models;
using Microsoft.EntityFrameworkCore;

namespace bontravailapi.Service.BonTravails {
    public class BonTravailService : IBonTravailService {
        private  BonTravailContext Context {get;set;} = null!;

        public BonTravailService(BonTravailContext Context) {
            this.Context = Context;
        }

        public Task<List<BonTravail>> GetAll() {
            throw new NotImplementedException();
        }

        public void Add(BonTravail _bonTravail) {
            throw new NotImplementedException();
        }
    }
}