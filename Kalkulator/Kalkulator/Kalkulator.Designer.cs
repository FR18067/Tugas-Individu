namespace Kalkulator
{
    partial class Kalkulator
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
            this.txtMain = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSamadengan = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnKoma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMain
            // 
            this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.txtMain.Location = new System.Drawing.Point(2, 26);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(203, 55);
            this.txtMain.TabIndex = 0;
            this.txtMain.Text = "0";
            this.txtMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(104, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.buttonClear_click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(155, 83);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(50, 50);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Del";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBagi.Location = new System.Drawing.Point(2, 83);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(50, 50);
            this.btnBagi.TabIndex = 4;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.buttonOperator_click);
            // 
            // btnKali
            // 
            this.btnKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnKali.Location = new System.Drawing.Point(53, 83);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(50, 50);
            this.btnKali.TabIndex = 5;
            this.btnKali.Text = "*";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.buttonOperator_click);
            // 
            // btnKurang
            // 
            this.btnKurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKurang.Location = new System.Drawing.Point(155, 133);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(50, 50);
            this.btnKurang.TabIndex = 6;
            this.btnKurang.Text = "−";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.buttonOperator_click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTambah.Location = new System.Drawing.Point(155, 183);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(50, 50);
            this.btnTambah.TabIndex = 7;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.buttonOperator_click);
            // 
            // btnSamadengan
            // 
            this.btnSamadengan.BackColor = System.Drawing.SystemColors.Control;
            this.btnSamadengan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSamadengan.Location = new System.Drawing.Point(155, 233);
            this.btnSamadengan.Name = "btnSamadengan";
            this.btnSamadengan.Size = new System.Drawing.Size(50, 100);
            this.btnSamadengan.TabIndex = 8;
            this.btnSamadengan.Text = "=";
            this.btnSamadengan.UseVisualStyleBackColor = false;
            this.btnSamadengan.Click += new System.EventHandler(this.buttonHasil_click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn9.Location = new System.Drawing.Point(104, 133);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn8.Location = new System.Drawing.Point(53, 133);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn7.Location = new System.Drawing.Point(2, 133);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn6.Location = new System.Drawing.Point(104, 183);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn5.Location = new System.Drawing.Point(53, 183);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn4.Location = new System.Drawing.Point(2, 183);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn3.Location = new System.Drawing.Point(104, 233);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn2.Location = new System.Drawing.Point(53, 233);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn1.Location = new System.Drawing.Point(2, 233);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btnKoma
            // 
            this.btnKoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKoma.Location = new System.Drawing.Point(104, 283);
            this.btnKoma.Name = "btnKoma";
            this.btnKoma.Size = new System.Drawing.Size(50, 50);
            this.btnKoma.TabIndex = 20;
            this.btnKoma.Text = ".";
            this.btnKoma.UseVisualStyleBackColor = true;
            this.btnKoma.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn0.Location = new System.Drawing.Point(53, 283);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.buttonAngka_click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMinus.Location = new System.Drawing.Point(2, 283);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 50);
            this.btnMinus.TabIndex = 18;
            this.btnMinus.Text = "-/+";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // txtSub
            // 
            this.txtSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtSub.Location = new System.Drawing.Point(2, 0);
            this.txtSub.Multiline = true;
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(203, 27);
            this.txtSub.TabIndex = 21;
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 335);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.btnKoma);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSamadengan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSamadengan;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnKoma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.TextBox txtSub;
    }
}

