using System.ComponentModel.DataAnnotations;

namespace CommeChezSwaMylanCoudeville.Models
{
    public class RegistratieReservatieModel
    {
        [MaxLength(100)]
        [Required(ErrorMessage = "Uw voornaam moet ingevuld zijn.")]
        public string Voornaam { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Uw achternaam moet ingevuld zijn.")]
        public string Achternaam { get; set; }

        [EmailAddress(ErrorMessage = "Dit is geen geldig email-adres!")]
        [Required(ErrorMessage = "Uw email moet ingevuld zijn.")]
        public string Email { get; set; }

        [Display(Name = "Bevesting email")]
        [Compare("Email")]
        [Required(ErrorMessage = "Uw bevestigings email moet ingevuld zijn.")]
        public string BevestigEmail { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Uw datum moet ingevuld zijn.")]
        public DateTime? Datum { get; set; }

        [Required(ErrorMessage = "U moet een tijdsstip selecteren.")]
        public Tijdstip? Tijd { get; set; }

        [Range(1,10, ErrorMessage = "Het aantal moet tussen 1 en 10 liggen.")]
        [Display(Name = "Aantal mensen")]
        [Required(ErrorMessage = "Het aantal mensen mag niet leeg zijn.")]
        public int? AantalMensen { get; set; }

        [ExpectedValue(true, ErrorMessage = "U kunt geen reservatie aanmaken als u niet akkoord met de algemene voorwaarden.")]
        public bool Akkoord { get; set; }
    }
    public enum Tijdstip { Ochtend, Middag, Avond }
}
