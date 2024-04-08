namespace model_domu
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
            this.description = new System.Windows.Forms.TextBox();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.goHere = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(416, 247);
            this.description.TabIndex = 0;
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Location = new System.Drawing.Point(12, 292);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(416, 23);
            this.goThroughTheDoor.TabIndex = 1;
            this.goThroughTheDoor.Text = "Przejdz przez te drzwi";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(145, 265);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(283, 21);
            this.exits.TabIndex = 2;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(12, 265);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(127, 23);
            this.goHere.TabIndex = 3;
            this.goHere.Text = "idż tutaj:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 322);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(416, 23);
            this.check.TabIndex = 4;
            this.check.Text = "sprawdź";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(416, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Kryj się";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 382);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.check);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button button2;
    }
}

