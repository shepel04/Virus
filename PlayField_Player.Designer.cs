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
            this.name_virus = new System.Windows.Forms.Label();
            this.name_antivirus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.current_move = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remainingMoves_Antivirus
            // 
            this.remainingMoves_Antivirus.AutoSize = true;
            this.remainingMoves_Antivirus.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingMoves_Antivirus.Location = new System.Drawing.Point(730, 253);
            this.remainingMoves_Antivirus.Name = "remainingMoves_Antivirus";
            this.remainingMoves_Antivirus.Size = new System.Drawing.Size(38, 25);
            this.remainingMoves_Antivirus.TabIndex = 0;
            this.remainingMoves_Antivirus.Text = "10";
            this.remainingMoves_Antivirus.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moves:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Moves:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score:";
            // 
            // score_virus
            // 
            this.score_virus.AutoSize = true;
            this.score_virus.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_virus.Location = new System.Drawing.Point(119, 119);
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
            this.label4.Location = new System.Drawing.Point(635, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Score:";
            // 
            // score_antivirus
            // 
            this.score_antivirus.AutoSize = true;
            this.score_antivirus.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_antivirus.Location = new System.Drawing.Point(730, 201);
            this.score_antivirus.Name = "score_antivirus";
            this.score_antivirus.Size = new System.Drawing.Size(25, 25);
            this.score_antivirus.TabIndex = 9;
            this.score_antivirus.Text = "1";
            this.score_antivirus.Click += new System.EventHandler(this.score_antivirus_Click);
            // 
            // remainingMoves_Virus
            // 
            this.remainingMoves_Virus.AutoSize = true;
            this.remainingMoves_Virus.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingMoves_Virus.Location = new System.Drawing.Point(119, 171);
            this.remainingMoves_Virus.Name = "remainingMoves_Virus";
            this.remainingMoves_Virus.Size = new System.Drawing.Size(38, 25);
            this.remainingMoves_Virus.TabIndex = 10;
            this.remainingMoves_Virus.Text = "10";
            // 
            // name_virus
            // 
            this.name_virus.AutoSize = true;
            this.name_virus.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_virus.ForeColor = System.Drawing.Color.Red;
            this.name_virus.Location = new System.Drawing.Point(24, 70);
            this.name_virus.Name = "name_virus";
            this.name_virus.Size = new System.Drawing.Size(79, 25);
            this.name_virus.TabIndex = 11;
            this.name_virus.Text = "Virus";
            // 
            // name_antivirus
            // 
            this.name_antivirus.AutoSize = true;
            this.name_antivirus.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_antivirus.ForeColor = System.Drawing.Color.Blue;
            this.name_antivirus.Location = new System.Drawing.Point(635, 302);
            this.name_antivirus.Name = "name_antivirus";
            this.name_antivirus.Size = new System.Drawing.Size(130, 25);
            this.name_antivirus.TabIndex = 12;
            this.name_antivirus.Text = "Antivirus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Current move:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // current_move
            // 
            this.current_move.AutoSize = true;
            this.current_move.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_move.ForeColor = System.Drawing.Color.Red;
            this.current_move.Location = new System.Drawing.Point(437, 331);
            this.current_move.Name = "current_move";
            this.current_move.Size = new System.Drawing.Size(79, 25);
            this.current_move.TabIndex = 14;
            this.current_move.Text = "Virus";
            // 
            // PlayField_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 422);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remainingMoves_Antivirus);
            this.Name = "PlayField_Player";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
        private System.Windows.Forms.Label name_virus;
        private System.Windows.Forms.Label name_antivirus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label current_move;
    }
}