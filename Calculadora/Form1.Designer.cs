namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.N1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.Label();
            this.N2 = new System.Windows.Forms.Button();
            this.N3 = new System.Windows.Forms.Button();
            this.N4 = new System.Windows.Forms.Button();
            this.N5 = new System.Windows.Forms.Button();
            this.N6 = new System.Windows.Forms.Button();
            this.N7 = new System.Windows.Forms.Button();
            this.N8 = new System.Windows.Forms.Button();
            this.N9 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Resu = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.ope = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // N1
            // 
            this.N1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.N1.Location = new System.Drawing.Point(12, 369);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(46, 53);
            this.N1.TabIndex = 0;
            this.N1.Text = "1";
            this.N1.UseVisualStyleBackColor = true;
            this.N1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 112);
            this.button3.TabIndex = 2;
            this.button3.Text = "=";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(12, 12);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(51, 20);
            this.num.TabIndex = 4;
            this.num.Text = "Num1";
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(64, 369);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(48, 53);
            this.N2.TabIndex = 1;
            this.N2.Text = "2";
            this.N2.UseVisualStyleBackColor = true;
            this.N2.Click += new System.EventHandler(this.N2_Click);
            // 
            // N3
            // 
            this.N3.Location = new System.Drawing.Point(118, 369);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(48, 53);
            this.N3.TabIndex = 5;
            this.N3.Text = "3";
            this.N3.UseVisualStyleBackColor = true;
            this.N3.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // N4
            // 
            this.N4.Location = new System.Drawing.Point(10, 310);
            this.N4.Name = "N4";
            this.N4.Size = new System.Drawing.Size(48, 53);
            this.N4.TabIndex = 6;
            this.N4.Text = "4";
            this.N4.UseVisualStyleBackColor = true;
            this.N4.Click += new System.EventHandler(this.N4_Click);
            // 
            // N5
            // 
            this.N5.Location = new System.Drawing.Point(64, 310);
            this.N5.Name = "N5";
            this.N5.Size = new System.Drawing.Size(48, 53);
            this.N5.TabIndex = 7;
            this.N5.Text = "5";
            this.N5.UseVisualStyleBackColor = true;
            this.N5.Click += new System.EventHandler(this.N5_Click);
            // 
            // N6
            // 
            this.N6.Location = new System.Drawing.Point(118, 310);
            this.N6.Name = "N6";
            this.N6.Size = new System.Drawing.Size(48, 53);
            this.N6.TabIndex = 8;
            this.N6.Text = "6";
            this.N6.UseVisualStyleBackColor = true;
            this.N6.Click += new System.EventHandler(this.N6_Click);
            // 
            // N7
            // 
            this.N7.Location = new System.Drawing.Point(10, 251);
            this.N7.Name = "N7";
            this.N7.Size = new System.Drawing.Size(48, 53);
            this.N7.TabIndex = 9;
            this.N7.Text = "7";
            this.N7.UseVisualStyleBackColor = true;
            this.N7.Click += new System.EventHandler(this.N7_Click);
            // 
            // N8
            // 
            this.N8.Location = new System.Drawing.Point(64, 251);
            this.N8.Name = "N8";
            this.N8.Size = new System.Drawing.Size(48, 53);
            this.N8.TabIndex = 10;
            this.N8.Text = "8";
            this.N8.UseVisualStyleBackColor = true;
            this.N8.Click += new System.EventHandler(this.N8_Click);
            // 
            // N9
            // 
            this.N9.Location = new System.Drawing.Point(118, 251);
            this.N9.Name = "N9";
            this.N9.Size = new System.Drawing.Size(48, 53);
            this.N9.TabIndex = 11;
            this.N9.Text = "9";
            this.N9.UseVisualStyleBackColor = true;
            this.N9.Click += new System.EventHandler(this.N9_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(175, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 53);
            this.button9.TabIndex = 12;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(175, 184);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 53);
            this.button10.TabIndex = 13;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(118, 184);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(48, 53);
            this.button11.TabIndex = 14;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button12.Location = new System.Drawing.Point(64, 184);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(48, 53);
            this.button12.TabIndex = 15;
            this.button12.Text = "/";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Resu
            // 
            this.Resu.AutoSize = true;
            this.Resu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resu.Location = new System.Drawing.Point(157, 145);
            this.Resu.MaximumSize = new System.Drawing.Size(150, 50);
            this.Resu.Name = "Resu";
            this.Resu.Size = new System.Drawing.Size(51, 20);
            this.Resu.TabIndex = 16;
            this.Resu.Text = "label1";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(10, 12);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(213, 166);
            this.Result.TabIndex = 3;
            this.Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ope
            // 
            this.ope.AutoSize = true;
            this.ope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ope.Location = new System.Drawing.Point(12, 32);
            this.ope.Name = "ope";
            this.ope.Size = new System.Drawing.Size(36, 20);
            this.ope.TabIndex = 17;
            this.ope.Text = "ope";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(12, 52);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(51, 20);
            this.num2.TabIndex = 18;
            this.num2.Text = "Num2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(10, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 53);
            this.button1.TabIndex = 19;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.ope);
            this.Controls.Add(this.Resu);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.N9);
            this.Controls.Add(this.N8);
            this.Controls.Add(this.N7);
            this.Controls.Add(this.N6);
            this.Controls.Add(this.N5);
            this.Controls.Add(this.N4);
            this.Controls.Add(this.N3);
            this.Controls.Add(this.num);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button N1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Button N2;
        private System.Windows.Forms.Button N3;
        private System.Windows.Forms.Button N4;
        private System.Windows.Forms.Button N5;
        private System.Windows.Forms.Button N6;
        private System.Windows.Forms.Button N7;
        private System.Windows.Forms.Button N8;
        private System.Windows.Forms.Button N9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label Resu;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label ope;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Button button1;
    }
}

