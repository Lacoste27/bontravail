using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bontravailapi.Classes.Eums;

namespace bontravailapi.Models {
    [Table("BonTravail")]
    public class BonTravail {
        public int Id { get; set; }
        public int Numero {get;set;}
        public required DateTime Date { get; set; } = DateTime.Now.Date;
        public required DateTime DateLimite {get; set;}
        public Priorite Priorite {get;set;} = Priorite.BASSE!;
        public Etat Etat {get;set;} = Etat.SAISIE!;
        public string? Zone {get;set;}
        public string? SousZone {get;set;}
        public required DateTime Created_at {get;set;} = DateTime.Now;
        public required DateTime Updated_at {get;set;} = DateTime.Now;


        public BonTravail() {

        }
    }
}