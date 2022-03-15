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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Drawing.Printing;

namespace hackatOrga
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbaudoin_hackatonContext cnx = new pbaudoin_hackatonContext();
            //iTextSharp.LGPLv2.Core
            //Création d'un document
            Document unDocument = new Document();
            PdfWriter.GetInstance(unDocument, new FileStream("C:\\Users\\dgrimaud\\Documents\\participants.pdf", FileMode.Create));
            unDocument.Open();

            //Paragraphe centré avec une police de 14 et du gras
            iTextSharp.text.Font myFont = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);
            Paragraph titre = new Paragraph("Liste des participants", myFont);
            titre.Alignment = Element.ALIGN_CENTER;
            titre.SpacingAfter = 12;
            unDocument.Add(titre);

            //Création d'un tableau
            PdfPTable tableau = new PdfPTable(9);
            tableau.AddCell("Nom");
            tableau.AddCell("Prénom");
            tableau.AddCell("Date de Naissance");
            tableau.AddCell("Rue");
            tableau.AddCell("Code postal");
            tableau.AddCell("Ville");
            tableau.AddCell("Mail");
            tableau.AddCell("Numéro de téléphone");
            tableau.AddCell("Portfolio");

            //Remplissage avec la liste des clients
            foreach (Participant c in cnx.Participants.ToList())
            {
                foreach (Inscription i in cnx.Inscriptions)
                    if (c.IdP == i.IdParticipant)
                {
                        if (i.IdHackathon == cbx_idH.SelectedIndex + 1)
                        {
                            {
                                tableau.AddCell(c.Nom);
                                tableau.AddCell(c.Prenom);
                                tableau.AddCell(c.DateNaiss.ToString());
                                tableau.AddCell(c.Rue);
                                tableau.AddCell(c.Cp);
                                tableau.AddCell(c.Ville);
                                tableau.AddCell(c.Mail);
                                tableau.AddCell(c.NumTel);
                                tableau.AddCell(c.Portfolio);
                            }
                        }

                     
                }
 
            }

            PdfPCell nesthousing = new PdfPCell(tableau);

            nesthousing.Padding = 0f;

            unDocument.Add(tableau);

            //Enregistrement du fichier
            unDocument.Close();
            MessageBox.Show("Votre fichier a bien été créé dans le répertoire de vos documents");

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pbaudoin_hackatonContext cnx = new pbaudoin_hackatonContext();
            cbx_idH.DataSource = cnx.Hackathons.OrderBy(ev => ev.IdH).ToList();
            cbx_idH.DisplayMember = "theme";
            cbx_idH.ValueMember = "IdH";
        }
    }
}
