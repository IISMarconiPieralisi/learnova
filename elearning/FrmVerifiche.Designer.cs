namespace elearning
{
    partial class FrmVerifiche
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
            this.lvVerifiche = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbCerca = new System.Windows.Forms.TextBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.cbFiltroOrdinamento = new System.Windows.Forms.ComboBox();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.lblVerifiche = new System.Windows.Forms.Label();
            this.cbCerca = new System.Windows.Forms.ComboBox();
            this.btnStatistiche = new System.Windows.Forms.Button();
            this.pnlstudente = new System.Windows.Forms.Panel();
            this.btnIniziaCompito = new System.Windows.Forms.Button();
            this.pnlstudente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvVerifiche
            // 
            this.lvVerifiche.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvVerifiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvVerifiche.FullRowSelect = true;
            this.lvVerifiche.HideSelection = false;
            this.lvVerifiche.Location = new System.Drawing.Point(12, 126);
            this.lvVerifiche.MultiSelect = false;
            this.lvVerifiche.Name = "lvVerifiche";
            this.lvVerifiche.Size = new System.Drawing.Size(1473, 851);
            this.lvVerifiche.TabIndex = 7;
            this.lvVerifiche.UseCompatibleStateImageBehavior = false;
            this.lvVerifiche.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Durata";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Disciplina";
            this.columnHeader5.Width = 400;
            // 
            // tbCerca
            // 
            this.tbCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCerca.Location = new System.Drawing.Point(1503, 201);
            this.tbCerca.Name = "tbCerca";
            this.tbCerca.Size = new System.Drawing.Size(336, 47);
            this.tbCerca.TabIndex = 12;
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(291, 3);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(100, 100);
            this.btnElimina.TabIndex = 14;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click_1);
            // 
            // cbFiltroOrdinamento
            // 
            this.cbFiltroOrdinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroOrdinamento.FormattingEnabled = true;
            this.cbFiltroOrdinamento.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Data",
            "Durata",
            "Disciplina"});
            this.cbFiltroOrdinamento.Location = new System.Drawing.Point(1503, 288);
            this.cbFiltroOrdinamento.Name = "cbFiltroOrdinamento";
            this.cbFiltroOrdinamento.Size = new System.Drawing.Size(336, 45);
            this.cbFiltroOrdinamento.TabIndex = 15;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdina.Location = new System.Drawing.Point(1845, 283);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(50, 50);
            this.btnOrdina.TabIndex = 13;
            this.btnOrdina.Text = "↕";
            this.btnOrdina.UseVisualStyleBackColor = true;
            // 
            // btnCerca
            // 
            this.btnCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerca.Location = new System.Drawing.Point(1845, 198);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(51, 51);
            this.btnCerca.TabIndex = 11;
            this.btnCerca.Text = "🔍";
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(150, 3);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(100, 100);
            this.btnModifica.TabIndex = 9;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnInserisci
            // 
            this.btnInserisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisci.Location = new System.Drawing.Point(3, 3);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(100, 100);
            this.btnInserisci.TabIndex = 8;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // lblVerifiche
            // 
            this.lblVerifiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifiche.ForeColor = System.Drawing.Color.White;
            this.lblVerifiche.Location = new System.Drawing.Point(12, 9);
            this.lblVerifiche.Name = "lblVerifiche";
            this.lblVerifiche.Size = new System.Drawing.Size(561, 97);
            this.lblVerifiche.TabIndex = 16;
            this.lblVerifiche.Text = "VERIFICHE";
            // 
            // cbCerca
            // 
            this.cbCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCerca.FormattingEnabled = true;
            this.cbCerca.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Data",
            "Disciplina"});
            this.cbCerca.Location = new System.Drawing.Point(1503, 126);
            this.cbCerca.Name = "cbCerca";
            this.cbCerca.Size = new System.Drawing.Size(389, 45);
            this.cbCerca.TabIndex = 17;
            this.cbCerca.SelectedIndexChanged += new System.EventHandler(this.cbCerca_SelectedIndexChanged);
            // 
            // btnStatistiche
            // 
            this.btnStatistiche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStatistiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistiche.ForeColor = System.Drawing.Color.White;
            this.btnStatistiche.Location = new System.Drawing.Point(1503, 400);
            this.btnStatistiche.Name = "btnStatistiche";
            this.btnStatistiche.Size = new System.Drawing.Size(389, 80);
            this.btnStatistiche.TabIndex = 18;
            this.btnStatistiche.Text = "📊 Statistiche";
            this.btnStatistiche.UseVisualStyleBackColor = false;
            this.btnStatistiche.Click += new System.EventHandler(this.btnStatistiche_Click);
            // 
            // pnlstudente
            // 
            this.pnlstudente.Controls.Add(this.btnInserisci);
            this.pnlstudente.Controls.Add(this.btnModifica);
            this.pnlstudente.Controls.Add(this.btnElimina);
            this.pnlstudente.Location = new System.Drawing.Point(1503, 865);
            this.pnlstudente.Name = "pnlstudente";
            this.pnlstudente.Size = new System.Drawing.Size(391, 130);
            this.pnlstudente.TabIndex = 19;
            // 
            // btnIniziaCompito
            // 
            this.btnIniziaCompito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniziaCompito.Location = new System.Drawing.Point(1513, 760);
            this.btnIniziaCompito.Name = "btnIniziaCompito";
            this.btnIniziaCompito.Size = new System.Drawing.Size(379, 70);
            this.btnIniziaCompito.TabIndex = 20;
            this.btnIniziaCompito.Text = "Inizia Compito";
            this.btnIniziaCompito.UseVisualStyleBackColor = true;
            this.btnIniziaCompito.Visible = false;
            this.btnIniziaCompito.Click += new System.EventHandler(this.btnIniziaCompito_Click);
            // 
            // FrmVerifiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnIniziaCompito);
            this.Controls.Add(this.pnlstudente);
            this.Controls.Add(this.btnStatistiche);
            this.Controls.Add(this.cbCerca);
            this.Controls.Add(this.lblVerifiche);
            this.Controls.Add(this.cbFiltroOrdinamento);
            this.Controls.Add(this.lvVerifiche);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.tbCerca);
            this.Controls.Add(this.btnCerca);
            this.Name = "FrmVerifiche";
            this.Text = "Verifiche";
            this.Load += new System.EventHandler(this.FrmVerifiche_Load);
            this.pnlstudente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvVerifiche;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.TextBox tbCerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.ComboBox cbFiltroOrdinamento;
        private System.Windows.Forms.Label lblVerifiche;
        private System.Windows.Forms.ComboBox cbCerca;
        private System.Windows.Forms.Button btnStatistiche;
        private System.Windows.Forms.Panel pnlstudente;
        private System.Windows.Forms.Button btnIniziaCompito;
    }
}