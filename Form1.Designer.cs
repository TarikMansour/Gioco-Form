namespace mosca
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.prato = new System.Windows.Forms.Panel();
            this.insetto = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ragno = new System.Windows.Forms.RadioButton();
            this.Ape = new System.Windows.Forms.RadioButton();
            this.Mosca = new System.Windows.Forms.RadioButton();
            this.farfalla = new System.Windows.Forms.RadioButton();
            this.punteggio = new System.Windows.Forms.TextBox();
            this.errori = new System.Windows.Forms.TextBox();
            this.level = new System.Windows.Forms.TextBox();
            this.prato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insetto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prato
            // 
            this.prato.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prato.BackgroundImage")));
            this.prato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prato.Controls.Add(this.insetto);
            this.prato.Location = new System.Drawing.Point(12, 12);
            this.prato.Name = "prato";
            this.prato.Size = new System.Drawing.Size(843, 410);
            this.prato.TabIndex = 0;
            this.prato.Click += new System.EventHandler(this.prato_Click);
            this.prato.Paint += new System.Windows.Forms.PaintEventHandler(this.prato_Paint);
            this.prato.DoubleClick += new System.EventHandler(this.prato_Click);
            // 
            // insetto
            // 
            this.insetto.BackColor = System.Drawing.Color.Transparent;
            this.insetto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insetto.Location = new System.Drawing.Point(599, 180);
            this.insetto.Name = "insetto";
            this.insetto.Size = new System.Drawing.Size(148, 120);
            this.insetto.TabIndex = 0;
            this.insetto.TabStop = false;
            this.insetto.Click += new System.EventHandler(this.insetto_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(358, 429);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.level);
            this.groupBox1.Controls.Add(this.Ragno);
            this.groupBox1.Controls.Add(this.Ape);
            this.groupBox1.Controls.Add(this.Mosca);
            this.groupBox1.Controls.Add(this.farfalla);
            this.groupBox1.Location = new System.Drawing.Point(878, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 303);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Ragno
            // 
            this.Ragno.AutoSize = true;
            this.Ragno.Location = new System.Drawing.Point(17, 167);
            this.Ragno.Name = "Ragno";
            this.Ragno.Size = new System.Drawing.Size(57, 17);
            this.Ragno.TabIndex = 3;
            this.Ragno.TabStop = true;
            this.Ragno.Text = "Ragno";
            this.Ragno.UseVisualStyleBackColor = true;
            this.Ragno.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Ape
            // 
            this.Ape.AutoSize = true;
            this.Ape.Location = new System.Drawing.Point(17, 137);
            this.Ape.Name = "Ape";
            this.Ape.Size = new System.Drawing.Size(44, 17);
            this.Ape.TabIndex = 2;
            this.Ape.TabStop = true;
            this.Ape.Text = "Ape";
            this.Ape.UseVisualStyleBackColor = true;
            this.Ape.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Mosca
            // 
            this.Mosca.AutoSize = true;
            this.Mosca.Location = new System.Drawing.Point(17, 102);
            this.Mosca.Name = "Mosca";
            this.Mosca.Size = new System.Drawing.Size(57, 17);
            this.Mosca.TabIndex = 1;
            this.Mosca.TabStop = true;
            this.Mosca.Text = "Mosca";
            this.Mosca.UseVisualStyleBackColor = true;
            this.Mosca.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // farfalla
            // 
            this.farfalla.AutoSize = true;
            this.farfalla.Location = new System.Drawing.Point(17, 66);
            this.farfalla.Name = "farfalla";
            this.farfalla.Size = new System.Drawing.Size(59, 17);
            this.farfalla.TabIndex = 0;
            this.farfalla.TabStop = true;
            this.farfalla.Text = "Farfalla";
            this.farfalla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.farfalla.UseVisualStyleBackColor = true;
            this.farfalla.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // punteggio
            // 
            this.punteggio.Location = new System.Drawing.Point(895, 23);
            this.punteggio.Name = "punteggio";
            this.punteggio.Size = new System.Drawing.Size(100, 20);
            this.punteggio.TabIndex = 3;
            this.punteggio.Text = "Punteggio = 0";
            // 
            // errori
            // 
            this.errori.Location = new System.Drawing.Point(1001, 23);
            this.errori.Name = "errori";
            this.errori.Size = new System.Drawing.Size(100, 20);
            this.errori.TabIndex = 4;
            this.errori.Text = "Errori = 0";
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(7, 20);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(100, 20);
            this.level.TabIndex = 4;
            this.level.Text = "Level: Easy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 464);
            this.Controls.Add(this.errori);
            this.Controls.Add(this.punteggio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.prato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.prato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.insetto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel prato;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox insetto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ape;
        private System.Windows.Forms.RadioButton Mosca;
        private System.Windows.Forms.RadioButton farfalla;
        private System.Windows.Forms.TextBox punteggio;
        private System.Windows.Forms.TextBox errori;
        private System.Windows.Forms.RadioButton Ragno;
        private System.Windows.Forms.TextBox level;
    }
}

