namespace elearning
{
    partial class FrmDiscipline
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
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.nudAnno = new System.Windows.Forms.NumericUpDown();
            this.lblAnno = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.lvDiscipline = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbCerca = new System.Windows.Forms.TextBox();
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.btnModifica = new System.Windows.Forms.Button();
            this.lblCerca = new System.Windows.Forms.Label();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnno)).BeginInit();
            this.pnlMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.Silver;
            this.pnlDetails.Controls.Add(this.lblNome);
            this.pnlDetails.Controls.Add(this.nudAnno);
            this.pnlDetails.Controls.Add(this.lblAnno);
            this.pnlDetails.Controls.Add(this.tbNome);
            this.pnlDetails.Controls.Add(this.btnSalva);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(588, 134);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(636, 529);
            this.pnlDetails.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 119);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(190, 64);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // nudAnno
            // 
            this.nudAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnno.Location = new System.Drawing.Point(412, 225);
            this.nudAnno.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudAnno.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nudAnno.Name = "nudAnno";
            this.nudAnno.Size = new System.Drawing.Size(179, 62);
            this.nudAnno.TabIndex = 15;
            this.nudAnno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAnno.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // lblAnno
            // 
            this.lblAnno.AutoSize = true;
            this.lblAnno.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnno.Location = new System.Drawing.Point(18, 234);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(388, 46);
            this.lblAnno.TabIndex = 12;
            this.lblAnno.Text = "Anno di inserimento:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(268, 123);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(323, 62);
            this.tbNome.TabIndex = 14;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(148, 340);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(236, 96);
            this.btnSalva.TabIndex = 13;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // lvDiscipline
            // 
            this.lvDiscipline.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNome,
            this.chAnno});
            this.lvDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDiscipline.FullRowSelect = true;
            this.lvDiscipline.HideSelection = false;
            this.lvDiscipline.Location = new System.Drawing.Point(12, 141);
            this.lvDiscipline.MultiSelect = false;
            this.lvDiscipline.Name = "lvDiscipline";
            this.lvDiscipline.Size = new System.Drawing.Size(448, 385);
            this.lvDiscipline.TabIndex = 7;
            this.lvDiscipline.UseCompatibleStateImageBehavior = false;
            this.lvDiscipline.View = System.Windows.Forms.View.Details;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 177;
            // 
            // chAnno
            // 
            this.chAnno.Text = "Anno";
            this.chAnno.Width = 190;
            // 
            // tbCerca
            // 
            this.tbCerca.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCerca.Location = new System.Drawing.Point(140, 59);
            this.tbCerca.Name = "tbCerca";
            this.tbCerca.Size = new System.Drawing.Size(278, 55);
            this.tbCerca.TabIndex = 9;
            // 
            // pnlMaster
            // 
            this.pnlMaster.BackColor = System.Drawing.Color.Silver;
            this.pnlMaster.Controls.Add(this.btnModifica);
            this.pnlMaster.Controls.Add(this.lblCerca);
            this.pnlMaster.Controls.Add(this.tbCerca);
            this.pnlMaster.Controls.Add(this.btnCerca);
            this.pnlMaster.Controls.Add(this.lvDiscipline);
            this.pnlMaster.Controls.Add(this.btnAggiungi);
            this.pnlMaster.Controls.Add(this.btnElimina);
            this.pnlMaster.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMaster.Location = new System.Drawing.Point(0, 134);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(588, 529);
            this.pnlMaster.TabIndex = 11;
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Image = global::elearning.Properties.Resources.iconaModifica1_50x50;
            this.btnModifica.Location = new System.Drawing.Point(466, 281);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 75);
            this.btnModifica.TabIndex = 17;
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lblCerca
            // 
            this.lblCerca.AutoSize = true;
            this.lblCerca.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerca.Location = new System.Drawing.Point(9, 64);
            this.lblCerca.Name = "lblCerca";
            this.lblCerca.Size = new System.Drawing.Size(125, 50);
            this.lblCerca.TabIndex = 16;
            this.lblCerca.Text = "Cerca";
            // 
            // btnCerca
            // 
            this.btnCerca.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerca.Image = global::elearning.Properties.Resources.iconaLenteRicerca1_50x50;
            this.btnCerca.Location = new System.Drawing.Point(466, 49);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 75);
            this.btnCerca.TabIndex = 10;
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Image = global::elearning.Properties.Resources.iconaNuovo1_50x50;
            this.btnAggiungi.Location = new System.Drawing.Point(466, 183);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 75);
            this.btnAggiungi.TabIndex = 6;
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Image = global::elearning.Properties.Resources.iconaCestino2_60x60_sfondoTrasparente;
            this.btnElimina.Location = new System.Drawing.Point(466, 376);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 75);
            this.btnElimina.TabIndex = 8;
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.BackColor = System.Drawing.Color.Teal;
            this.lblDiscipline.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscipline.ForeColor = System.Drawing.Color.White;
            this.lblDiscipline.Location = new System.Drawing.Point(0, 0);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(1224, 134);
            this.lblDiscipline.TabIndex = 12;
            this.lblDiscipline.Text = "Discipline";
            this.lblDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1224, 663);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlMaster);
            this.Controls.Add(this.lblDiscipline);
            this.Name = "FrmDiscipline";
            this.Text = "Discipline";
            this.Load += new System.EventHandler(this.FrmDiscipline_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnno)).EndInit();
            this.pnlMaster.ResumeLayout(false);
            this.pnlMaster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.ListView lvDiscipline;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox tbCerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chAnno;
        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.NumericUpDown nudAnno;
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label lblCerca;
        private System.Windows.Forms.Button btnModifica;
    }
}