namespace elearning
{
    partial class FrmClassi
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
            this.lvClasse = new System.Windows.Forms.ListView();
            this.chSigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnCerca = new System.Windows.Forms.Button();
            this.tbCerca = new System.Windows.Forms.TextBox();
            this.tbSigla = new System.Windows.Forms.TextBox();
            this.BtnSalva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSalva = new System.Windows.Forms.Panel();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chPer5 = new System.Windows.Forms.CheckBox();
            this.lblAvvertimento = new System.Windows.Forms.Label();
            this.pnlSalva.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-361, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1904, 134);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gestione Classe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvClasse
            // 
            this.lvClasse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSigla});
            this.lvClasse.FullRowSelect = true;
            this.lvClasse.HideSelection = false;
            this.lvClasse.Location = new System.Drawing.Point(12, 223);
            this.lvClasse.Name = "lvClasse";
            this.lvClasse.Size = new System.Drawing.Size(415, 359);
            this.lvClasse.TabIndex = 8;
            this.lvClasse.UseCompatibleStateImageBehavior = false;
            this.lvClasse.View = System.Windows.Forms.View.Details;
            // 
            // chSigla
            // 
            this.chSigla.Text = "Nome";
            this.chSigla.Width = 414;
            // 
            // BtnCerca
            // 
            this.BtnCerca.Image = global::elearning.Properties.Resources.iconaLenteRicerca1_28x28;
            this.BtnCerca.Location = new System.Drawing.Point(391, 148);
            this.BtnCerca.Name = "BtnCerca";
            this.BtnCerca.Size = new System.Drawing.Size(38, 38);
            this.BtnCerca.TabIndex = 34;
            this.BtnCerca.UseVisualStyleBackColor = true;
            this.BtnCerca.Click += new System.EventHandler(this.BtnCerca_Click);
            // 
            // tbCerca
            // 
            this.tbCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCerca.Location = new System.Drawing.Point(12, 148);
            this.tbCerca.Name = "tbCerca";
            this.tbCerca.Size = new System.Drawing.Size(364, 38);
            this.tbCerca.TabIndex = 33;
            // 
            // tbSigla
            // 
            this.tbSigla.Location = new System.Drawing.Point(47, 68);
            this.tbSigla.Name = "tbSigla";
            this.tbSigla.Size = new System.Drawing.Size(235, 20);
            this.tbSigla.TabIndex = 35;
            // 
            // BtnSalva
            // 
            this.BtnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalva.Location = new System.Drawing.Point(47, 160);
            this.BtnSalva.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalva.Name = "BtnSalva";
            this.BtnSalva.Size = new System.Drawing.Size(123, 47);
            this.BtnSalva.TabIndex = 36;
            this.BtnSalva.Text = "Salva";
            this.BtnSalva.UseVisualStyleBackColor = true;
            this.BtnSalva.Click += new System.EventHandler(this.BtnSalva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nome Classe";
            // 
            // pnlSalva
            // 
            this.pnlSalva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSalva.Controls.Add(this.lblAvvertimento);
            this.pnlSalva.Controls.Add(this.chPer5);
            this.pnlSalva.Controls.Add(this.label1);
            this.pnlSalva.Controls.Add(this.BtnSalva);
            this.pnlSalva.Controls.Add(this.tbSigla);
            this.pnlSalva.Location = new System.Drawing.Point(815, 189);
            this.pnlSalva.Name = "pnlSalva";
            this.pnlSalva.Size = new System.Drawing.Size(339, 249);
            this.pnlSalva.TabIndex = 38;
            this.pnlSalva.Visible = false;
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Image = global::elearning.Properties.Resources.iconaModifica1_50x50;
            this.btnModifica.Location = new System.Drawing.Point(473, 321);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 75);
            this.btnModifica.TabIndex = 40;
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Image = global::elearning.Properties.Resources.iconaNuovo1_50x50;
            this.btnAggiungi.Location = new System.Drawing.Point(473, 223);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 75);
            this.btnAggiungi.TabIndex = 38;
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Image = global::elearning.Properties.Resources.iconaCestino2_60x60_sfondoTrasparente;
            this.btnElimina.Location = new System.Drawing.Point(473, 416);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 75);
            this.btnElimina.TabIndex = 39;
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::elearning.Properties.Resources.iconaOrdina1_50x50;
            this.button1.Location = new System.Drawing.Point(473, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // chPer5
            // 
            this.chPer5.AutoSize = true;
            this.chPer5.Checked = true;
            this.chPer5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chPer5.Location = new System.Drawing.Point(47, 94);
            this.chPer5.Name = "chPer5";
            this.chPer5.Size = new System.Drawing.Size(142, 17);
            this.chPer5.TabIndex = 38;
            this.chPer5.Text = "Crea la classe per 5 anni";
            this.chPer5.UseVisualStyleBackColor = true;
            // 
            // lblAvvertimento
            // 
            this.lblAvvertimento.AutoSize = true;
            this.lblAvvertimento.Location = new System.Drawing.Point(47, 114);
            this.lblAvvertimento.Name = "lblAvvertimento";
            this.lblAvvertimento.Size = new System.Drawing.Size(165, 13);
            this.lblAvvertimento.TabIndex = 39;
            this.lblAvvertimento.Text = "se selezionato non inserire numeri";
            // 
            // FrmClassi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.pnlSalva);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.BtnCerca);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.tbCerca);
            this.Controls.Add(this.lvClasse);
            this.Controls.Add(this.label3);
            this.Name = "FrmClassi";
            this.Text = "FrmClasse";
            this.Load += new System.EventHandler(this.FrmClassi_Load);
            this.pnlSalva.ResumeLayout(false);
            this.pnlSalva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvClasse;
        private System.Windows.Forms.ColumnHeader chSigla;
        private System.Windows.Forms.Button BtnCerca;
        private System.Windows.Forms.TextBox tbCerca;
        private System.Windows.Forms.TextBox tbSigla;
        private System.Windows.Forms.Button BtnSalva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSalva;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chPer5;
        private System.Windows.Forms.Label lblAvvertimento;
    }
}