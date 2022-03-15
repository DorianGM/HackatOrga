using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class Evenement
    {
        public int IdEvent { get; set; }
        public string LibelleE { get; set; }
        public DateTime DateE { get; set; }
        public TimeSpan HeureE { get; set; }
        public TimeSpan DureeE { get; set; }
        public string SalleE { get; set; }
        public int IdHackat { get; set; }
        public string Type { get; set; }
        
        public int nbParticipants { get; set; }
        public string themeE { get; set; }

        public string intervenant { get; set; }

        public virtual Hackathon IdHackatNavigation { get; set; }
    }
}
