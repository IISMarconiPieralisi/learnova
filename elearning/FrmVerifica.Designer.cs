namespace elearning
{
    partial class FrmVerifica
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
            this.pnlTitolo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitoloVerifica = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.pnlDomande = new System.Windows.Forms.Panel();
            this.cbStato = new System.Windows.Forms.ComboBox();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.nudDurata = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.pnlTitolo.SuspendLayout();
            this.pnlDomande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurata)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitolo
            // 
            this.pnlTitolo.BackColor = System.Drawing.Color.Teal;
            this.pnlTitolo.Controls.Add(this.label1);
            this.pnlTitolo.Controls.Add(this.tbTitoloVerifica);
            this.pnlTitolo.Location = new System.Drawing.Point(-1, 0);
            this.pnlTitolo.Name = "pnlTitolo";
            this.pnlTitolo.Size = new System.Drawing.Size(1905, 130);
            this.pnlTitolo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(577, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titolo:";
            // 
            // tbTitoloVerifica
            // 
            this.tbTitoloVerifica.BackColor = System.Drawing.Color.Teal;
            this.tbTitoloVerifica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitoloVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitoloVerifica.ForeColor = System.Drawing.Color.White;
            this.tbTitoloVerifica.Location = new System.Drawing.Point(718, 24);
            this.tbTitoloVerifica.Name = "tbTitoloVerifica";
            this.tbTitoloVerifica.Size = new System.Drawing.Size(510, 91);
            this.tbTitoloVerifica.TabIndex = 5;
            this.tbTitoloVerifica.Text = "Titolo Verifica";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.Teal;
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.ForeColor = System.Drawing.Color.White;
            this.btnAggiungi.Location = new System.Drawing.Point(117, 22);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(1659, 85);
            this.btnAggiungi.TabIndex = 4;
            this.btnAggiungi.Text = "+";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // pnlDomande
            // 
            this.pnlDomande.AutoScroll = true;
            this.pnlDomande.Controls.Add(this.btnAggiungi);
            this.pnlDomande.Location = new System.Drawing.Point(-1, 240);
            this.pnlDomande.Name = "pnlDomande";
            this.pnlDomande.Size = new System.Drawing.Size(1905, 729);
            this.pnlDomande.TabIndex = 5;
            // 
            // cbStato
            // 
            this.cbStato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStato.FormattingEnabled = true;
            this.cbStato.Items.AddRange(new object[] {
            "Chiusa",
            "Aperta"});
            this.cbStato.Location = new System.Drawing.Point(758, 172);
            this.cbStato.Name = "cbStato";
            this.cbStato.Size = new System.Drawing.Size(258, 33);
            this.cbStato.TabIndex = 7;
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(1281, 172);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(258, 33);
            this.cbDisciplina.TabIndex = 8;
            // 
            // nudDurata
            // 
            this.nudDurata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDurata.Location = new System.Drawing.Point(391, 177);
            this.nudDurata.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nudDurata.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDurata.Name = "nudDurata";
            this.nudDurata.Size = new System.Drawing.Size(120, 31);
            this.nudDurata.TabIndex = 9;
            this.nudDurata.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Durata(min):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1130, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Disciplina:";
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.Teal;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.White;
            this.btnSalva.Location = new System.Drawing.Point(1598, 149);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(228, 65);
            this.btnSalva.TabIndex = 13;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // FrmVerifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDurata);
            this.Controls.Add(this.cbDisciplina);
            this.Controls.Add(this.cbStato);
            this.Controls.Add(this.pnlDomande);
            this.Controls.Add(this.pnlTitolo);
            this.Name = "FrmVerifica";
            this.Text = "FrmVerifica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVerifica_Load);
            this.pnlTitolo.ResumeLayout(false);
            this.pnlTitolo.PerformLayout();
            this.pnlDomande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDurata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitolo;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.TextBox tbTitoloVerifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDomande;
        private System.Windows.Forms.ComboBox cbStato;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.NumericUpDown nudDurata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalva;
    }
}