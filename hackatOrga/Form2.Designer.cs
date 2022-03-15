
namespace hackatOrga
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_libelle = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_heure = new System.Windows.Forms.Label();
            this.lbl_duree = new System.Windows.Forms.Label();
            this.lbl_salle = new System.Windows.Forms.Label();
            this.lbl_idH = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.tbx_libelle = new System.Windows.Forms.TextBox();
            this.tbx_salle = new System.Windows.Forms.TextBox();
            this.btn_creer = new System.Windows.Forms.Button();
            this.lbx_type = new System.Windows.Forms.ListBox();
            this.lbl_nbParticipants = new System.Windows.Forms.Label();
            this.lbl_themeE = new System.Windows.Forms.Label();
            this.lbl_intervenant = new System.Windows.Forms.Label();
            this.tbx_themeE = new System.Windows.Forms.TextBox();
            this.tbx_intervenant = new System.Windows.Forms.TextBox();
            this.tbx_date = new System.Windows.Forms.MaskedTextBox();
            this.tbx_heure = new System.Windows.Forms.MaskedTextBox();
            this.tbx_duree = new System.Windows.Forms.MaskedTextBox();
            this.cbx_idH = new System.Windows.Forms.ComboBox();
            this.tbx_nbParticipants = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_libelle
            // 
            this.lbl_libelle.AutoSize = true;
            this.lbl_libelle.Location = new System.Drawing.Point(112, 84);
            this.lbl_libelle.Name = "lbl_libelle";
            this.lbl_libelle.Size = new System.Drawing.Size(41, 15);
            this.lbl_libelle.TabIndex = 0;
            this.lbl_libelle.Text = "Libelle";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(112, 135);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(111, 15);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date(MM/JJ/AAAA)";
            // 
            // lbl_heure
            // 
            this.lbl_heure.AutoSize = true;
            this.lbl_heure.Location = new System.Drawing.Point(112, 184);
            this.lbl_heure.Name = "lbl_heure";
            this.lbl_heure.Size = new System.Drawing.Size(39, 15);
            this.lbl_heure.TabIndex = 2;
            this.lbl_heure.Text = "Heure";
            // 
            // lbl_duree
            // 
            this.lbl_duree.AutoSize = true;
            this.lbl_duree.Location = new System.Drawing.Point(112, 237);
            this.lbl_duree.Name = "lbl_duree";
            this.lbl_duree.Size = new System.Drawing.Size(38, 15);
            this.lbl_duree.TabIndex = 3;
            this.lbl_duree.Text = "Duree";
            // 
            // lbl_salle
            // 
            this.lbl_salle.AutoSize = true;
            this.lbl_salle.Location = new System.Drawing.Point(112, 280);
            this.lbl_salle.Name = "lbl_salle";
            this.lbl_salle.Size = new System.Drawing.Size(31, 15);
            this.lbl_salle.TabIndex = 4;
            this.lbl_salle.Text = "Salle";
            // 
            // lbl_idH
            // 
            this.lbl_idH.AutoSize = true;
            this.lbl_idH.Location = new System.Drawing.Point(112, 323);
            this.lbl_idH.Name = "lbl_idH";
            this.lbl_idH.Size = new System.Drawing.Size(65, 15);
            this.lbl_idH.TabIndex = 5;
            this.lbl_idH.Text = "Hackathon";
            this.lbl_idH.Click += new System.EventHandler(this.lbl_idH_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(112, 359);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(31, 15);
            this.lbl_type.TabIndex = 6;
            this.lbl_type.Text = "Type";
            // 
            // tbx_libelle
            // 
            this.tbx_libelle.Location = new System.Drawing.Point(240, 84);
            this.tbx_libelle.Name = "tbx_libelle";
            this.tbx_libelle.Size = new System.Drawing.Size(100, 23);
            this.tbx_libelle.TabIndex = 7;
            this.tbx_libelle.TextChanged += new System.EventHandler(this.tbx_libelle_TextChanged);
            // 
            // tbx_salle
            // 
            this.tbx_salle.Location = new System.Drawing.Point(240, 272);
            this.tbx_salle.Name = "tbx_salle";
            this.tbx_salle.Size = new System.Drawing.Size(100, 23);
            this.tbx_salle.TabIndex = 11;
            this.tbx_salle.TextChanged += new System.EventHandler(this.tbx_salle_TextChanged);
            // 
            // btn_creer
            // 
            this.btn_creer.Enabled = false;
            this.btn_creer.Location = new System.Drawing.Point(522, 323);
            this.btn_creer.Name = "btn_creer";
            this.btn_creer.Size = new System.Drawing.Size(164, 58);
            this.btn_creer.TabIndex = 14;
            this.btn_creer.Text = "Créer";
            this.btn_creer.UseVisualStyleBackColor = true;
            this.btn_creer.Click += new System.EventHandler(this.btn_creer_Click);
            // 
            // lbx_type
            // 
            this.lbx_type.FormattingEnabled = true;
            this.lbx_type.ItemHeight = 15;
            this.lbx_type.Items.AddRange(new object[] {
            "initiation",
            "conference"});
            this.lbx_type.Location = new System.Drawing.Point(240, 359);
            this.lbx_type.Name = "lbx_type";
            this.lbx_type.Size = new System.Drawing.Size(125, 34);
            this.lbx_type.TabIndex = 15;
            this.lbx_type.SelectedIndexChanged += new System.EventHandler(this.lbx_type_SelectedIndexChanged);
            // 
            // lbl_nbParticipants
            // 
            this.lbl_nbParticipants.AutoSize = true;
            this.lbl_nbParticipants.Location = new System.Drawing.Point(483, 83);
            this.lbl_nbParticipants.Name = "lbl_nbParticipants";
            this.lbl_nbParticipants.Size = new System.Drawing.Size(132, 15);
            this.lbl_nbParticipants.TabIndex = 16;
            this.lbl_nbParticipants.Text = "Nombre de participants";
            // 
            // lbl_themeE
            // 
            this.lbl_themeE.AutoSize = true;
            this.lbl_themeE.Location = new System.Drawing.Point(483, 134);
            this.lbl_themeE.Name = "lbl_themeE";
            this.lbl_themeE.Size = new System.Drawing.Size(127, 15);
            this.lbl_themeE.TabIndex = 17;
            this.lbl_themeE.Text = "Theme de l\'évènement";
            // 
            // lbl_intervenant
            // 
            this.lbl_intervenant.AutoSize = true;
            this.lbl_intervenant.Location = new System.Drawing.Point(483, 183);
            this.lbl_intervenant.Name = "lbl_intervenant";
            this.lbl_intervenant.Size = new System.Drawing.Size(67, 15);
            this.lbl_intervenant.TabIndex = 18;
            this.lbl_intervenant.Text = "Intervenant";
            // 
            // tbx_themeE
            // 
            this.tbx_themeE.Enabled = false;
            this.tbx_themeE.Location = new System.Drawing.Point(640, 126);
            this.tbx_themeE.Name = "tbx_themeE";
            this.tbx_themeE.Size = new System.Drawing.Size(100, 23);
            this.tbx_themeE.TabIndex = 20;
            this.tbx_themeE.TextChanged += new System.EventHandler(this.tbx_themeE_TextChanged);
            // 
            // tbx_intervenant
            // 
            this.tbx_intervenant.Enabled = false;
            this.tbx_intervenant.Location = new System.Drawing.Point(640, 174);
            this.tbx_intervenant.Name = "tbx_intervenant";
            this.tbx_intervenant.Size = new System.Drawing.Size(100, 23);
            this.tbx_intervenant.TabIndex = 21;
            this.tbx_intervenant.TextChanged += new System.EventHandler(this.tbx_intervenant_TextChanged);
            // 
            // tbx_date
            // 
            this.tbx_date.Location = new System.Drawing.Point(240, 125);
            this.tbx_date.Mask = "00/00/0000";
            this.tbx_date.Name = "tbx_date";
            this.tbx_date.Size = new System.Drawing.Size(100, 23);
            this.tbx_date.TabIndex = 22;
            this.tbx_date.ValidatingType = typeof(System.DateTime);
            // 
            // tbx_heure
            // 
            this.tbx_heure.Location = new System.Drawing.Point(240, 174);
            this.tbx_heure.Mask = "00:00:00";
            this.tbx_heure.Name = "tbx_heure";
            this.tbx_heure.Size = new System.Drawing.Size(100, 23);
            this.tbx_heure.TabIndex = 23;
            this.tbx_heure.ValidatingType = typeof(System.DateTime);
            // 
            // tbx_duree
            // 
            this.tbx_duree.Location = new System.Drawing.Point(240, 228);
            this.tbx_duree.Mask = "00:00:00";
            this.tbx_duree.Name = "tbx_duree";
            this.tbx_duree.Size = new System.Drawing.Size(100, 23);
            this.tbx_duree.TabIndex = 24;
            this.tbx_duree.ValidatingType = typeof(System.DateTime);
            // 
            // cbx_idH
            // 
            this.cbx_idH.FormattingEnabled = true;
            this.cbx_idH.Location = new System.Drawing.Point(240, 315);
            this.cbx_idH.Name = "cbx_idH";
            this.cbx_idH.Size = new System.Drawing.Size(207, 23);
            this.cbx_idH.TabIndex = 25;
            this.cbx_idH.SelectedIndexChanged += new System.EventHandler(this.cbx_idH_SelectedIndexChanged);
            // 
            // tbx_nbParticipants
            // 
            this.tbx_nbParticipants.Location = new System.Drawing.Point(640, 76);
            this.tbx_nbParticipants.Mask = "999";
            this.tbx_nbParticipants.Name = "tbx_nbParticipants";
            this.tbx_nbParticipants.Size = new System.Drawing.Size(100, 23);
            this.tbx_nbParticipants.TabIndex = 26;
            this.tbx_nbParticipants.ValidatingType = typeof(int);
            this.tbx_nbParticipants.TextChanged += new System.EventHandler(this.tbx_nbParticipants_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_nbParticipants);
            this.Controls.Add(this.cbx_idH);
            this.Controls.Add(this.tbx_duree);
            this.Controls.Add(this.tbx_heure);
            this.Controls.Add(this.tbx_date);
            this.Controls.Add(this.tbx_intervenant);
            this.Controls.Add(this.tbx_themeE);
            this.Controls.Add(this.lbl_intervenant);
            this.Controls.Add(this.lbl_themeE);
            this.Controls.Add(this.lbl_nbParticipants);
            this.Controls.Add(this.lbx_type);
            this.Controls.Add(this.btn_creer);
            this.Controls.Add(this.tbx_salle);
            this.Controls.Add(this.tbx_libelle);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_idH);
            this.Controls.Add(this.lbl_salle);
            this.Controls.Add(this.lbl_duree);
            this.Controls.Add(this.lbl_heure);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_libelle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_libelle;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_heure;
        private System.Windows.Forms.Label lbl_duree;
        private System.Windows.Forms.Label lbl_salle;
        private System.Windows.Forms.Label lbl_idH;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.TextBox tbx_libelle;
        private System.Windows.Forms.TextBox tbx_salle;
        private System.Windows.Forms.Button btn_creer;
        private System.Windows.Forms.ListBox lbx_type;
        private System.Windows.Forms.Label lbl_nbParticipants;
        private System.Windows.Forms.Label lbl_themeE;
        private System.Windows.Forms.Label lbl_intervenant;
        private System.Windows.Forms.TextBox tbx_themeE;
        private System.Windows.Forms.TextBox tbx_intervenant;
        private System.Windows.Forms.MaskedTextBox tbx_date;
        private System.Windows.Forms.MaskedTextBox tbx_heure;
        private System.Windows.Forms.MaskedTextBox tbx_duree;
        private System.Windows.Forms.ComboBox cbx_idH;
        private System.Windows.Forms.MaskedTextBox tbx_nbParticipants;
    }
}