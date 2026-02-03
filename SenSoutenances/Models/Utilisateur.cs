using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenSoutenance.Models
{
    public class Utilisateur
    {
        [Key]
        public int IdUtilisateur {  get; set; }

        [Required, MaxLength(80)]
        public string NomUtilisateur { get; set; }

        [Required, MaxLength(80)]
        public string PrenomUtilisateur { get; set; }

        [Required, MaxLength(15)]
        public string TelUtilisateur { get; set; }

        [Required, MaxLength(80), EmailAddress]
        public string EmailUtilisateur { get; set; }

        public virtual ICollection<Professeur> Professeurs { get; set; } = new HashSet<Professeur>();
        public virtual ICollection<Candidat> Candidats { get; set; } = new HashSet<Candidat>();
        public virtual ICollection<ChefDepartement> ChefDepartements { get; set; } = new HashSet<ChefDepartement>();
    }
}
