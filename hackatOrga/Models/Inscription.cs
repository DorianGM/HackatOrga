using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class Inscription
    {
        public int IdI { get; set; }
        public int IdParticipant { get; set; }
        public int IdHackathon { get; set; }
        public DateTime DateInscription { get; set; }
        public string Texte { get; set; }

        public virtual Hackathon IdHackathonNavigation { get; set; }
        public virtual Participant IdParticipantNavigation { get; set; }
    }
}
