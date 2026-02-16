namespace elearning
{
    partial class FrmMenuStudente
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
            this.button3 = new System.Windows.Forms.Button();
            this.lvCorsi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLASSE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(317, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "VISUALIZZA IL CORSO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lvCorsi
            // 
            this.lvCorsi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.CLASSE,
            this.columnHeader2});
            this.lvCorsi.FullRowSelect = true;
            this.lvCorsi.HideSelection = false;
            this.lvCorsi.Location = new System.Drawing.Point(22, 12);
            this.lvCorsi.Name = "lvCorsi";
            this.lvCorsi.Size = new System.Drawing.Size(317, 207);
            this.lvCorsi.TabIndex = 4;
            this.lvCorsi.UseCompatibleStateImageBehavior = false;
            this.lvCorsi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MATERIA";
            this.columnHeader1.Width = 97;
            // 
            // CLASSE
            // 
            this.CLASSE.Text = "CLASSE";
            this.CLASSE.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "INSEGNANTE";
            this.columnHeader2.Width = 119;
            // 
            // FrmMenuStudente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(362, 291);
            this.Controls.Add(this.lvCorsi);
            this.Controls.Add(this.button3);
            this.Name = "FrmMenuStudente";
            this.Text = "FrmMenuStudente";
            this.Load += new System.EventHandler(this.FrmMenuStudente_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lvCorsi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader CLASSE;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}