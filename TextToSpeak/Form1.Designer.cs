namespace TextToSpeak
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
            this.btnOku = new System.Windows.Forms.Button();
            this.btnDuraklat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnDevam = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(77, 301);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(75, 21);
            this.btnOku.TabIndex = 0;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnDuraklat
            // 
            this.btnDuraklat.Location = new System.Drawing.Point(402, 301);
            this.btnDuraklat.Name = "btnDuraklat";
            this.btnDuraklat.Size = new System.Drawing.Size(75, 21);
            this.btnDuraklat.TabIndex = 2;
            this.btnDuraklat.Text = "Duraklat";
            this.btnDuraklat.UseVisualStyleBackColor = true;
            this.btnDuraklat.Click += new System.EventHandler(this.btnDuraklat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(548, 301);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(75, 21);
            this.btnDurdur.TabIndex = 3;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(255, 301);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(75, 21);
            this.btnDevam.TabIndex = 1;
            this.btnDevam.Text = "Devam Ettir";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(704, 230);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnDuraklat);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnOku);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ali Can Yücel Metin Okuma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Button btnDuraklat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

