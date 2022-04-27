using System;
using System.Collections.Generic;

namespace BibliothequeVieuxMontreal.Models
{
    public partial class Pret
    {
        public int Id { get; set; }
        public int IdLivre { get; set; }
        public int IdMembre { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public virtual Livre IdLivreNavigation { get; set; } = null!;
        public virtual Membre IdMembreNavigation { get; set; } = null!;
    }
}
