namespace kalkulator_przyjec2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fancy = new System.Windows.Forms.CheckBox();
            this.healthy = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość osób";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fancy
            // 
            this.fancy.AutoSize = true;
            this.fancy.Location = new System.Drawing.Point(3, 45);
            this.fancy.Name = "fancy";
            this.fancy.Size = new System.Drawing.Size(126, 17);
            this.fancy.TabIndex = 2;
            this.fancy.Text = "Dekoracje fantazyjne";
            this.fancy.UseVisualStyleBackColor = true;
            this.fancy.CheckedChanged += new System.EventHandler(this.fancy_CheckedChanged);
            // 
            // healthy
            // 
            this.healthy.AutoSize = true;
            this.healthy.Location = new System.Drawing.Point(3, 66);
            this.healthy.Name = "healthy";
            this.healthy.Size = new System.Drawing.Size(91, 17);
            this.healthy.TabIndex = 3;
            this.healthy.Text = "Opcja zdrowa";
            this.healthy.UseVisualStyleBackColor = true;
            this.healthy.CheckedChanged += new System.EventHandler(this.healthy_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Koszt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(45, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 15);
            this.label3.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 181);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.fancy);
            this.tabPage1.Controls.Add(this.healthy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 155);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "impreza okolicznoścowa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 155);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "urodziny";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // birthdayCost
            // 
            this.birthdayCost.AutoSize = true;
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Location = new System.Drawing.Point(49, 113);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(2, 15);
            this.birthdayCost.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Koszt";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(7, 86);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(100, 20);
            this.cakeWriting.TabIndex = 5;
            this.cakeWriting.Text = "Sto lat!";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.IndianRed;
            this.tooLongLabel.Location = new System.Drawing.Point(92, 69);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(72, 13);
            this.tooLongLabel.TabIndex = 4;
            this.tooLongLabel.Text = "ZBYT DŁUGI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Napis na torcie";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(3, 45);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(126, 17);
            this.fancyBirthday.TabIndex = 2;
            this.fancyBirthday.Text = "Dekoracje fantazyjne";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(3, 19);
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 20);
            this.numberBirthday.TabIndex = 1;
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ilość osób";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 205);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox fancy;
        private System.Windows.Forms.CheckBox healthy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label5;
    }
}

