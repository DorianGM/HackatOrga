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


namespace hackatOrga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbaudoin_hackatonContext cnx = new pbaudoin_hackatonContext();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btnSatellites_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {

            Form4 frm4 = new Form4();
            frm4.Show();
            

        }
    }
}
