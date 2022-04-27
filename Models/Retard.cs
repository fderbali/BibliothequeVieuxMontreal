using System;
using System.Collections.Generic;

namespace BibliothequeVieuxMontreal.Models
{
    public partial class Retard
    {
        public int Id { get; set; }
        public int IdMembre { get; set; }
        public int IdLivre { get; set; }
        public int Nbjour { get; set; }
        public DateTime? DatePret { get; set; }
    }
}
