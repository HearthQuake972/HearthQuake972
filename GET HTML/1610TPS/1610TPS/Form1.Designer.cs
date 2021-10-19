namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnalizza = new System.Windows.Forms.Button();
            this.txtSito = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.txtbho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Lime;
            this.btnReset.Location = new System.Drawing.Point(482, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 20);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "ESCI";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "SITE NAME       -->";
            // 
            // btnAnalizza
            // 
            this.btnAnalizza.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnalizza.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizza.ForeColor = System.Drawing.Color.Lime;
            this.btnAnalizza.Location = new System.Drawing.Point(367, 5);
            this.btnAnalizza.Name = "btnAnalizza";
            this.btnAnalizza.Size = new System.Drawing.Size(109, 20);
            this.btnAnalizza.TabIndex = 10;
            this.btnAnalizza.Text = "ANALIZZA";
            this.btnAnalizza.UseVisualStyleBackColor = false;
            this.btnAnalizza.Click += new System.EventHandler(this.btnAnalizza_Click);
            // 
            // txtSito
            // 
            this.txtSito.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSito.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSito.ForeColor = System.Drawing.Color.Lime;
            this.txtSito.Location = new System.Drawing.Point(151, 5);
            this.txtSito.Name = "txtSito";
            this.txtSito.Size = new System.Drawing.Size(210, 18);
            this.txtSito.TabIndex = 9;
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtmail.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.ForeColor = System.Drawing.Color.Lime;
            this.txtmail.Location = new System.Drawing.Point(151, 31);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(325, 18);
            this.txtmail.TabIndex = 15;
            this.txtmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmail.Location = new System.Drawing.Point(12, 31);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(133, 16);
            this.lblmail.TabIndex = 16;
            this.lblmail.Text = "NOTIFY EMAIL -->";
            // 
            // txtbho
            // 
            this.txtbho.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbho.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbho.ForeColor = System.Drawing.Color.Lime;
            this.txtbho.Location = new System.Drawing.Point(9, 68);
            this.txtbho.Multiline = true;
            this.txtbho.Name = "txtbho";
            this.txtbho.Size = new System.Drawing.Size(889, 628);
            this.txtbho.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(910, 708);
            this.Controls.Add(this.txtbho);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnalizza);
            this.Controls.Add(this.txtSito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnalizza;
        private System.Windows.Forms.TextBox txtSito;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtbho;

    }
}

