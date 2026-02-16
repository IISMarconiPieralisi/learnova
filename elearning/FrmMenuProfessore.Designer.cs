namespace elearning
{
    partial class FrmMenuProfessore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVisualizzaCorso = new System.Windows.Forms.Button();
            this.lvCorsi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDocente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblDocente);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 537);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnVisualizzaCorso);
            this.panel2.Controls.Add(this.lvCorsi);
            this.panel2.Location = new System.Drawing.Point(3, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 570);
            this.panel2.TabIndex = 4;
            // 
            // btnVisualizzaCorso
            // 
            this.btnVisualizzaCorso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizzaCorso.Location = new System.Drawing.Point(114, 318);
            this.btnVisualizzaCorso.Name = "btnVisualizzaCorso";
            this.btnVisualizzaCorso.Size = new System.Drawing.Size(178, 46);
            this.btnVisualizzaCorso.TabIndex = 2;
            this.btnVisualizzaCorso.Text = "VisualizzaCorso";
            this.btnVisualizzaCorso.UseVisualStyleBackColor = true;
            this.btnVisualizzaCorso.Click += new System.EventHandler(this.btnVisualizzaCorso_Click);
            // 
            // lvCorsi
            // 
            this.lvCorsi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCorsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCorsi.FullRowSelect = true;
            this.lvCorsi.HideSelection = false;
            this.lvCorsi.Location = new System.Drawing.Point(10, 30);
            this.lvCorsi.Name = "lvCorsi";
            this.lvCorsi.Size = new System.Drawing.Size(392, 282);
            this.lvCorsi.TabIndex = 0;
            this.lvCorsi.UseCompatibleStateImageBehavior = false;
            this.lvCorsi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Classe";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Disciplina";
            this.columnHeader2.Width = 209;
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocente.Location = new System.Drawing.Point(10, 7);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(153, 39);
            this.lblDocente.TabIndex = 7;
            this.lblDocente.Text = "Docente";
            // 
            // FrmMenuProfessore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(425, 496);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FrmMenuProfessore";
            this.Text = "FrmMenuProfessore";
            this.Load += new System.EventHandler(this.FrmMenuProfessore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvCorsi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnVisualizzaCorso;
    }
}