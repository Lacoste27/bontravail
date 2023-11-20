using bontravailapi.Models;

namespace bontravailapi.Service.Utilisateurs {
    public interface IUtilisateurService {
         Task<List<Utilisateur>> GetAll();
    }
}