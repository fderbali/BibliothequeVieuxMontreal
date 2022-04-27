using System;
using System.Collections.Generic;

namespace BibliothequeVieuxMontreal.Models
{
    public partial class Membre
    {
        public Membre()
        {
            Prets = new HashSet<Pret>();
        }

        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public int Age { get; set; }

        public virtual ICollection<Pret> Prets { get; set; }
    }
}
