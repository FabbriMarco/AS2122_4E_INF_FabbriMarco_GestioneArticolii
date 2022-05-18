namespace AS2122_4E_INF_FabbriMarco_GestioneArticolii
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblUnitadiMisura = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblArticoli = new System.Windows.Forms.Label();
            this.cmbUnitadiMisura = new System.Windows.Forms.ComboBox();
            this.cmbVisualizza = new System.Windows.Forms.ComboBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrezzo);
            this.groupBox1.Controls.Add(this.txtCodice);
            this.groupBox1.Controls.Add(this.btnAggiungi);
            this.groupBox1.Controls.Add(this.txtDescrizione);
            this.groupBox1.Controls.Add(this.lblPrezzo);
            this.groupBox1.Controls.Add(this.lblUnitadiMisura);
            this.groupBox1.Controls.Add(this.lblDescrizione);
            this.groupBox1.Controls.Add(this.lblCodice);
            this.groupBox1.Controls.Add(this.cmbUnitadiMisura);
            this.groupBox1.Location = new System.Drawing.Point(52, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(6, 43);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(44, 15);
            this.lblCodice.TabIndex = 0;
            this.lblCodice.Text = "Codice";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(6, 78);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(67, 15);
            this.lblDescrizione.TabIndex = 1;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblUnitadiMisura
            // 
            this.lblUnitadiMisura.AutoSize = true;
            this.lblUnitadiMisura.Location = new System.Drawing.Point(6, 121);
            this.lblUnitadiMisura.Name = "lblUnitadiMisura";
            this.lblUnitadiMisura.Size = new System.Drawing.Size(81, 15);
            this.lblUnitadiMisura.TabIndex = 2;
            this.lblUnitadiMisura.Text = "UnitadiMisura";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(6, 162);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(41, 15);
            this.lblPrezzo.TabIndex = 3;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(52, 396);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(59, 15);
            this.lblArticoli.TabIndex = 1;
            this.lblArticoli.Text = "Articoli(0)";
            // 
            // cmbUnitadiMisura
            // 
            this.cmbUnitadiMisura.FormattingEnabled = true;
            this.cmbUnitadiMisura.Location = new System.Drawing.Point(93, 113);
            this.cmbUnitadiMisura.Name = "cmbUnitadiMisura";
            this.cmbUnitadiMisura.Size = new System.Drawing.Size(121, 23);
            this.cmbUnitadiMisura.TabIndex = 2;
            // 
            // cmbVisualizza
            // 
            this.cmbVisualizza.FormattingEnabled = true;
            this.cmbVisualizza.Location = new System.Drawing.Point(496, 32);
            this.cmbVisualizza.Name = "cmbVisualizza";
            this.cmbVisualizza.Size = new System.Drawing.Size(165, 23);
            this.cmbVisualizza.TabIndex = 3;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(56, 223);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(185, 62);
            this.btnAggiungi.TabIndex = 4;
            this.btnAggiungi.Text = "Aggiungi/modifica articolo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(496, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 334);
            this.listBox1.TabIndex = 6;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(78, 75);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(100, 23);
            this.txtDescrizione.TabIndex = 7;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(76, 35);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 23);
            this.txtCodice.TabIndex = 8;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(78, 154);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 23);
            this.txtPrezzo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbVisualizza);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPrezzo;
        private TextBox txtCodice;
        private Button btnAggiungi;
        private TextBox txtDescrizione;
        private Label lblPrezzo;
        private Label lblUnitadiMisura;
        private Label lblDescrizione;
        private Label lblCodice;
        private ComboBox cmbUnitadiMisura;
        private Label lblArticoli;
        private ComboBox cmbVisualizza;
        private Button button2;
        private ListBox listBox1;
    }
}