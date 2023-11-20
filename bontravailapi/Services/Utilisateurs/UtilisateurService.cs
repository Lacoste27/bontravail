using bontravailapi.Models;
using Microsoft.EntityFrameworkCore;

namespace bontravailapi.Service.Utilisateurs {
    public class UtilisateurService : IUtilisateurService {
        private readonly BonTravailContext Context ;

        public UtilisateurService(BonTravailContext context) {
            this.Context = context;

        }

        public Task<List<Utilisateur>> GetAll() {
            return this.Context.Utilisateurs.Include(user => user.Role).ToListAsync();
        }
    }
}