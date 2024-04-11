namespace wyprawa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.red_potion = new System.Windows.Forms.PictureBox();
            this.blue_potion = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_DOWN = new System.Windows.Forms.Button();
            this.r_RIGHT = new System.Windows.Forms.Button();
            this.r_LEFT = new System.Windows.Forms.Button();
            this.r_UP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IN_sword = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.IN_bow = new System.Windows.Forms.PictureBox();
            this.IN_mace = new System.Windows.Forms.PictureBox();
            this.IN_blue_potion = new System.Windows.Forms.PictureBox();
            this.IN_red_potion = new System.Windows.Forms.PictureBox();
            this.a_UP = new System.Windows.Forms.Button();
            this.a_LEFT = new System.Windows.Forms.Button();
            this.a_RIGHT = new System.Windows.Forms.Button();
            this.a_DOWN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_potion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_potion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IN_sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_blue_potion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_red_potion)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(77, 56);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 30);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = ((System.Drawing.Image)(resources.GetObject("bat.Image")));
            this.bat.Location = new System.Drawing.Point(113, 56);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(30, 30);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat.TabIndex = 1;
            this.bat.TabStop = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.Image = ((System.Drawing.Image)(resources.GetObject("ghost.Image")));
            this.ghost.Location = new System.Drawing.Point(149, 56);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(30, 30);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost.TabIndex = 2;
            this.ghost.TabStop = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.Image = ((System.Drawing.Image)(resources.GetObject("ghoul.Image")));
            this.ghoul.Location = new System.Drawing.Point(185, 56);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(30, 30);
            this.ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghoul.TabIndex = 3;
            this.ghoul.TabStop = false;
            // 
            // red_potion
            // 
            this.red_potion.BackColor = System.Drawing.Color.Transparent;
            this.red_potion.Image = ((System.Drawing.Image)(resources.GetObject("red_potion.Image")));
            this.red_potion.Location = new System.Drawing.Point(221, 56);
            this.red_potion.Name = "red_potion";
            this.red_potion.Size = new System.Drawing.Size(30, 30);
            this.red_potion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.red_potion.TabIndex = 4;
            this.red_potion.TabStop = false;
            // 
            // blue_potion
            // 
            this.blue_potion.BackColor = System.Drawing.Color.Transparent;
            this.blue_potion.Image = ((System.Drawing.Image)(resources.GetObject("blue_potion.Image")));
            this.blue_potion.Location = new System.Drawing.Point(257, 56);
            this.blue_potion.Name = "blue_potion";
            this.blue_potion.Size = new System.Drawing.Size(30, 30);
            this.blue_potion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blue_potion.TabIndex = 5;
            this.blue_potion.TabStop = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(293, 56);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(30, 30);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 6;
            this.sword.TabStop = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(329, 56);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(30, 30);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bow.TabIndex = 7;
            this.bow.TabStop = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.Image = ((System.Drawing.Image)(resources.GetObject("mace.Image")));
            this.mace.Location = new System.Drawing.Point(365, 56);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(30, 30);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mace.TabIndex = 8;
            this.mace.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.r_DOWN);
            this.groupBox1.Controls.Add(this.r_RIGHT);
            this.groupBox1.Controls.Add(this.r_LEFT);
            this.groupBox1.Controls.Add(this.r_UP);
            this.groupBox1.Location = new System.Drawing.Point(365, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruch";
            // 
            // r_DOWN
            // 
            this.r_DOWN.Location = new System.Drawing.Point(31, 59);
            this.r_DOWN.Name = "r_DOWN";
            this.r_DOWN.Size = new System.Drawing.Size(20, 20);
            this.r_DOWN.TabIndex = 3;
            this.r_DOWN.Text = "v";
            this.r_DOWN.UseVisualStyleBackColor = true;
            this.r_DOWN.Click += new System.EventHandler(this.r_DOWN_Click);
            // 
            // r_RIGHT
            // 
            this.r_RIGHT.Location = new System.Drawing.Point(53, 35);
            this.r_RIGHT.Name = "r_RIGHT";
            this.r_RIGHT.Size = new System.Drawing.Size(20, 20);
            this.r_RIGHT.TabIndex = 2;
            this.r_RIGHT.Text = ">";
            this.r_RIGHT.UseVisualStyleBackColor = true;
            this.r_RIGHT.Click += new System.EventHandler(this.r_RIGHT_Click);
            // 
            // r_LEFT
            // 
            this.r_LEFT.Location = new System.Drawing.Point(10, 35);
            this.r_LEFT.Name = "r_LEFT";
            this.r_LEFT.Size = new System.Drawing.Size(20, 20);
            this.r_LEFT.TabIndex = 1;
            this.r_LEFT.Text = "<";
            this.r_LEFT.UseVisualStyleBackColor = true;
            this.r_LEFT.Click += new System.EventHandler(this.r_LEFT_Click);
            // 
            // r_UP
            // 
            this.r_UP.Location = new System.Drawing.Point(31, 18);
            this.r_UP.Name = "r_UP";
            this.r_UP.Size = new System.Drawing.Size(20, 20);
            this.r_UP.TabIndex = 0;
            this.r_UP.Text = "^";
            this.r_UP.UseVisualStyleBackColor = true;
            this.r_UP.Click += new System.EventHandler(this.r_UP_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(329, 230);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(166, 66);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gracz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nietoperz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Upiór";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(86, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(77, 13);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(86, 13);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(64, 13);
            this.batHitPoints.TabIndex = 5;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(86, 26);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghostHitPoints.TabIndex = 6;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(86, 46);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.a_DOWN);
            this.groupBox2.Controls.Add(this.a_RIGHT);
            this.groupBox2.Controls.Add(this.a_LEFT);
            this.groupBox2.Controls.Add(this.a_UP);
            this.groupBox2.Location = new System.Drawing.Point(456, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(85, 85);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atak";
            // 
            // IN_sword
            // 
            this.IN_sword.BackColor = System.Drawing.Color.Transparent;
            this.IN_sword.Image = ((System.Drawing.Image)(resources.GetObject("IN_sword.Image")));
            this.IN_sword.Location = new System.Drawing.Point(73, 320);
            this.IN_sword.Name = "IN_sword";
            this.IN_sword.Size = new System.Drawing.Size(50, 50);
            this.IN_sword.TabIndex = 12;
            this.IN_sword.TabStop = false;
            this.IN_sword.Click += new System.EventHandler(this.IN_sword_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 50);
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // IN_bow
            // 
            this.IN_bow.BackColor = System.Drawing.Color.Transparent;
            this.IN_bow.Image = ((System.Drawing.Image)(resources.GetObject("IN_bow.Image")));
            this.IN_bow.Location = new System.Drawing.Point(129, 320);
            this.IN_bow.Name = "IN_bow";
            this.IN_bow.Size = new System.Drawing.Size(50, 50);
            this.IN_bow.TabIndex = 14;
            this.IN_bow.TabStop = false;
            this.IN_bow.Click += new System.EventHandler(this.IN_bow_Click);
            // 
            // IN_mace
            // 
            this.IN_mace.BackColor = System.Drawing.Color.Transparent;
            this.IN_mace.Image = ((System.Drawing.Image)(resources.GetObject("IN_mace.Image")));
            this.IN_mace.Location = new System.Drawing.Point(185, 320);
            this.IN_mace.Name = "IN_mace";
            this.IN_mace.Size = new System.Drawing.Size(50, 50);
            this.IN_mace.TabIndex = 15;
            this.IN_mace.TabStop = false;
            this.IN_mace.Click += new System.EventHandler(this.IN_mace_Click);
            // 
            // IN_blue_potion
            // 
            this.IN_blue_potion.BackColor = System.Drawing.Color.Transparent;
            this.IN_blue_potion.Image = ((System.Drawing.Image)(resources.GetObject("IN_blue_potion.Image")));
            this.IN_blue_potion.Location = new System.Drawing.Point(241, 320);
            this.IN_blue_potion.Name = "IN_blue_potion";
            this.IN_blue_potion.Size = new System.Drawing.Size(50, 50);
            this.IN_blue_potion.TabIndex = 16;
            this.IN_blue_potion.TabStop = false;
            this.IN_blue_potion.Click += new System.EventHandler(this.IN_blue_potion_Click);
            // 
            // IN_red_potion
            // 
            this.IN_red_potion.BackColor = System.Drawing.Color.Transparent;
            this.IN_red_potion.Image = ((System.Drawing.Image)(resources.GetObject("IN_red_potion.Image")));
            this.IN_red_potion.Location = new System.Drawing.Point(297, 320);
            this.IN_red_potion.Name = "IN_red_potion";
            this.IN_red_potion.Size = new System.Drawing.Size(50, 50);
            this.IN_red_potion.TabIndex = 17;
            this.IN_red_potion.TabStop = false;
            this.IN_red_potion.Click += new System.EventHandler(this.IN_red_potion_Click);
            // 
            // a_UP
            // 
            this.a_UP.Location = new System.Drawing.Point(34, 18);
            this.a_UP.Name = "a_UP";
            this.a_UP.Size = new System.Drawing.Size(20, 20);
            this.a_UP.TabIndex = 0;
            this.a_UP.Text = "^";
            this.a_UP.UseVisualStyleBackColor = true;
            this.a_UP.Click += new System.EventHandler(this.a_UP_Click);
            // 
            // a_LEFT
            // 
            this.a_LEFT.Location = new System.Drawing.Point(6, 35);
            this.a_LEFT.Name = "a_LEFT";
            this.a_LEFT.Size = new System.Drawing.Size(20, 20);
            this.a_LEFT.TabIndex = 1;
            this.a_LEFT.Text = "<";
            this.a_LEFT.UseVisualStyleBackColor = true;
            this.a_LEFT.Click += new System.EventHandler(this.a_LEFT_Click);
            // 
            // a_RIGHT
            // 
            this.a_RIGHT.Location = new System.Drawing.Point(59, 35);
            this.a_RIGHT.Name = "a_RIGHT";
            this.a_RIGHT.Size = new System.Drawing.Size(20, 20);
            this.a_RIGHT.TabIndex = 2;
            this.a_RIGHT.Text = ">";
            this.a_RIGHT.UseVisualStyleBackColor = true;
            this.a_RIGHT.Click += new System.EventHandler(this.a_RIGHT_Click);
            // 
            // a_DOWN
            // 
            this.a_DOWN.Location = new System.Drawing.Point(34, 59);
            this.a_DOWN.Name = "a_DOWN";
            this.a_DOWN.Size = new System.Drawing.Size(20, 20);
            this.a_DOWN.TabIndex = 3;
            this.a_DOWN.Text = "v";
            this.a_DOWN.UseVisualStyleBackColor = true;
            this.a_DOWN.Click += new System.EventHandler(this.a_DOWN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 398);
            this.Controls.Add(this.IN_red_potion);
            this.Controls.Add(this.IN_blue_potion);
            this.Controls.Add(this.IN_mace);
            this.Controls.Add(this.IN_bow);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.IN_sword);
            this.Controls.Add(this.player);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.blue_potion);
            this.Controls.Add(this.red_potion);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.bat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_potion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_potion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IN_sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_blue_potion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_red_potion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox red_potion;
        private System.Windows.Forms.PictureBox blue_potion;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.PictureBox IN_sword;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox IN_bow;
        private System.Windows.Forms.PictureBox IN_mace;
        private System.Windows.Forms.PictureBox IN_blue_potion;
        private System.Windows.Forms.PictureBox IN_red_potion;
        private System.Windows.Forms.Button r_DOWN;
        private System.Windows.Forms.Button r_RIGHT;
        private System.Windows.Forms.Button r_LEFT;
        private System.Windows.Forms.Button r_UP;
        private System.Windows.Forms.Button a_DOWN;
        private System.Windows.Forms.Button a_RIGHT;
        private System.Windows.Forms.Button a_LEFT;
        private System.Windows.Forms.Button a_UP;
    }
}

