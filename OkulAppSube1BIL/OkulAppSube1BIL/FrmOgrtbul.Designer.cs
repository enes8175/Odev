namespace OkulAppSube1BIL
{
    partial class FrmOgrtbul
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
            this.Bul = new System.Windows.Forms.Button();
            this.txtTckimlik = new System.Windows.Forms.TextBox();
            this.Tc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bul
            // 
            this.Bul.Location = new System.Drawing.Point(389, 171);
            this.Bul.Name = "Bul";
            this.Bul.Size = new System.Drawing.Size(75, 23);
            this.Bul.TabIndex = 0;
            this.Bul.Text = "Bul";
            this.Bul.UseVisualStyleBackColor = true;
            this.Bul.Click += new System.EventHandler(this.Bul_Click);
            // 
            // txtTckimlik
            // 
            this.txtTckimlik.Location = new System.Drawing.Point(371, 118);
            this.txtTckimlik.Name = "txtTckimlik";
            this.txtTckimlik.Size = new System.Drawing.Size(100, 20);
            this.txtTckimlik.TabIndex = 1;
            // 
            // Tc
            // 
            this.Tc.AutoSize = true;
            this.Tc.Location = new System.Drawing.Point(402, 70);
            this.Tc.Name = "Tc";
            this.Tc.Size = new System.Drawing.Size(69, 13);
            this.Tc.TabIndex = 2;
            this.Tc.Text = "Öğretmen Tc";
            // 
            // FrmOgrtbul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tc);
            this.Controls.Add(this.txtTckimlik);
            this.Controls.Add(this.Bul);
            this.Name = "FrmOgrtbul";
            this.Text = "FrmOgrtbul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bul;
        private System.Windows.Forms.TextBox txtTckimlik;
        private System.Windows.Forms.Label Tc;
    }
}