namespace bolum2_if_else2
{
    partial class Form1
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
            this.btnTıkla = new System.Windows.Forms.Button();
            this.cbSarı = new System.Windows.Forms.CheckBox();
            this.cbKırmız = new System.Windows.Forms.CheckBox();
            this.lblYaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTıkla
            // 
            this.btnTıkla.Location = new System.Drawing.Point(23, 26);
            this.btnTıkla.Name = "btnTıkla";
            this.btnTıkla.Size = new System.Drawing.Size(108, 32);
            this.btnTıkla.TabIndex = 0;
            this.btnTıkla.Text = "button1";
            this.btnTıkla.UseVisualStyleBackColor = true;
            this.btnTıkla.Click += new System.EventHandler(this.btnTıkla_Click);
            // 
            // cbSarı
            // 
            this.cbSarı.AutoSize = true;
            this.cbSarı.Location = new System.Drawing.Point(23, 83);
            this.cbSarı.Name = "cbSarı";
            this.cbSarı.Size = new System.Drawing.Size(51, 17);
            this.cbSarı.TabIndex = 1;
            this.cbSarı.Text = "SARI";
            this.cbSarı.UseVisualStyleBackColor = true;
            // 
            // cbKırmız
            // 
            this.cbKırmız.AutoSize = true;
            this.cbKırmız.Location = new System.Drawing.Point(23, 120);
            this.cbKırmız.Name = "cbKırmız";
            this.cbKırmız.Size = new System.Drawing.Size(66, 17);
            this.cbKırmız.TabIndex = 2;
            this.cbKırmız.Text = "KIRMIZI";
            this.cbKırmız.UseVisualStyleBackColor = true;
            // 
            // lblYaz
            // 
            this.lblYaz.AutoSize = true;
            this.lblYaz.Location = new System.Drawing.Point(20, 164);
            this.lblYaz.Name = "lblYaz";
            this.lblYaz.Size = new System.Drawing.Size(55, 13);
            this.lblYaz.TabIndex = 3;
            this.lblYaz.Text = "________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 237);
            this.Controls.Add(this.lblYaz);
            this.Controls.Add(this.cbKırmız);
            this.Controls.Add(this.cbSarı);
            this.Controls.Add(this.btnTıkla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTıkla;
        private System.Windows.Forms.CheckBox cbSarı;
        private System.Windows.Forms.CheckBox cbKırmız;
        private System.Windows.Forms.Label lblYaz;
    }
}

