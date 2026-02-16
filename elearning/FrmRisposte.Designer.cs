namespace elearning
{
    partial class FrmRisposte
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
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnCorretta = new System.Windows.Forms.Button();
            this.tbTesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvRisposte = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(446, 117);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(80, 80);
            this.btnAggiungi.TabIndex = 1;
            this.btnAggiungi.Text = "+";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.Color.Red;
            this.btnElimina.Location = new System.Drawing.Point(446, 304);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(80, 80);
            this.btnElimina.TabIndex = 2;
            this.btnElimina.Text = "🗑️";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnCorretta
            // 
            this.btnCorretta.Enabled = false;
            this.btnCorretta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorretta.ForeColor = System.Drawing.Color.Red;
            this.btnCorretta.Location = new System.Drawing.Point(446, 406);
            this.btnCorretta.Name = "btnCorretta";
            this.btnCorretta.Size = new System.Drawing.Size(80, 80);
            this.btnCorretta.TabIndex = 3;
            this.btnCorretta.Text = "🚫";
            this.btnCorretta.UseVisualStyleBackColor = true;
            this.btnCorretta.Click += new System.EventHandler(this.btnCorretta_Click);
            // 
            // tbTesto
            // 
            this.tbTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTesto.Location = new System.Drawing.Point(542, 159);
            this.tbTesto.Name = "tbTesto";
            this.tbTesto.Size = new System.Drawing.Size(202, 29);
            this.tbTesto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Testo:";
            // 
            // lvRisposte
            // 
            this.lvRisposte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvRisposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRisposte.FullRowSelect = true;
            this.lvRisposte.HideSelection = false;
            this.lvRisposte.Location = new System.Drawing.Point(49, 91);
            this.lvRisposte.Name = "lvRisposte";
            this.lvRisposte.Size = new System.Drawing.Size(377, 420);
            this.lvRisposte.TabIndex = 7;
            this.lvRisposte.UseCompatibleStateImageBehavior = false;
            this.lvRisposte.View = System.Windows.Forms.View.Details;
            this.lvRisposte.SelectedIndexChanged += new System.EventHandler(this.lvRisposte_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Testo";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Corretta";
            this.columnHeader3.Width = 137;
            // 
            // FrmRisposte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 558);
            this.Controls.Add(this.lvRisposte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTesto);
            this.Controls.Add(this.btnCorretta);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnAggiungi);
            this.Name = "FrmRisposte";
            this.Text = "FrmRisposte";
            this.Load += new System.EventHandler(this.FrmRisposte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnCorretta;
        private System.Windows.Forms.TextBox tbTesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvRisposte;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}