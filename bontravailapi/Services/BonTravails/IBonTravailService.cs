using bontravailapi.Models;

namespace bontravailapi.Service.BonTravails {
    public interface IBonTravailService {
        Task<List<BonTravail>> GetAll();
        void Add(BonTravail _bonTravail);
    }
}