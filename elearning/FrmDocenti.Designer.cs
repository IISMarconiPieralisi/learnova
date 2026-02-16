namespace elearning
{
    partial class FrmDocenti
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
            this.label3 = new System.Windows.Forms.Label();
            this.lvDocenti = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCognome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbCerca = new System.Windows.Forms.TextBox();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.btnEliminaMC = new System.Windows.Forms.Button();
            this.btnAggiungiDC = new System.Windows.Forms.Button();
            this.cbClassi = new System.Windows.Forms.ComboBox();
            this.cbDiscipline = new System.Windows.Forms.ComboBox();
            this.lvDisciplineClassi = new System.Windows.Forms.ListView();
            this.chDiscipline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClasse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDisciplineClassi = new System.Windows.Forms.Label();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCestino = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.cbRicerca = new System.Windows.Forms.ComboBox();
            this.lblCerca = new System.Windows.Forms.Label();
            this.mtbCodiceFiscale = new System.Windows.Forms.MaskedTextBox();
            this.pnlDetails.SuspendLayout();
            this.pnlMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1904, 134);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gestione Docenti";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvDocenti
            // 
            this.lvDocenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNome,
            this.chCognome,
            this.chCF,
            this.chUsername,
            this.chMmail,
            this.chPassword});
            this.lvDocenti.FullRowSelect = true;
            this.lvDocenti.HideSelection = false;
            this.lvDocenti.Location = new System.Drawing.Point(18, 113);
            this.lvDocenti.Name = "lvDocenti";
            this.lvDocenti.Size = new System.Drawing.Size(898, 711);
            this.lvDocenti.TabIndex = 7;
            this.lvDocenti.UseCompatibleStateImageBehavior = false;
            this.lvDocenti.View = System.Windows.Forms.View.Details;
            this.lvDocenti.SelectedIndexChanged += new System.EventHandler(this.lvDocenti_SelectedIndexChanged);
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 156;
            // 
            // chCognome
            // 
            this.chCognome.Text = "Cognome";
            this.chCognome.Width = 134;
            // 
            // chCF
            // 
            this.chCF.Text = "Codice Fiscale";
            this.chCF.Width = 244;
            // 
            // chUsername
            // 
            this.chUsername.Text = "Username";
            this.chUsername.Width = 214;
            // 
            // chMmail
            // 
            this.chMmail.Text = "Email";
            this.chMmail.Width = 331;
            // 
            // chPassword
            // 
            this.chPassword.Text = "Password";
            this.chPassword.Width = 234;
            // 
            // tbCerca
            // 
            this.tbCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCerca.Location = new System.Drawing.Point(18, 52);
            this.tbCerca.Name = "tbCerca";
            this.tbCerca.Size = new System.Drawing.Size(364, 38);
            this.tbCerca.TabIndex = 8;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.mtbCodiceFiscale);
            this.pnlDetails.Controls.Add(this.lblDisciplina);
            this.pnlDetails.Controls.Add(this.lblClasse);
            this.pnlDetails.Controls.Add(this.btnEliminaMC);
            this.pnlDetails.Controls.Add(this.btnAggiungiDC);
            this.pnlDetails.Controls.Add(this.cbClassi);
            this.pnlDetails.Controls.Add(this.cbDiscipline);
            this.pnlDetails.Controls.Add(this.lvDisciplineClassi);
            this.pnlDetails.Controls.Add(this.lblDisciplineClassi);
            this.pnlDetails.Controls.Add(this.btnAnnulla);
            this.pnlDetails.Controls.Add(this.btnSalva);
            this.pnlDetails.Controls.Add(this.tbPassword);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.tbUsername);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.tbEmail);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.tbCognome);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.tbNome);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Enabled = false;
            this.pnlDetails.Location = new System.Drawing.Point(1099, 149);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(602, 850);
            this.pnlDetails.TabIndex = 29;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplina.Location = new System.Drawing.Point(380, 542);
            this.lblDisciplina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(76, 20);
            this.lblDisciplina.TabIndex = 51;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.Location = new System.Drawing.Point(380, 587);
            this.lblClasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(57, 20);
            this.lblClasse.TabIndex = 50;
            this.lblClasse.Text = "Classe";
            // 
            // btnEliminaMC
            // 
            this.btnEliminaMC.Location = new System.Drawing.Point(159, 653);
            this.btnEliminaMC.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminaMC.Name = "btnEliminaMC";
            this.btnEliminaMC.Size = new System.Drawing.Size(124, 30);
            this.btnEliminaMC.TabIndex = 48;
            this.btnEliminaMC.Text = "Elimina";
            this.btnEliminaMC.UseVisualStyleBackColor = true;
            this.btnEliminaMC.Click += new System.EventHandler(this.btnEliminaDC_Click);
            // 
            // btnAggiungiDC
            // 
            this.btnAggiungiDC.Location = new System.Drawing.Point(385, 653);
            this.btnAggiungiDC.Margin = new System.Windows.Forms.Padding(2);
            this.btnAggiungiDC.Name = "btnAggiungiDC";
            this.btnAggiungiDC.Size = new System.Drawing.Size(124, 30);
            this.btnAggiungiDC.TabIndex = 47;
            this.btnAggiungiDC.Text = "Aggiungi";
            this.btnAggiungiDC.UseVisualStyleBackColor = true;
            this.btnAggiungiDC.Click += new System.EventHandler(this.btnAggiungiDC_Click);
            // 
            // cbClassi
            // 
            this.cbClassi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassi.FormattingEnabled = true;
            this.cbClassi.Location = new System.Drawing.Point(384, 609);
            this.cbClassi.Margin = new System.Windows.Forms.Padding(2);
            this.cbClassi.Name = "cbClassi";
            this.cbClassi.Size = new System.Drawing.Size(125, 21);
            this.cbClassi.TabIndex = 46;
            // 
            // cbDiscipline
            // 
            this.cbDiscipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscipline.FormattingEnabled = true;
            this.cbDiscipline.Location = new System.Drawing.Point(384, 564);
            this.cbDiscipline.Margin = new System.Windows.Forms.Padding(2);
            this.cbDiscipline.Name = "cbDiscipline";
            this.cbDiscipline.Size = new System.Drawing.Size(125, 21);
            this.cbDiscipline.TabIndex = 42;
            // 
            // lvDisciplineClassi
            // 
            this.lvDisciplineClassi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDiscipline,
            this.chClasse});
            this.lvDisciplineClassi.FullRowSelect = true;
            this.lvDisciplineClassi.HideSelection = false;
            this.lvDisciplineClassi.Location = new System.Drawing.Point(86, 537);
            this.lvDisciplineClassi.Margin = new System.Windows.Forms.Padding(2);
            this.lvDisciplineClassi.Name = "lvDisciplineClassi";
            this.lvDisciplineClassi.Size = new System.Drawing.Size(271, 92);
            this.lvDisciplineClassi.TabIndex = 41;
            this.lvDisciplineClassi.UseCompatibleStateImageBehavior = false;
            this.lvDisciplineClassi.View = System.Windows.Forms.View.Details;
            // 
            // chDiscipline
            // 
            this.chDiscipline.Text = "Discipline";
            this.chDiscipline.Width = 165;
            // 
            // chClasse
            // 
            this.chClasse.Text = "Classe";
            this.chClasse.Width = 69;
            // 
            // lblDisciplineClassi
            // 
            this.lblDisciplineClassi.AutoSize = true;
            this.lblDisciplineClassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplineClassi.Location = new System.Drawing.Point(84, 498);
            this.lblDisciplineClassi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisciplineClassi.Name = "lblDisciplineClassi";
            this.lblDisciplineClassi.Size = new System.Drawing.Size(132, 20);
            this.lblDisciplineClassi.TabIndex = 40;
            this.lblDisciplineClassi.Text = "Discipline e classi";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(235, 805);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(123, 32);
            this.btnAnnulla.TabIndex = 39;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(235, 754);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(123, 32);
            this.btnSalva.TabIndex = 38;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(346, 450);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(175, 20);
            this.tbPassword.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(87, 450);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(175, 20);
            this.tbUsername.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Username";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(87, 370);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(259, 20);
            this.tbEmail.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Codice Fiscale";
            // 
            // tbCognome
            // 
            this.tbCognome.Location = new System.Drawing.Point(346, 205);
            this.tbCognome.Margin = new System.Windows.Forms.Padding(2);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(175, 20);
            this.tbCognome.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cognome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(87, 205);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(175, 20);
            this.tbNome.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dettagli Docente";
            // 
            // btnRicerca
            // 
            this.btnRicerca.Image = global::elearning.Properties.Resources.iconaLenteRicerca1_28x28;
            this.btnRicerca.Location = new System.Drawing.Point(643, 52);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(38, 38);
            this.btnRicerca.TabIndex = 9;
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // pnlMaster
            // 
            this.pnlMaster.Controls.Add(this.button2);
            this.pnlMaster.Controls.Add(this.btnCestino);
            this.pnlMaster.Controls.Add(this.button1);
            this.pnlMaster.Controls.Add(this.btnNuovo);
            this.pnlMaster.Controls.Add(this.cbRicerca);
            this.pnlMaster.Controls.Add(this.lblCerca);
            this.pnlMaster.Controls.Add(this.btnRicerca);
            this.pnlMaster.Controls.Add(this.tbCerca);
            this.pnlMaster.Controls.Add(this.lvDocenti);
            this.pnlMaster.Location = new System.Drawing.Point(12, 150);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(1082, 849);
            this.pnlMaster.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::elearning.Properties.Resources.iconaOrdina1_50x50;
            this.button2.Location = new System.Drawing.Point(978, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // btnCestino
            // 
            this.btnCestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCestino.Image = global::elearning.Properties.Resources.iconaCestino2_48x48;
            this.btnCestino.Location = new System.Drawing.Point(978, 293);
            this.btnCestino.Name = "btnCestino";
            this.btnCestino.Size = new System.Drawing.Size(50, 50);
            this.btnCestino.TabIndex = 33;
            this.btnCestino.UseVisualStyleBackColor = true;
            this.btnCestino.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::elearning.Properties.Resources.iconaModifica1_39x39;
            this.button1.Location = new System.Drawing.Point(978, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovo.Image = global::elearning.Properties.Resources.iconaNuovo1_39x39;
            this.btnNuovo.Location = new System.Drawing.Point(978, 113);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(50, 50);
            this.btnNuovo.TabIndex = 31;
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // cbRicerca
            // 
            this.cbRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRicerca.FormattingEnabled = true;
            this.cbRicerca.ItemHeight = 29;
            this.cbRicerca.Location = new System.Drawing.Point(435, 55);
            this.cbRicerca.Margin = new System.Windows.Forms.Padding(2);
            this.cbRicerca.Name = "cbRicerca";
            this.cbRicerca.Size = new System.Drawing.Size(181, 37);
            this.cbRicerca.TabIndex = 30;
            // 
            // lblCerca
            // 
            this.lblCerca.AutoSize = true;
            this.lblCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerca.Location = new System.Drawing.Point(15, 25);
            this.lblCerca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCerca.Name = "lblCerca";
            this.lblCerca.Size = new System.Drawing.Size(176, 24);
            this.lblCerca.TabIndex = 29;
            this.lblCerca.Text = "Cerca per parametri";
            // 
            // mtbCodiceFiscale
            // 
            this.mtbCodiceFiscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCodiceFiscale.Location = new System.Drawing.Point(88, 310);
            this.mtbCodiceFiscale.Mask = "AAAAAA00A00A000A";
            this.mtbCodiceFiscale.Name = "mtbCodiceFiscale";
            this.mtbCodiceFiscale.Size = new System.Drawing.Size(259, 20);
            this.mtbCodiceFiscale.TabIndex = 52;
            // 
            // FrmDocenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 924);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlMaster);
            this.Name = "FrmDocenti";
            this.Text = "FrmDocenti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDocenti_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlMaster.ResumeLayout(false);
            this.pnlMaster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvDocenti;
        private System.Windows.Forms.TextBox tbCerca;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chCognome;
        private System.Windows.Forms.ColumnHeader chCF;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chMmail;
        private System.Windows.Forms.ColumnHeader chPassword;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Button btnEliminaMC;
        private System.Windows.Forms.Button btnAggiungiDC;
        private System.Windows.Forms.ComboBox cbClassi;
        private System.Windows.Forms.ComboBox cbDiscipline;
        private System.Windows.Forms.ListView lvDisciplineClassi;
        private System.Windows.Forms.ColumnHeader chDiscipline;
        private System.Windows.Forms.Label lblDisciplineClassi;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.ColumnHeader chClasse;
        private System.Windows.Forms.ComboBox cbRicerca;
        private System.Windows.Forms.Label lblCerca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCestino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.MaskedTextBox mtbCodiceFiscale;
    }
}