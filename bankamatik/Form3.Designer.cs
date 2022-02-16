
namespace bankamatik
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAD3 = new System.Windows.Forms.TextBox();
            this.textBoxSoyad2 = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextTc = new System.Windows.Forms.MaskedTextBox();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.maskedTextBoxHesap = new System.Windows.Forms.MaskedTextBox();
            this.btnKydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC Kimlik :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(44, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hesap  No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad :";
            // 
            // textBoxAD3
            // 
            this.textBoxAD3.Location = new System.Drawing.Point(95, 49);
            this.textBoxAD3.Name = "textBoxAD3";
            this.textBoxAD3.Size = new System.Drawing.Size(145, 20);
            this.textBoxAD3.TabIndex = 1;
            // 
            // textBoxSoyad2
            // 
            this.textBoxSoyad2.Location = new System.Drawing.Point(95, 79);
            this.textBoxSoyad2.Name = "textBoxSoyad2";
            this.textBoxSoyad2.Size = new System.Drawing.Size(145, 20);
            this.textBoxSoyad2.TabIndex = 2;
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(96, 145);
            this.maskedTextBoxTel.Mask = "(999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(144, 20);
            this.maskedTextBoxTel.TabIndex = 4;
            // 
            // maskedTextTc
            // 
            this.maskedTextTc.Location = new System.Drawing.Point(96, 111);
            this.maskedTextTc.Mask = "00000000000";
            this.maskedTextTc.Name = "maskedTextTc";
            this.maskedTextTc.Size = new System.Drawing.Size(144, 20);
            this.maskedTextTc.TabIndex = 3;
            this.maskedTextTc.ValidatingType = typeof(int);
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(96, 214);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(144, 20);
            this.textSifre.TabIndex = 6;
            // 
            // maskedTextBoxHesap
            // 
            this.maskedTextBoxHesap.Location = new System.Drawing.Point(96, 182);
            this.maskedTextBoxHesap.Mask = "000000";
            this.maskedTextBoxHesap.Name = "maskedTextBoxHesap";
            this.maskedTextBoxHesap.Size = new System.Drawing.Size(144, 20);
            this.maskedTextBoxHesap.TabIndex = 5;
            this.maskedTextBoxHesap.ValidatingType = typeof(int);
            // 
            // btnKydet
            // 
            this.btnKydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKydet.Location = new System.Drawing.Point(15, 263);
            this.btnKydet.Name = "btnKydet";
            this.btnKydet.Size = new System.Drawing.Size(198, 30);
            this.btnKydet.TabIndex = 7;
            this.btnKydet.Text = "Kaydet";
            this.btnKydet.UseVisualStyleBackColor = true;
            this.btnKydet.Click += new System.EventHandler(this.btnKydet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKydet);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.maskedTextTc);
            this.Controls.Add(this.maskedTextBoxHesap);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.textBoxSoyad2);
            this.Controls.Add(this.textBoxAD3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAD3;
        private System.Windows.Forms.TextBox textBoxSoyad2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.MaskedTextBox maskedTextTc;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHesap;
        private System.Windows.Forms.Button btnKydet;
        private System.Windows.Forms.Button button2;
    }
}