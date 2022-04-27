using System;
using System.Collections.Generic;

namespace BibliothequeVieuxMontreal.Models
{
    public partial class Livre
    {
        public Livre()
        {
            Prets = new HashSet<Pret>();
        }

        public int Id { get; set; }
        public string Titre { get; set; } = null!;
        public string Auteur { get; set; } = null!;
        public int Pages { get; set; }
        public string Cetegorie { get; set; } = null!;

        public virtual ICollection<Pret> Prets { get; set; }
    }
}
