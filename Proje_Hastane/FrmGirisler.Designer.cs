namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btnsekretergirisi = new System.Windows.Forms.Button();
            this.btnhastagirisi = new System.Windows.Forms.Button();
            this.btndoktorgirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsekretergirisi
            // 
            this.btnsekretergirisi.Location = new System.Drawing.Point(519, 127);
            this.btnsekretergirisi.Name = "btnsekretergirisi";
            this.btnsekretergirisi.Size = new System.Drawing.Size(194, 119);
            this.btnsekretergirisi.TabIndex = 0;
            this.btnsekretergirisi.Text = "Sekreter Giriş";
            this.btnsekretergirisi.UseVisualStyleBackColor = true;
            this.btnsekretergirisi.Click += new System.EventHandler(this.btnsekretergirisi_Click);
            // 
            // btnhastagirisi
            // 
            this.btnhastagirisi.Location = new System.Drawing.Point(58, 127);
            this.btnhastagirisi.Name = "btnhastagirisi";
            this.btnhastagirisi.Size = new System.Drawing.Size(195, 119);
            this.btnhastagirisi.TabIndex = 1;
            this.btnhastagirisi.Text = "Hasta Giriş";
            this.btnhastagirisi.UseVisualStyleBackColor = true;
            this.btnhastagirisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndoktorgirisi
            // 
            this.btndoktorgirisi.Location = new System.Drawing.Point(287, 127);
            this.btndoktorgirisi.Name = "btndoktorgirisi";
            this.btndoktorgirisi.Size = new System.Drawing.Size(195, 119);
            this.btndoktorgirisi.TabIndex = 2;
            this.btndoktorgirisi.Text = "Doktor Giriş";
            this.btndoktorgirisi.UseVisualStyleBackColor = true;
            this.btndoktorgirisi.Click += new System.EventHandler(this.btndoktorgirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hastane Program V1";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndoktorgirisi);
            this.Controls.Add(this.btnhastagirisi);
            this.Controls.Add(this.btnsekretergirisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Hastane Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsekretergirisi;
        private System.Windows.Forms.Button btnhastagirisi;
        private System.Windows.Forms.Button btndoktorgirisi;
        private System.Windows.Forms.Label label1;
    }
}

