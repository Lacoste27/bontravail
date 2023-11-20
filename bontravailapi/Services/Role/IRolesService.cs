using bontravailapi.Models;

namespace bontravailapi.Service.Role {
    public interface IRolesService {
        Task<List<Roles>> GetAll();
    }
}