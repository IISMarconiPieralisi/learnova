namespace elearning
{
    partial class FrmStudenti
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.lvStudenti = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCognome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMatricola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chScuola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClasse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbParametriRicerca = new System.Windows.Forms.ComboBox();
            this.btnCestino = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.tbRicerca = new System.Windows.Forms.TextBox();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbMatricola = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClassi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtbCodiceFiscale = new System.Windows.Forms.MaskedTextBox();
            this.cbVediPassword = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.tbScuola = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMaster.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMaster
            // 
            this.pnlMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaster.Controls.Add(this.lvStudenti);
            this.pnlMaster.Controls.Add(this.cbParametriRicerca);
            this.pnlMaster.Controls.Add(this.btnCestino);
            this.pnlMaster.Controls.Add(this.btnModifica);
            this.pnlMaster.Controls.Add(this.btnNuovo);
            this.pnlMaster.Controls.Add(this.btnCerca);
            this.pnlMaster.Controls.Add(this.tbRicerca);
            this.pnlMaster.Location = new System.Drawing.Point(0, 134);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(726, 622);
            this.pnlMaster.TabIndex = 8;
            // 
            // lvStudenti
            // 
            this.lvStudenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStudenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNome,
            this.chCognome,
            this.chMatricola,
            this.chScuola,
            this.chClasse});
            this.lvStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStudenti.FullRowSelect = true;
            this.lvStudenti.HideSelection = false;
            this.lvStudenti.Location = new System.Drawing.Point(12, 60);
            this.lvStudenti.Name = "lvStudenti";
            this.lvStudenti.Size = new System.Drawing.Size(655, 550);
            this.lvStudenti.TabIndex = 8;
            this.lvStudenti.UseCompatibleStateImageBehavior = false;
            this.lvStudenti.View = System.Windows.Forms.View.Details;
            this.lvStudenti.SelectedIndexChanged += new System.EventHandler(this.lvStudenti_SelectedIndexChanged);
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 150;
            // 
            // chCognome
            // 
            this.chCognome.Text = "Cognome";
            this.chCognome.Width = 150;
            // 
            // chMatricola
            // 
            this.chMatricola.Text = "Matricola";
            this.chMatricola.Width = 120;
            // 
            // chScuola
            // 
            this.chScuola.Text = "Scuola";
            this.chScuola.Width = 150;
            // 
            // chClasse
            // 
            this.chClasse.Text = "Classe";
            this.chClasse.Width = 80;
            // 
            // cbParametriRicerca
            // 
            this.cbParametriRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbParametriRicerca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParametriRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParametriRicerca.FormattingEnabled = true;
            this.cbParametriRicerca.Location = new System.Drawing.Point(409, 17);
            this.cbParametriRicerca.Name = "cbParametriRicerca";
            this.cbParametriRicerca.Size = new System.Drawing.Size(258, 28);
            this.cbParametriRicerca.TabIndex = 7;
            // 
            // btnCestino
            // 
            this.btnCestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCestino.Image = global::elearning.Properties.Resources.iconaCestino2_48x48;
            this.btnCestino.Location = new System.Drawing.Point(673, 448);
            this.btnCestino.Name = "btnCestino";
            this.btnCestino.Size = new System.Drawing.Size(50, 50);
            this.btnCestino.TabIndex = 6;
            this.btnCestino.UseVisualStyleBackColor = true;
            this.btnCestino.Click += new System.EventHandler(this.btnCestino_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifica.Image = global::elearning.Properties.Resources.iconaModifica1_39x39;
            this.btnModifica.Location = new System.Drawing.Point(673, 504);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(50, 50);
            this.btnModifica.TabIndex = 4;
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovo.Image = global::elearning.Properties.Resources.iconaNuovo1_39x39;
            this.btnNuovo.Location = new System.Drawing.Point(673, 560);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(50, 50);
            this.btnNuovo.TabIndex = 3;
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerca.Image = global::elearning.Properties.Resources.iconaLenteRicerca1_36x36;
            this.btnCerca.Location = new System.Drawing.Point(673, 4);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(50, 50);
            this.btnCerca.TabIndex = 1;
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // tbRicerca
            // 
            this.tbRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRicerca.Location = new System.Drawing.Point(12, 17);
            this.tbRicerca.Name = "tbRicerca";
            this.tbRicerca.Size = new System.Drawing.Size(391, 26);
            this.tbRicerca.TabIndex = 0;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetail.Controls.Add(this.label7);
            this.pnlDetail.Controls.Add(this.mtbMatricola);
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.cbClassi);
            this.pnlDetail.Controls.Add(this.label9);
            this.pnlDetail.Controls.Add(this.mtbCodiceFiscale);
            this.pnlDetail.Controls.Add(this.cbVediPassword);
            this.pnlDetail.Controls.Add(this.tbPassword);
            this.pnlDetail.Controls.Add(this.btnSalva);
            this.pnlDetail.Controls.Add(this.tbScuola);
            this.pnlDetail.Controls.Add(this.label6);
            this.pnlDetail.Controls.Add(this.label5);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.tbCognome);
            this.pnlDetail.Controls.Add(this.label1);
            this.pnlDetail.Controls.Add(this.tbNome);
            this.pnlDetail.Location = new System.Drawing.Point(729, 134);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(658, 622);
            this.pnlDetail.TabIndex = 9;
            this.pnlDetail.EnabledChanged += new System.EventHandler(this.pnlDetail_EnabledChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(637, 34);
            this.label7.TabIndex = 25;
            this.label7.Text = "Scuola";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbMatricola
            // 
            this.mtbMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbMatricola.Location = new System.Drawing.Point(3, 188);
            this.mtbMatricola.Mask = "st00000";
            this.mtbMatricola.Name = "mtbMatricola";
            this.mtbMatricola.Size = new System.Drawing.Size(637, 31);
            this.mtbMatricola.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(637, 34);
            this.label3.TabIndex = 23;
            this.label3.Text = "Matricola e username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbClassi
            // 
            this.cbClassi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClassi.FormattingEnabled = true;
            this.cbClassi.Location = new System.Drawing.Point(0, 501);
            this.cbClassi.Name = "cbClassi";
            this.cbClassi.Size = new System.Drawing.Size(640, 33);
            this.cbClassi.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(637, 34);
            this.label9.TabIndex = 21;
            this.label9.Text = "Classe";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbCodiceFiscale
            // 
            this.mtbCodiceFiscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCodiceFiscale.Location = new System.Drawing.Point(3, 354);
            this.mtbCodiceFiscale.Mask = "AAAAAA00A00A000A";
            this.mtbCodiceFiscale.Name = "mtbCodiceFiscale";
            this.mtbCodiceFiscale.Size = new System.Drawing.Size(637, 31);
            this.mtbCodiceFiscale.TabIndex = 18;
            // 
            // cbVediPassword
            // 
            this.cbVediPassword.AutoSize = true;
            this.cbVediPassword.Location = new System.Drawing.Point(8, 297);
            this.cbVediPassword.Name = "cbVediPassword";
            this.cbVediPassword.Size = new System.Drawing.Size(106, 17);
            this.cbVediPassword.TabIndex = 17;
            this.cbVediPassword.Text = "Password visibile";
            this.cbVediPassword.UseVisualStyleBackColor = true;
            this.cbVediPassword.CheckedChanged += new System.EventHandler(this.cbVediPassword_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(3, 259);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(637, 31);
            this.tbPassword.TabIndex = 16;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(486, 566);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(154, 37);
            this.btnSalva.TabIndex = 15;
            this.btnSalva.Text = "Salva modifiche";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // tbScuola
            // 
            this.tbScuola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScuola.Location = new System.Drawing.Point(3, 425);
            this.tbScuola.Name = "tbScuola";
            this.tbScuola.Size = new System.Drawing.Size(637, 31);
            this.tbScuola.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(637, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Codice fiscale";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(637, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cognome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCognome
            // 
            this.tbCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCognome.Location = new System.Drawing.Point(3, 117);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(637, 31);
            this.tbCognome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(3, 46);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(637, 31);
            this.tbNome.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1387, 134);
            this.label4.TabIndex = 7;
            this.label4.Text = "Studenti";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1387, 756);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlMaster);
            this.Controls.Add(this.label4);
            this.Name = "FrmStudenti";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.FrmStudenti_Load);
            this.pnlMaster.ResumeLayout(false);
            this.pnlMaster.PerformLayout();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox tbRicerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCestino;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbVediPassword;
        private System.Windows.Forms.MaskedTextBox mtbCodiceFiscale;
        private System.Windows.Forms.ComboBox cbParametriRicerca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbClassi;
        private System.Windows.Forms.ListView lvStudenti;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chCognome;
        private System.Windows.Forms.ColumnHeader chMatricola;
        private System.Windows.Forms.ColumnHeader chScuola;
        private System.Windows.Forms.ColumnHeader chClasse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbMatricola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbScuola;
    }
}

