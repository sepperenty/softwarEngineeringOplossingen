namespace YahtzeeTeerling
{
    partial class scoreBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHuidigAantalWorpen = new System.Windows.Forms.Label();
            this.lblHuidigeScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huidig Aantal Worpen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Huidige Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "High .....Score";
            // 
            // lblHuidigAantalWorpen
            // 
            this.lblHuidigAantalWorpen.AutoSize = true;
            this.lblHuidigAantalWorpen.Location = new System.Drawing.Point(164, 26);
            this.lblHuidigAantalWorpen.Name = "lblHuidigAantalWorpen";
            this.lblHuidigAantalWorpen.Size = new System.Drawing.Size(0, 13);
            this.lblHuidigAantalWorpen.TabIndex = 3;
            // 
            // lblHuidigeScore
            // 
            this.lblHuidigeScore.AutoSize = true;
            this.lblHuidigeScore.Location = new System.Drawing.Point(164, 55);
            this.lblHuidigeScore.Name = "lblHuidigeScore";
            this.lblHuidigeScore.Size = new System.Drawing.Size(0, 13);
            this.lblHuidigeScore.TabIndex = 4;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(164, 84);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(0, 13);
            this.lblHighScore.TabIndex = 5;
            // 
            // scoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblHuidigeScore);
            this.Controls.Add(this.lblHuidigAantalWorpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "scoreBoard";
            this.Size = new System.Drawing.Size(188, 185);
            this.Load += new System.EventHandler(this.scoreBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHuidigAantalWorpen;
        private System.Windows.Forms.Label lblHuidigeScore;
        private System.Windows.Forms.Label lblHighScore;
    }
}
