using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class Participant
    {
        public Participant()
        {
            Inscriptions = new HashSet<Inscription>();
        }

        public int IdP { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaiss { get; set; }
        public string Rue { get; set; }
        public string Cp { get; set; }
        public string Ville { get; set; }
        public string Mail { get; set; }
        public string NumTel { get; set; }
        public string Portfolio { get; set; }
        public string Login { get; set; }
        public string MdpHash { get; set; }

        public virtual ICollection<Inscription> Inscriptions { get; set; }
    }
}
