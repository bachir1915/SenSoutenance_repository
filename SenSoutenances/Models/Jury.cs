namespace SenSoutenance.Models
{
    public class Jury : Utilisateur
    {
        public string Grade { get; set; }
        [Required, MaxLength(100)]
    }
}
