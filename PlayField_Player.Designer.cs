namespace Virus
{
    partial class PlayField_Player
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayField_Player));
            this.exit_from_PlayField = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.score_virus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.score_antivirus = new System.Windows.Forms.Label();
            this.remainingMoves_Virus = new System.Windows.Forms.Label();
            this.name_virus = new System.Windows.Forms.Label();
            this.name_antivirus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.current_move = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.help_picture = new System.Windows.Forms.PictureBox();
            this.arrow_picture = new System.Windows.Forms.PictureBox();
            this.Virus_Picture = new System.Windows.Forms.PictureBox();
            this.Antivirus_Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.help_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Antivirus_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_from_PlayField
            // 
            this.exit_from_PlayField.AutoSize = true;
            this.exit_from_PlayField.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.exit_from_PlayField.ForeColor = System.Drawing.Color.Blue;
            this.exit_from_PlayField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit_from_PlayField.Location = new System.Drawing.Point(749, 313);
            this.exit_from_PlayField.Name = "exit_from_PlayField";
            this.exit_from_PlayField.Size = new System.Drawing.Size(53, 42);
            this.exit_from_PlayField.TabIndex = 0;
            this.exit_from_PlayField.Text = "10";
            this.exit_from_PlayField.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(628, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moves:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Moves:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score:";
            // 
            // score_virus
            // 
            this.score_virus.AutoSize = true;
            this.score_virus.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.score_virus.ForeColor = System.Drawing.Color.Red;
            this.score_virus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.score_virus.Location = new System.Drawing.Point(151, 119);
            this.score_virus.Name = "score_virus";
            this.score_virus.Size = new System.Drawing.Size(31, 42);
            this.score_virus.TabIndex = 7;
            this.score_virus.Text = "1";
            this.score_virus.Click += new System.EventHandler(this.score_virus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(628, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Score:";
            // 
            // score_antivirus
            // 
            this.score_antivirus.AutoSize = true;
            this.score_antivirus.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.score_antivirus.ForeColor = System.Drawing.Color.Blue;
            this.score_antivirus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.score_antivirus.Location = new System.Drawing.Point(749, 261);
            this.score_antivirus.Name = "score_antivirus";
            this.score_antivirus.Size = new System.Drawing.Size(31, 42);
            this.score_antivirus.TabIndex = 9;
            this.score_antivirus.Text = "1";
            this.score_antivirus.Click += new System.EventHandler(this.score_antivirus_Click);
            // 
            // remainingMoves_Virus
            // 
            this.remainingMoves_Virus.AutoSize = true;
            this.remainingMoves_Virus.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.remainingMoves_Virus.ForeColor = System.Drawing.Color.Red;
            this.remainingMoves_Virus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.remainingMoves_Virus.Location = new System.Drawing.Point(151, 161);
            this.remainingMoves_Virus.Name = "remainingMoves_Virus";
            this.remainingMoves_Virus.Size = new System.Drawing.Size(53, 42);
            this.remainingMoves_Virus.TabIndex = 10;
            this.remainingMoves_Virus.Text = "10";
            // 
            // name_virus
            // 
            this.name_virus.AutoSize = true;
            this.name_virus.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Bold);
            this.name_virus.ForeColor = System.Drawing.Color.Red;
            this.name_virus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.name_virus.Location = new System.Drawing.Point(36, 60);
            this.name_virus.Name = "name_virus";
            this.name_virus.Size = new System.Drawing.Size(101, 46);
            this.name_virus.TabIndex = 11;
            this.name_virus.Text = "Virus";
            // 
            // name_antivirus
            // 
            this.name_antivirus.AutoSize = true;
            this.name_antivirus.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Bold);
            this.name_antivirus.ForeColor = System.Drawing.Color.Blue;
            this.name_antivirus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.name_antivirus.Location = new System.Drawing.Point(637, 362);
            this.name_antivirus.Name = "name_antivirus";
            this.name_antivirus.Size = new System.Drawing.Size(165, 46);
            this.name_antivirus.TabIndex = 12;
            this.name_antivirus.Text = "Antivirus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(268, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 42);
            this.label7.TabIndex = 13;
            this.label7.Text = "Current move:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // current_move
            // 
            this.current_move.AutoSize = true;
            this.current_move.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold);
            this.current_move.ForeColor = System.Drawing.Color.Red;
            this.current_move.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.current_move.Location = new System.Drawing.Point(489, 407);
            this.current_move.Name = "current_move";
            this.current_move.Size = new System.Drawing.Size(92, 42);
            this.current_move.TabIndex = 14;
            this.current_move.Text = "Virus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Italic);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(827, -9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // help_picture
            // 
            this.help_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_picture.Image = ((System.Drawing.Image)(resources.GetObject("help_picture.Image")));
            this.help_picture.Location = new System.Drawing.Point(699, -9);
            this.help_picture.Name = "help_picture";
            this.help_picture.Size = new System.Drawing.Size(70, 66);
            this.help_picture.TabIndex = 25;
            this.help_picture.TabStop = false;
            this.help_picture.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // arrow_picture
            // 
            this.arrow_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrow_picture.Image = ((System.Drawing.Image)(resources.GetObject("arrow_picture.Image")));
            this.arrow_picture.Location = new System.Drawing.Point(771, -9);
            this.arrow_picture.Name = "arrow_picture";
            this.arrow_picture.Size = new System.Drawing.Size(70, 66);
            this.arrow_picture.TabIndex = 24;
            this.arrow_picture.TabStop = false;
            this.arrow_picture.Click += new System.EventHandler(this.arrow_picture_Click);
            // 
            // Virus_Picture
            // 
            this.Virus_Picture.Image = ((System.Drawing.Image)(resources.GetObject("Virus_Picture.Image")));
            this.Virus_Picture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Virus_Picture.Location = new System.Drawing.Point(21, 226);
            this.Virus_Picture.Name = "Virus_Picture";
            this.Virus_Picture.Size = new System.Drawing.Size(192, 182);
            this.Virus_Picture.TabIndex = 23;
            this.Virus_Picture.TabStop = false;
            // 
            // Antivirus_Picture
            // 
            this.Antivirus_Picture.Image = ((System.Drawing.Image)(resources.GetObject("Antivirus_Picture.Image")));
            this.Antivirus_Picture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Antivirus_Picture.Location = new System.Drawing.Point(626, 47);
            this.Antivirus_Picture.Name = "Antivirus_Picture";
            this.Antivirus_Picture.Size = new System.Drawing.Size(192, 182);
            this.Antivirus_Picture.TabIndex = 19;
            this.Antivirus_Picture.TabStop = false;
            // 
            // PlayField_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.help_picture);
            this.Controls.Add(this.arrow_picture);
            this.Controls.Add(this.Virus_Picture);
            this.Controls.Add(this.Antivirus_Picture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.current_move);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name_antivirus);
            this.Controls.Add(this.name_virus);
            this.Controls.Add(this.remainingMoves_Virus);
            this.Controls.Add(this.score_antivirus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score_virus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_from_PlayField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlayField_Player";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Load += new System.EventHandler(this.PlayField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.help_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Antivirus_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit_from_PlayField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label score_virus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label score_antivirus;
        private System.Windows.Forms.Label remainingMoves_Virus;
        private System.Windows.Forms.Label name_virus;
        private System.Windows.Forms.Label name_antivirus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label current_move;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Antivirus_Picture;
        private System.Windows.Forms.PictureBox Virus_Picture;
        private System.Windows.Forms.PictureBox arrow_picture;
        private System.Windows.Forms.PictureBox help_picture;
    }
}