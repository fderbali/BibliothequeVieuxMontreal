using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BibliothequeVieuxMontreal.Models
{
    public partial class Pret
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Numéro du livre")]
        public int IdLivre { get; set; }
        [DisplayName("Numéro du membre")]
        [Required]
        public int IdMembre { get; set; }
        [Required]
        [DisplayName("Date de début")]
        public DateTime DateDebut { get; set; }
        [DisplayName("Date de Fin")]
        public DateTime DateFin { get; set; }

        public virtual Livre IdLivreNavigation { get; set; } = null!;
        public virtual Membre IdMembreNavigation { get; set; } = null!;
    }
}
//[DataType(DataType.Date)]