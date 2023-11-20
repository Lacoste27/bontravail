namespace bontravailapi.Models {
    public class Utilisateur {
        public int Id {get;set;}
        public required string Nom {get;set;}
        public required string Prenom {get;set;}
        public required string Email {get;set;}
        public required string Service {get;set;}
        public required string Poste {get;set;}
        public required string Matricule {get;set;}
        public bool Etat {get;set;} = true;


        public required int Role_id {get;set;}
        public required Roles Role {get;set;}

        public Utilisateur(){

        }

        public Utilisateur(string Nom,string Prenom, string Email, string Service, string Poste, string Matricule ){
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Email = Email;
            this.Service = Service;
            this.Poste = Poste;
            this.Matricule = Matricule;
        }
    }
}