namespace YahtzeeTeerling
{
    partial class Yahtzee
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
            this.btnTrowAll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblHuidigeScore = new System.Windows.Forms.Label();
            this.lblHuidigAantalWorpen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrowAll
            // 
            this.btnTrowAll.Location = new System.Drawing.Point(442, 352);
            this.btnTrowAll.Name = "btnTrowAll";
            this.btnTrowAll.Size = new System.Drawing.Size(75, 40);
            this.btnTrowAll.TabIndex = 0;
            this.btnTrowAll.Text = "Werp Alle";
            this.btnTrowAll.UseVisualStyleBackColor = true;
            this.btnTrowAll.Click += new System.EventHandler(this.btnTrowAll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(536, 352);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(586, 520);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(0, 13);
            this.lblHighScore.TabIndex = 11;
            // 
            // lblHuidigeScore
            // 
            this.lblHuidigeScore.AutoSize = true;
            this.lblHuidigeScore.Location = new System.Drawing.Point(586, 491);
            this.lblHuidigeScore.Name = "lblHuidigeScore";
            this.lblHuidigeScore.Size = new System.Drawing.Size(0, 13);
            this.lblHuidigeScore.TabIndex = 10;
            // 
            // lblHuidigAantalWorpen
            // 
            this.lblHuidigAantalWorpen.AutoSize = true;
            this.lblHuidigAantalWorpen.Location = new System.Drawing.Point(586, 462);
            this.lblHuidigAantalWorpen.Name = "lblHuidigAantalWorpen";
            this.lblHuidigAantalWorpen.Size = new System.Drawing.Size(0, 13);
            this.lblHuidigAantalWorpen.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "High Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Huidige Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Huidig Aantal Worpen";
            // 
            // Yahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1045, 623);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblHuidigeScore);
            this.Controls.Add(this.lblHuidigAantalWorpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTrowAll);
            this.Name = "Yahtzee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Yahtzee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrowAll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblHuidigeScore;
        private System.Windows.Forms.Label lblHuidigAantalWorpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

