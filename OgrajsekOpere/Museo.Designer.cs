namespace Opere {
    partial class Form1 {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbt_arazzo = new System.Windows.Forms.RadioButton();
            this.rbt_scultura = new System.Windows.Forms.RadioButton();
            this.rbt_qadro = new System.Windows.Forms.RadioButton();
            this.txb_anno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_autore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_titolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerca = new System.Windows.Forms.Button();
            this.txb_autore_cerca = new System.Windows.Forms.TextBox();
            this.txb_codice_modifica = new System.Windows.Forms.TextBox();
            this.btn_modifica = new System.Windows.Forms.Button();
            this.btn_elimina = new System.Windows.Forms.Button();
            this.txb_elimina = new System.Windows.Forms.TextBox();
            this.btn_visualizza = new System.Windows.Forms.Button();
            this.grid_opere = new System.Windows.Forms.DataGridView();
            this.Posizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_opere)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_aggiungi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbt_arazzo);
            this.groupBox1.Controls.Add(this.rbt_scultura);
            this.groupBox1.Controls.Add(this.rbt_qadro);
            this.groupBox1.Controls.Add(this.txb_anno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_autore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_titolo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci";
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(15, 168);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(136, 23);
            this.btn_aggiungi.TabIndex = 10;
            this.btn_aggiungi.Text = "Aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // rbt_arazzo
            // 
            this.rbt_arazzo.AutoSize = true;
            this.rbt_arazzo.Location = new System.Drawing.Point(51, 149);
            this.rbt_arazzo.Name = "rbt_arazzo";
            this.rbt_arazzo.Size = new System.Drawing.Size(57, 17);
            this.rbt_arazzo.TabIndex = 8;
            this.rbt_arazzo.TabStop = true;
            this.rbt_arazzo.Text = "Arazzo";
            this.rbt_arazzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbt_arazzo.UseVisualStyleBackColor = true;
            // 
            // rbt_scultura
            // 
            this.rbt_scultura.AutoSize = true;
            this.rbt_scultura.Location = new System.Drawing.Point(51, 125);
            this.rbt_scultura.Name = "rbt_scultura";
            this.rbt_scultura.Size = new System.Drawing.Size(64, 17);
            this.rbt_scultura.TabIndex = 7;
            this.rbt_scultura.TabStop = true;
            this.rbt_scultura.Text = "Scultura";
            this.rbt_scultura.UseVisualStyleBackColor = true;
            // 
            // rbt_qadro
            // 
            this.rbt_qadro.AutoSize = true;
            this.rbt_qadro.Location = new System.Drawing.Point(51, 102);
            this.rbt_qadro.Name = "rbt_qadro";
            this.rbt_qadro.Size = new System.Drawing.Size(60, 17);
            this.rbt_qadro.TabIndex = 6;
            this.rbt_qadro.TabStop = true;
            this.rbt_qadro.Text = "Quadro";
            this.rbt_qadro.UseVisualStyleBackColor = true;
            // 
            // txb_anno
            // 
            this.txb_anno.Location = new System.Drawing.Point(46, 70);
            this.txb_anno.Name = "txb_anno";
            this.txb_anno.Size = new System.Drawing.Size(100, 20);
            this.txb_anno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Anno";
            // 
            // txb_autore
            // 
            this.txb_autore.Location = new System.Drawing.Point(46, 43);
            this.txb_autore.Name = "txb_autore";
            this.txb_autore.Size = new System.Drawing.Size(100, 20);
            this.txb_autore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autore";
            // 
            // txb_titolo
            // 
            this.txb_titolo.Location = new System.Drawing.Point(46, 17);
            this.txb_titolo.Name = "txb_titolo";
            this.txb_titolo.Size = new System.Drawing.Size(100, 20);
            this.txb_titolo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo";
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(284, 28);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(112, 23);
            this.btn_cerca.TabIndex = 1;
            this.btn_cerca.Text = "Cerca Opere Autore";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // txb_autore_cerca
            // 
            this.txb_autore_cerca.Location = new System.Drawing.Point(177, 30);
            this.txb_autore_cerca.Name = "txb_autore_cerca";
            this.txb_autore_cerca.Size = new System.Drawing.Size(100, 20);
            this.txb_autore_cerca.TabIndex = 2;
            // 
            // txb_codice_modifica
            // 
            this.txb_codice_modifica.Location = new System.Drawing.Point(177, 56);
            this.txb_codice_modifica.Name = "txb_codice_modifica";
            this.txb_codice_modifica.Size = new System.Drawing.Size(100, 20);
            this.txb_codice_modifica.TabIndex = 3;
            // 
            // btn_modifica
            // 
            this.btn_modifica.Location = new System.Drawing.Point(284, 57);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.Size = new System.Drawing.Size(112, 23);
            this.btn_modifica.TabIndex = 4;
            this.btn_modifica.Text = "Modifica";
            this.btn_modifica.UseVisualStyleBackColor = true;
            this.btn_modifica.Click += new System.EventHandler(this.btn_modifica_Click);
            // 
            // btn_elimina
            // 
            this.btn_elimina.Location = new System.Drawing.Point(284, 83);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.Size = new System.Drawing.Size(112, 23);
            this.btn_elimina.TabIndex = 5;
            this.btn_elimina.Text = "Elimina";
            this.btn_elimina.UseVisualStyleBackColor = true;
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // txb_elimina
            // 
            this.txb_elimina.Location = new System.Drawing.Point(177, 83);
            this.txb_elimina.Name = "txb_elimina";
            this.txb_elimina.Size = new System.Drawing.Size(100, 20);
            this.txb_elimina.TabIndex = 6;
            // 
            // btn_visualizza
            // 
            this.btn_visualizza.Location = new System.Drawing.Point(178, 115);
            this.btn_visualizza.Name = "btn_visualizza";
            this.btn_visualizza.Size = new System.Drawing.Size(218, 23);
            this.btn_visualizza.TabIndex = 7;
            this.btn_visualizza.Text = "Visualizza";
            this.btn_visualizza.UseVisualStyleBackColor = true;
            this.btn_visualizza.Click += new System.EventHandler(this.btn_visualizza_Click);
            // 
            // grid_opere
            // 
            this.grid_opere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posizione,
            this.Autore,
            this.Titolo,
            this.Anno,
            this.Tipo});
            this.grid_opere.Location = new System.Drawing.Point(13, 220);
            this.grid_opere.Name = "grid_opere";
            this.grid_opere.Size = new System.Drawing.Size(388, 185);
            this.grid_opere.TabIndex = 8;
            // 
            // Posizione
            // 
            this.Posizione.HeaderText = "Posizione";
            this.Posizione.Name = "Posizione";
            // 
            // Autore
            // 
            this.Autore.HeaderText = "Autore";
            this.Autore.Name = "Autore";
            // 
            // Titolo
            // 
            this.Titolo.HeaderText = "Titolo";
            this.Titolo.Name = "Titolo";
            // 
            // Anno
            // 
            this.Anno.HeaderText = "Anno";
            this.Anno.Name = "Anno";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.grid_opere);
            this.Controls.Add(this.btn_visualizza);
            this.Controls.Add(this.txb_elimina);
            this.Controls.Add(this.btn_elimina);
            this.Controls.Add(this.btn_modifica);
            this.Controls.Add(this.txb_codice_modifica);
            this.Controls.Add(this.txb_autore_cerca);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Museo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_opere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_titolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_autore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_anno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbt_arazzo;
        private System.Windows.Forms.RadioButton rbt_scultura;
        private System.Windows.Forms.RadioButton rbt_qadro;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.Button btn_cerca;
        private System.Windows.Forms.TextBox txb_autore_cerca;
        private System.Windows.Forms.TextBox txb_codice_modifica;
        private System.Windows.Forms.Button btn_modifica;
        private System.Windows.Forms.Button btn_elimina;
        private System.Windows.Forms.TextBox txb_elimina;
        private System.Windows.Forms.Button btn_visualizza;
        private System.Windows.Forms.DataGridView grid_opere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}

