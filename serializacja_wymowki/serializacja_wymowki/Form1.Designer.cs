namespace serializacja_wymowki
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.TextBox();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.fileDate = new System.Windows.Forms.Label();
            this.folder = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.randomExcuse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "File date";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(79, 5);
            this.description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(211, 20);
            this.description.TabIndex = 4;
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(79, 26);
            this.results.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(211, 20);
            this.results.TabIndex = 5;
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(79, 47);
            this.lastUsed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(203, 20);
            this.lastUsed.TabIndex = 6;
            // 
            // fileDate
            // 
            this.fileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileDate.Location = new System.Drawing.Point(79, 70);
            this.fileDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileDate.Name = "fileDate";
            this.fileDate.Size = new System.Drawing.Size(209, 15);
            this.fileDate.TabIndex = 7;
            // 
            // folder
            // 
            this.folder.Location = new System.Drawing.Point(20, 94);
            this.folder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(60, 19);
            this.folder.TabIndex = 8;
            this.folder.Text = "Folder";
            this.folder.UseVisualStyleBackColor = true;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(84, 94);
            this.save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(60, 19);
            this.save.TabIndex = 9;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Enabled = false;
            this.open.Location = new System.Drawing.Point(148, 94);
            this.open.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(60, 19);
            this.open.TabIndex = 10;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // randomExcuse
            // 
            this.randomExcuse.Enabled = false;
            this.randomExcuse.Location = new System.Drawing.Point(212, 94);
            this.randomExcuse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomExcuse.Name = "randomExcuse";
            this.randomExcuse.Size = new System.Drawing.Size(77, 19);
            this.randomExcuse.TabIndex = 11;
            this.randomExcuse.Text = "Random";
            this.randomExcuse.UseVisualStyleBackColor = true;
            this.randomExcuse.Click += new System.EventHandler(this.randomExcuse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 125);
            this.Controls.Add(this.randomExcuse);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.fileDate);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.results);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.Label fileDate;
        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button randomExcuse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

