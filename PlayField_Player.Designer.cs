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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_from_PlayField
            // 
            this.exit_from_PlayField.AutoSize = true;
            this.exit_from_PlayField.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_from_PlayField.ForeColor = System.Drawing.Color.Aqua;
            this.exit_from_PlayField.Location = new System.Drawing.Point(755, 287);
            this.exit_from_PlayField.Name = "exit_from_PlayField";
            this.exit_from_PlayField.Size = new System.Drawing.Size(53, 42);
            this.exit_from_PlayField.TabIndex = 0;
            this.exit_from_PlayField.Text = "10";
            this.exit_from_PlayField.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(628, 287);
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
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Moves:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score:";
            // 
            // score_virus
            // 
            this.score_virus.AutoSize = true;
            this.score_virus.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_virus.ForeColor = System.Drawing.Color.Tomato;
            this.score_virus.Location = new System.Drawing.Point(119, 119);
            this.score_virus.Name = "score_virus";
            this.score_virus.Size = new System.Drawing.Size(31, 42);
            this.score_virus.TabIndex = 7;
            this.score_virus.Text = "1";
            this.score_virus.Click += new System.EventHandler(this.score_virus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(628, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Score:";
            // 
            // score_antivirus
            // 
            this.score_antivirus.AutoSize = true;
            this.score_antivirus.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_antivirus.ForeColor = System.Drawing.Color.Aqua;
            this.score_antivirus.Location = new System.Drawing.Point(738, 235);
            this.score_antivirus.Name = "score_antivirus";
            this.score_antivirus.Size = new System.Drawing.Size(31, 42);
            this.score_antivirus.TabIndex = 9;
            this.score_antivirus.Text = "1";
            this.score_antivirus.Click += new System.EventHandler(this.score_antivirus_Click);
            // 
            // remainingMoves_Virus
            // 
            this.remainingMoves_Virus.AutoSize = true;
            this.remainingMoves_Virus.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingMoves_Virus.ForeColor = System.Drawing.Color.Tomato;
            this.remainingMoves_Virus.Location = new System.Drawing.Point(151, 161);
            this.remainingMoves_Virus.Name = "remainingMoves_Virus";
            this.remainingMoves_Virus.Size = new System.Drawing.Size(53, 42);
            this.remainingMoves_Virus.TabIndex = 10;
            this.remainingMoves_Virus.Text = "10";
            // 
            // name_virus
            // 
            this.name_virus.AutoSize = true;
            this.name_virus.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_virus.ForeColor = System.Drawing.Color.Red;
            this.name_virus.Location = new System.Drawing.Point(36, 60);
            this.name_virus.Name = "name_virus";
            this.name_virus.Size = new System.Drawing.Size(92, 42);
            this.name_virus.TabIndex = 11;
            this.name_virus.Text = "Virus";
            // 
            // name_antivirus
            // 
            this.name_antivirus.AutoSize = true;
            this.name_antivirus.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_antivirus.ForeColor = System.Drawing.Color.Blue;
            this.name_antivirus.Location = new System.Drawing.Point(637, 336);
            this.name_antivirus.Name = "name_antivirus";
            this.name_antivirus.Size = new System.Drawing.Size(151, 42);
            this.name_antivirus.TabIndex = 12;
            this.name_antivirus.Text = "Antivirus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
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
            this.current_move.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_move.ForeColor = System.Drawing.Color.Red;
            this.current_move.Location = new System.Drawing.Point(489, 407);
            this.current_move.Name = "current_move";
            this.current_move.Size = new System.Drawing.Size(92, 42);
            this.current_move.TabIndex = 14;
            this.current_move.Text = "Virus";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Virus.Resources.antivirus_picture;
            this.pictureBox2.Location = new System.Drawing.Point(616, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 182);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Virus.Resources.virus_picture;
            this.pictureBox1.Location = new System.Drawing.Point(12, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 169);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(827, -9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PlayField_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayField_Player";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Load += new System.EventHandler(this.PlayField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}