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
            this.Antivirus_Picture = new System.Windows.Forms.PictureBox();
            this.Virus_Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Antivirus_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_from_PlayField
            // 
            resources.ApplyResources(this.exit_from_PlayField, "exit_from_PlayField");
            this.exit_from_PlayField.ForeColor = System.Drawing.Color.Blue;
            this.exit_from_PlayField.Name = "exit_from_PlayField";
            this.exit_from_PlayField.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // score_virus
            // 
            resources.ApplyResources(this.score_virus, "score_virus");
            this.score_virus.ForeColor = System.Drawing.Color.Red;
            this.score_virus.Name = "score_virus";
            this.score_virus.Click += new System.EventHandler(this.score_virus_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // score_antivirus
            // 
            resources.ApplyResources(this.score_antivirus, "score_antivirus");
            this.score_antivirus.ForeColor = System.Drawing.Color.Blue;
            this.score_antivirus.Name = "score_antivirus";
            this.score_antivirus.Click += new System.EventHandler(this.score_antivirus_Click);
            // 
            // remainingMoves_Virus
            // 
            resources.ApplyResources(this.remainingMoves_Virus, "remainingMoves_Virus");
            this.remainingMoves_Virus.ForeColor = System.Drawing.Color.Red;
            this.remainingMoves_Virus.Name = "remainingMoves_Virus";
            // 
            // name_virus
            // 
            resources.ApplyResources(this.name_virus, "name_virus");
            this.name_virus.ForeColor = System.Drawing.Color.Red;
            this.name_virus.Name = "name_virus";
            // 
            // name_antivirus
            // 
            resources.ApplyResources(this.name_antivirus, "name_antivirus");
            this.name_antivirus.ForeColor = System.Drawing.Color.Blue;
            this.name_antivirus.Name = "name_antivirus";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // current_move
            // 
            resources.ApplyResources(this.current_move, "current_move");
            this.current_move.ForeColor = System.Drawing.Color.Red;
            this.current_move.Name = "current_move";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Antivirus_Picture
            // 
            resources.ApplyResources(this.Antivirus_Picture, "Antivirus_Picture");
            this.Antivirus_Picture.Name = "Antivirus_Picture";
            this.Antivirus_Picture.TabStop = false;
            // 
            // Virus_Picture
            // 
            resources.ApplyResources(this.Virus_Picture, "Virus_Picture");
            this.Virus_Picture.Name = "Virus_Picture";
            this.Virus_Picture.TabStop = false;
            // 
            // PlayField_Player
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayField_Player";
            this.Load += new System.EventHandler(this.PlayField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Antivirus_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Virus_Picture)).EndInit();
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
    }
}