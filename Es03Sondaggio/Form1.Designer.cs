namespace Es03Sondaggio
{
    partial class Form1
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
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.chkPartTime = new System.Windows.Forms.CheckBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnInserire = new System.Windows.Forms.Button();
            this.lblDataNascita = new System.Windows.Forms.Label();
            this.txtDataNascita = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.chkDipendente = new System.Windows.Forms.CheckBox();
            this.btnRicercaAnno = new System.Windows.Forms.Button();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.grbDipendente = new System.Windows.Forms.GroupBox();
            this.btnContaPartTime = new System.Windows.Forms.Button();
            this.btnContaDipendenti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.grbDipendente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(133, 73);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(154, 24);
            this.cmbArea.TabIndex = 24;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(5, 73);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(112, 20);
            this.lblArea.TabIndex = 23;
            this.lblArea.Text = "Area di lavoro";
            // 
            // chkPartTime
            // 
            this.chkPartTime.AutoSize = true;
            this.chkPartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPartTime.Location = new System.Drawing.Point(9, 32);
            this.chkPartTime.Name = "chkPartTime";
            this.chkPartTime.Size = new System.Drawing.Size(121, 29);
            this.chkPartTime.TabIndex = 22;
            this.chkPartTime.Text = "PartTime";
            this.chkPartTime.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(349, -16);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(455, 722);
            this.dgvLista.TabIndex = 21;
            // 
            // btnInserire
            // 
            this.btnInserire.Location = new System.Drawing.Point(21, 320);
            this.btnInserire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserire.Name = "btnInserire";
            this.btnInserire.Size = new System.Drawing.Size(209, 46);
            this.btnInserire.TabIndex = 20;
            this.btnInserire.Text = "INSERIRE";
            this.btnInserire.UseVisualStyleBackColor = true;
            this.btnInserire.Click += new System.EventHandler(this.btnInserire_Click);
            // 
            // lblDataNascita
            // 
            this.lblDataNascita.AutoSize = true;
            this.lblDataNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascita.Location = new System.Drawing.Point(17, 110);
            this.lblDataNascita.Name = "lblDataNascita";
            this.lblDataNascita.Size = new System.Drawing.Size(74, 20);
            this.lblDataNascita.TabIndex = 19;
            this.lblDataNascita.Text = "NATO IL";
            // 
            // txtDataNascita
            // 
            this.txtDataNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascita.Location = new System.Drawing.Point(145, 106);
            this.txtDataNascita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataNascita.Name = "txtDataNascita";
            this.txtDataNascita.Size = new System.Drawing.Size(154, 26);
            this.txtDataNascita.TabIndex = 18;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(17, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 20);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "NOME";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(17, 12);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(97, 20);
            this.lblCognome.TabIndex = 16;
            this.lblCognome.Text = "COGNOME";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(145, 61);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 26);
            this.txtNome.TabIndex = 15;
            // 
            // txtCognome
            // 
            this.txtCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCognome.Location = new System.Drawing.Point(145, 12);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(154, 26);
            this.txtCognome.TabIndex = 14;
            // 
            // chkDipendente
            // 
            this.chkDipendente.AutoSize = true;
            this.chkDipendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDipendente.Location = new System.Drawing.Point(12, 147);
            this.chkDipendente.Name = "chkDipendente";
            this.chkDipendente.Size = new System.Drawing.Size(144, 29);
            this.chkDipendente.TabIndex = 25;
            this.chkDipendente.Text = "Dipendente";
            this.chkDipendente.UseVisualStyleBackColor = true;
            this.chkDipendente.CheckedChanged += new System.EventHandler(this.chkDipendente_CheckedChanged);
            // 
            // btnRicercaAnno
            // 
            this.btnRicercaAnno.Location = new System.Drawing.Point(21, 370);
            this.btnRicercaAnno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRicercaAnno.Name = "btnRicercaAnno";
            this.btnRicercaAnno.Size = new System.Drawing.Size(209, 56);
            this.btnRicercaAnno.TabIndex = 27;
            this.btnRicercaAnno.Text = "RICERCA PER ANNO";
            this.btnRicercaAnno.UseVisualStyleBackColor = true;
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(21, 430);
            this.btnRicerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(209, 56);
            this.btnRicerca.TabIndex = 26;
            this.btnRicerca.Text = "RICERCA";
            this.btnRicerca.UseVisualStyleBackColor = true;
            // 
            // grbDipendente
            // 
            this.grbDipendente.Controls.Add(this.cmbArea);
            this.grbDipendente.Controls.Add(this.chkPartTime);
            this.grbDipendente.Controls.Add(this.lblArea);
            this.grbDipendente.Location = new System.Drawing.Point(12, 182);
            this.grbDipendente.Name = "grbDipendente";
            this.grbDipendente.Size = new System.Drawing.Size(321, 122);
            this.grbDipendente.TabIndex = 28;
            this.grbDipendente.TabStop = false;
            this.grbDipendente.Visible = false;
            // 
            // btnContaPartTime
            // 
            this.btnContaPartTime.Location = new System.Drawing.Point(21, 490);
            this.btnContaPartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContaPartTime.Name = "btnContaPartTime";
            this.btnContaPartTime.Size = new System.Drawing.Size(209, 56);
            this.btnContaPartTime.TabIndex = 30;
            this.btnContaPartTime.Text = "CONTA PARTIME";
            this.btnContaPartTime.UseVisualStyleBackColor = true;
            this.btnContaPartTime.Click += new System.EventHandler(this.btnContaPartTime_Click);
            // 
            // btnContaDipendenti
            // 
            this.btnContaDipendenti.Location = new System.Drawing.Point(21, 550);
            this.btnContaDipendenti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContaDipendenti.Name = "btnContaDipendenti";
            this.btnContaDipendenti.Size = new System.Drawing.Size(209, 56);
            this.btnContaDipendenti.TabIndex = 29;
            this.btnContaDipendenti.Text = "CONTA DIPENDENTI";
            this.btnContaDipendenti.UseVisualStyleBackColor = true;
            this.btnContaDipendenti.Click += new System.EventHandler(this.btnContaDipendenti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.btnContaPartTime);
            this.Controls.Add(this.btnContaDipendenti);
            this.Controls.Add(this.grbDipendente);
            this.Controls.Add(this.btnRicercaAnno);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.chkDipendente);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnInserire);
            this.Controls.Add(this.lblDataNascita);
            this.Controls.Add(this.txtDataNascita);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCognome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.grbDipendente.ResumeLayout(false);
            this.grbDipendente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.CheckBox chkPartTime;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnInserire;
        private System.Windows.Forms.Label lblDataNascita;
        private System.Windows.Forms.TextBox txtDataNascita;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.CheckBox chkDipendente;
        private System.Windows.Forms.Button btnRicercaAnno;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.GroupBox grbDipendente;
        private System.Windows.Forms.Button btnContaPartTime;
        private System.Windows.Forms.Button btnContaDipendenti;
    }
}

