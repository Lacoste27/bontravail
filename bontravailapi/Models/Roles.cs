using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bontravailapi.Models {
    public class Roles {
        public int Id {get;set;}
        public required string Role {get;set;}

        public List<Utilisateur> Utilisateurs {get;set;}
    }
}