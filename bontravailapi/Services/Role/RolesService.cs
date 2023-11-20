using bontravailapi.Models;
using Microsoft.EntityFrameworkCore;

namespace bontravailapi.Service.Role {
    public class RolesService : IRolesService {
        private readonly BonTravailContext Context;

        public RolesService(BonTravailContext Context) {
            this.Context = Context;
        }

        public Task<List<Roles>> GetAll() {
            return this.Context.Roles.Include(role => role.Utilisateurs).ToListAsync();
        }
    }
}