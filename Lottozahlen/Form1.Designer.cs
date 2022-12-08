namespace Lottozahlen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textYourTip = new System.Windows.Forms.Label();
            this.genNumbers = new System.Windows.Forms.Button();
            this.tip1 = new System.Windows.Forms.TextBox();
            this.tip2 = new System.Windows.Forms.TextBox();
            this.tip3 = new System.Windows.Forms.TextBox();
            this.tip6 = new System.Windows.Forms.TextBox();
            this.tip5 = new System.Windows.Forms.TextBox();
            this.tip4 = new System.Windows.Forms.TextBox();
            this.lottoNumber6 = new System.Windows.Forms.TextBox();
            this.lottoNumber5 = new System.Windows.Forms.TextBox();
            this.lottoNumber4 = new System.Windows.Forms.TextBox();
            this.lottoNumber3 = new System.Windows.Forms.TextBox();
            this.lottoNumber2 = new System.Windows.Forms.TextBox();
            this.lottoNumber1 = new System.Windows.Forms.TextBox();
            this.textLottoNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textYourTip
            // 
            this.textYourTip.BackColor = System.Drawing.Color.Yellow;
            this.textYourTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textYourTip.Location = new System.Drawing.Point(276, 357);
            this.textYourTip.Name = "textYourTip";
            this.textYourTip.Size = new System.Drawing.Size(426, 43);
            this.textYourTip.TabIndex = 0;
            this.textYourTip.Text = "Hier ihren Tipps eintragen!";
            this.textYourTip.Click += new System.EventHandler(this.textYourTip_Click);
            // 
            // genNumbers
            // 
            this.genNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genNumbers.Location = new System.Drawing.Point(392, 78);
            this.genNumbers.Name = "genNumbers";
            this.genNumbers.Size = new System.Drawing.Size(222, 100);
            this.genNumbers.TabIndex = 1;
            this.genNumbers.Text = "Lottozahlen auslosen";
            this.genNumbers.UseVisualStyleBackColor = true;
            this.genNumbers.Click += new System.EventHandler(this.genNumbers_Click);
            // 
            // tip1
            // 
            this.tip1.Location = new System.Drawing.Point(245, 424);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(45, 20);
            this.tip1.TabIndex = 2;
            this.tip1.TextChanged += new System.EventHandler(this.tip1_TextChanged);
            // 
            // tip2
            // 
            this.tip2.Location = new System.Drawing.Point(334, 424);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(45, 20);
            this.tip2.TabIndex = 3;
            this.tip2.TextChanged += new System.EventHandler(this.tip2_TextChanged);
            // 
            // tip3
            // 
            this.tip3.Location = new System.Drawing.Point(420, 424);
            this.tip3.Name = "tip3";
            this.tip3.Size = new System.Drawing.Size(45, 20);
            this.tip3.TabIndex = 4;
            this.tip3.TextChanged += new System.EventHandler(this.tip3_TextChanged);
            // 
            // tip6
            // 
            this.tip6.Location = new System.Drawing.Point(690, 424);
            this.tip6.Name = "tip6";
            this.tip6.Size = new System.Drawing.Size(45, 20);
            this.tip6.TabIndex = 7;
            this.tip6.TextChanged += new System.EventHandler(this.tip6_TextChanged);
            // 
            // tip5
            // 
            this.tip5.Location = new System.Drawing.Point(606, 424);
            this.tip5.Name = "tip5";
            this.tip5.Size = new System.Drawing.Size(45, 20);
            this.tip5.TabIndex = 6;
            this.tip5.TextChanged += new System.EventHandler(this.tip5_TextChanged);
            // 
            // tip4
            // 
            this.tip4.Location = new System.Drawing.Point(509, 424);
            this.tip4.Name = "tip4";
            this.tip4.Size = new System.Drawing.Size(45, 20);
            this.tip4.TabIndex = 5;
            this.tip4.TextChanged += new System.EventHandler(this.tip4_TextChanged);
            // 
            // lottoNumber6
            // 
            this.lottoNumber6.Location = new System.Drawing.Point(690, 283);
            this.lottoNumber6.Name = "lottoNumber6";
            this.lottoNumber6.ReadOnly = true;
            this.lottoNumber6.Size = new System.Drawing.Size(45, 20);
            this.lottoNumber6.TabIndex = 13;
            this.lottoNumber6.TextChanged += new System.EventHandler(this.lottoNumber6_TextChanged);
            // 
            // lottoNumber5
            // 
            this.lottoNumber5.Location = new System.Drawing.Point(606, 283);
            this.lottoNumber5.Name = "lottoNumber5";
            this.lottoNumber5.ReadOnly = true;
            this.lottoNumber5.Size = new System.Drawing.Size(45, 20);
            this.lottoNumber5.TabIndex = 12;
            this.lottoNumber5.TextChanged += new System.EventHandler(this.lottoNumber5_TextChanged);
            // 
            // lottoNumber4
            // 
            this.lottoNumber4.Location = new System.Drawing.Point(509, 283);
            this.lottoNumber4.Name = "lottoNumber4";
            this.lottoNumber4.ReadOnly = true;
            this.lottoNumber4.Size = new System.Drawing.Size(45, 20);
            this.lottoNumber4.TabIndex = 11;
            this.lottoNumber4.TextChanged += new System.EventHandler(this.lottoNumber4_TextChanged);
            // 
            // lottoNumber3
            // 
            this.lottoNumber3.Location = new System.Drawing.Point(420, 283);
            this.lottoNumber3.Name = "lottoNumber3";
            this.lottoNumber3.ReadOnly = true;
            this.lottoNumber3.Size = new System.Drawing.Size(45, 20);
            this.lottoNumber3.TabIndex = 10;
            this.lottoNumber3.TextChanged += new System.EventHandler(this.lottoNumber3_TextChanged);
            // 
            // lottoNumber2
            // 
            this.lottoNumber2.Location = new System.Drawing.Point(334, 283);
            this.lottoNumber2.Name = "lottoNumber2";
            this.lottoNumber2.ReadOnly = true;
            this.lottoNumber2.Size = new System.Drawing.Size(45, 20);
            this.lottoNumber2.TabIndex = 9;
            this.lottoNumber2.TextChanged += new System.EventHandler(this.lottoNumber2_TextChanged);
            // 
            // lottoNumber1
            // 
            this.lottoNumber1.Location = new System.Drawing.Point(245, 283);
            this.lottoNumber1.Name = "lottoNumber1";
            this.lottoNumber1.ReadOnly = true;
            this.lottoNumber1.Size = new System.Drawing.Size(45, 20);
            this.lottoNumber1.TabIndex = 8;
            this.lottoNumber1.TextChanged += new System.EventHandler(this.lottoNumber1_TextChanged);
            // 
            // textLottoNumbers
            // 
            this.textLottoNumbers.BackColor = System.Drawing.Color.Yellow;
            this.textLottoNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLottoNumbers.Location = new System.Drawing.Point(327, 209);
            this.textLottoNumbers.Name = "textLottoNumbers";
            this.textLottoNumbers.Size = new System.Drawing.Size(339, 43);
            this.textLottoNumbers.TabIndex = 14;
            this.textLottoNumbers.Text = "Die Lottozahlen sind:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(974, 597);
            this.Controls.Add(this.textLottoNumbers);
            this.Controls.Add(this.lottoNumber6);
            this.Controls.Add(this.lottoNumber5);
            this.Controls.Add(this.lottoNumber4);
            this.Controls.Add(this.lottoNumber3);
            this.Controls.Add(this.lottoNumber2);
            this.Controls.Add(this.lottoNumber1);
            this.Controls.Add(this.tip6);
            this.Controls.Add(this.tip5);
            this.Controls.Add(this.tip4);
            this.Controls.Add(this.tip3);
            this.Controls.Add(this.tip2);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.genNumbers);
            this.Controls.Add(this.textYourTip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textYourTip;
        private System.Windows.Forms.Button genNumbers;
        private System.Windows.Forms.TextBox tip1;
        private System.Windows.Forms.TextBox tip2;
        private System.Windows.Forms.TextBox tip3;
        private System.Windows.Forms.TextBox tip6;
        private System.Windows.Forms.TextBox tip5;
        private System.Windows.Forms.TextBox tip4;
        private System.Windows.Forms.TextBox lottoNumber6;
        private System.Windows.Forms.TextBox lottoNumber5;
        private System.Windows.Forms.TextBox lottoNumber4;
        private System.Windows.Forms.TextBox lottoNumber3;
        private System.Windows.Forms.TextBox lottoNumber2;
        private System.Windows.Forms.TextBox lottoNumber1;
        private System.Windows.Forms.Label textLottoNumbers;
    }
}

