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
            this.remainingMoves_Antivirus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.score_virus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.score_antivirus = new System.Windows.Forms.Label();
            this.remainingMoves_Virus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remainingMoves_Antivirus
            // 
            this.remainingMoves_Antivirus.AutoSize = true;
            this.remainingMoves_Antivirus.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingMoves_Antivirus.Location = new System.Drawing.Point(861, 135);
            this.remainingMoves_Antivirus.Name = "remainingMoves_Antivirus";
            this.remainingMoves_Antivirus.Size = new System.Drawing.Size(38, 25);
            this.remainingMoves_Antivirus.TabIndex = 0;
            this.remainingMoves_Antivirus.Text = "50";
            this.remainingMoves_Antivirus.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remaining moves:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(725, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Remaining moves:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score:";
            // 
            // score_virus
            // 
            this.score_virus.AutoSize = true;
            this.score_virus.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_virus.Location = new System.Drawing.Point(107, 83);
            this.score_virus.Name = "score_virus";
            this.score_virus.Size = new System.Drawing.Size(25, 25);
            this.score_virus.TabIndex = 7;
            this.score_virus.Text = "1";
            this.score_virus.Click += new System.EventHandler(this.score_virus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(636, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Score:";
            // 
            // score_antivirus
            // 
            this.score_antivirus.AutoSize = true;
            this.score_antivirus.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_antivirus.Location = new System.Drawing.Point(731, 83);
            this.score_antivirus.Name = "score_antivirus";
            this.score_antivirus.Size = new System.Drawing.Size(25, 25);
            this.score_antivirus.TabIndex = 9;
            this.score_antivirus.Text = "1";
            // 
            // remainingMoves_Virus
            // 
            this.remainingMoves_Virus.AutoSize = true;
            this.remainingMoves_Virus.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingMoves_Virus.Location = new System.Drawing.Point(237, 135);
            this.remainingMoves_Virus.Name = "remainingMoves_Virus";
            this.remainingMoves_Virus.Size = new System.Drawing.Size(38, 25);
            this.remainingMoves_Virus.TabIndex = 10;
            this.remainingMoves_Virus.Text = "50";
            // 
            // PlayField_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 422);
            this.Controls.Add(this.remainingMoves_Virus);
            this.Controls.Add(this.score_antivirus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score_virus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remainingMoves_Antivirus);
            this.Name = "PlayField_Player";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PlayField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label remainingMoves_Antivirus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label score_virus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label score_antivirus;
        private System.Windows.Forms.Label remainingMoves_Virus;
    }
}