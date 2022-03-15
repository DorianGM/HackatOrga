using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hackatOrga.Models;
using System.Globalization;

namespace hackatOrga
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_CreerHackat_Click(object sender, EventArgs e)
        {
            var formatUS = new CultureInfo("en-US");
            pbaudoin_hackatonContext cnx = new pbaudoin_hackatonContext();
            Hackathon unHackat = new Hackathon();
            unHackat.DateDebut = DateTime.ParseExact(tbx_dateDebut.Text, "d", formatUS);
            unHackat.HeureDebut = TimeSpan.ParseExact(tbx_heureDebut.Text, "T", formatUS);
            unHackat.DateFin = DateTime.ParseExact(tbx_dateFin.Text, "d", formatUS);
            unHackat.HeureFin = TimeSpan.ParseExact(tbx_heureFin.Text, "T", formatUS);
            unHackat.Lieu = tbx_lieu.Text;
            unHackat.Rue = tbx_rue.Text;
            unHackat.Ville = tbx_ville.Text;
            unHackat.CodePostal = tbx_cp.Text;
            unHackat.Theme = tbx_theme.Text;
            unHackat.DateLimite = DateTime.ParseExact(tbx_dateLimite.Text, "d", formatUS);
            unHackat.NbPlaces = Convert.ToInt32(tbx_nbPlaces.Text);
            unHackat.Image = tbx_image.Text;


  
            cnx.Hackathons.Add(unHackat);
            cnx.SaveChanges();
            this.Close();
        }
    }
}
