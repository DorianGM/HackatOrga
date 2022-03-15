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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        } 
        private void tbx_nbP_TextChanged(object sender, EventArgs e)
        {
          
        }
 
            private void btn_creer_Click(object sender, EventArgs e)
            {


                var formatUS = new CultureInfo("en-US");
                pbaudoin_hackatonContext cnx = new pbaudoin_hackatonContext();
                Evenement unEvent = new Evenement();
                unEvent.LibelleE = tbx_libelle.Text;
                unEvent.DateE = DateTime.ParseExact(tbx_date.Text, "d", formatUS);
                unEvent.HeureE = TimeSpan.ParseExact(tbx_heure.Text, "T", formatUS);
                unEvent.DureeE = TimeSpan.ParseExact(tbx_duree.Text, "T", formatUS);
                unEvent.SalleE = tbx_salle.Text;
                unEvent.IdHackat = Convert.ToInt32(cbx_idH.Text);
                unEvent.Type = lbx_type.SelectedItem.ToString();
                unEvent.nbParticipants = Convert.ToInt32(tbx_nbParticipants.Text);
                unEvent.themeE = tbx_themeE.Text;
                unEvent.intervenant = tbx_intervenant.Text;
                cnx.Evenements.Add(unEvent);
                cnx.SaveChanges();
                this.Close();


            }

            private void lbx_type_SelectedIndexChanged(object sender, EventArgs e)
            {
                btn_creer.Enabled = false;
                if (lbx_type.SelectedIndex == 0)
                {
                    tbx_intervenant.Enabled = false;
                    tbx_themeE.Enabled = false;
                    tbx_intervenant.Text = "";
                    tbx_themeE.Text = "";
                    tbx_nbParticipants.Enabled = true;
                }
                if (lbx_type.SelectedIndex == 1)
                {
                    tbx_nbParticipants.Enabled = false;
                    tbx_nbParticipants.Text = "";
                    tbx_intervenant.Enabled = true;
                    tbx_themeE.Enabled = true;

                }

                if (tbx_libelle.Text != "" && tbx_date.Text != "" && tbx_heure.Text != "" && tbx_duree.Text != "" && tbx_salle.Text != "" && cbx_idH.Text != "")
                {
                    if (tbx_nbParticipants.Enabled == true && tbx_nbParticipants.Text != "")
                    {
                        btn_creer.Enabled = true;
                    }
                    else if (tbx_themeE.Enabled == true && tbx_intervenant.Enabled == true && tbx_intervenant.Text != "" && tbx_themeE.Text != "")
                    {
                        btn_creer.Enabled = true;
                    }
                }


            }

            private void tbx_libelle_TextChanged(object sender, EventArgs e)
            {
                this.tbx_libelle.TextChanged += new System.EventHandler(this.lbx_type_SelectedIndexChanged);

            }

            private void tbx_date_TextChanged(object sender, EventArgs e)
            {
                this.tbx_date.TextChanged += new System.EventHandler(this.lbx_type_SelectedIndexChanged);
            }

            private void tbx_heure_TextChanged(object sender, EventArgs e)
            {
                this.tbx_heure.TextChanged += new System.EventHandler(this.lbx_type_SelectedIndexChanged);
            }

            private void tbx_duree_TextChanged(object sender, EventArgs e)
            {
                this.tbx_duree.TextChanged += new System.EventHandler(this.lbx_type_SelectedIndexChanged);
            }

            private void tbx_salle_TextChanged(object sender, EventArgs e)
            {
                this.tbx_salle.TextChanged += new System.EventHandler(this.lbx_type_SelectedIndexChanged);
            }


            private void tbx_themeE_TextChanged(object sender, EventArgs e)
            {
                this.tbx_themeE.TextChanged += new System.EventHandler(this.lbx_type_SelectedIndexChanged);
            }

            private void tbx_intervenant_TextChanged(object sender, EventArgs e)
            {
                this.tbx_intervenant.TextChanged += new System.EventHandler(this.lbx_type_SelectedIndexChanged);
            }

            private void Form2_Load(object sender, EventArgs e)
            {
                pbaudoin_hackatonContext cnx = new pbaudoin_hackatonContext();
                cbx_idH.DataSource = cnx.Hackathons.OrderBy(ev => ev.IdH).ToList();
                cbx_idH.DisplayMember = "theme";
                cbx_idH.ValueMember = "IdH";

            }

            private void tbx_nbParticipants_TextChanged(object sender, EventArgs e)
            {
                this.tbx_nbParticipants.TextChanged += new System.EventHandler(this.lbx_type_SelectedIndexChanged);
            }

        private void cbx_idH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_idH_Click(object sender, EventArgs e)
        {

        }
    }
    }
