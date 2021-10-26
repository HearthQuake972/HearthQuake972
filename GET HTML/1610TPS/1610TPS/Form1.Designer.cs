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
            this.txtGet = new System.Windows.Forms.TextBox();
            this.txtReply = new System.Windows.Forms.TextBox();
            this.txtUrl1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Lime;
            this.btnReset.Location = new System.Drawing.Point(11, 30);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(397, 32);
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
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "INSERT SITE LINK       -->";
            // 
            // btnAnalizza
            // 
            this.btnAnalizza.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnalizza.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizza.ForeColor = System.Drawing.Color.Lime;
            this.btnAnalizza.Location = new System.Drawing.Point(424, 30);
            this.btnAnalizza.Name = "btnAnalizza";
            this.btnAnalizza.Size = new System.Drawing.Size(396, 32);
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
            this.txtSito.Location = new System.Drawing.Point(309, 7);
            this.txtSito.Name = "txtSito";
            this.txtSito.Size = new System.Drawing.Size(221, 18);
            this.txtSito.TabIndex = 9;
            // 
            // txtGet
            // 
            this.txtGet.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtGet.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGet.ForeColor = System.Drawing.Color.Lime;
            this.txtGet.Location = new System.Drawing.Point(12, 68);
            this.txtGet.Multiline = true;
            this.txtGet.Name = "txtGet";
            this.txtGet.Size = new System.Drawing.Size(396, 628);
            this.txtGet.TabIndex = 17;
            // 
            // txtReply
            // 
            this.txtReply.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtReply.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReply.ForeColor = System.Drawing.Color.Lime;
            this.txtReply.Location = new System.Drawing.Point(424, 68);
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.Size = new System.Drawing.Size(396, 628);
            this.txtReply.TabIndex = 18;
            // 
            // txtUrl1
            // 
            this.txtUrl1.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtUrl1.Enabled = false;
            this.txtUrl1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl1.ForeColor = System.Drawing.Color.Lime;
            this.txtUrl1.Location = new System.Drawing.Point(197, 7);
            this.txtUrl1.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrl1.Name = "txtUrl1";
            this.txtUrl1.Size = new System.Drawing.Size(107, 18);
            this.txtUrl1.TabIndex = 19;
            this.txtUrl1.Text = "https://";
            this.txtUrl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(836, 708);
            this.Controls.Add(this.txtUrl1);
            this.Controls.Add(this.txtReply);
            this.Controls.Add(this.txtGet);
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
        private System.Windows.Forms.TextBox txtGet;
        private System.Windows.Forms.TextBox txtReply;
        private System.Windows.Forms.TextBox txtUrl1;

    }
}

