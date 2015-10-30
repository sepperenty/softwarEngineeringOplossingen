namespace YahtzeeTeerling
{
    partial class teerlingview
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
            this.teerlingLabel = new System.Windows.Forms.Label();
            this.wepButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teerlingLabel
            // 
            this.teerlingLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.teerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.teerlingLabel.Location = new System.Drawing.Point(73, 23);
            this.teerlingLabel.Name = "teerlingLabel";
            this.teerlingLabel.Size = new System.Drawing.Size(168, 154);
            this.teerlingLabel.TabIndex = 0;
            this.teerlingLabel.Text = "label1";
            this.teerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teerlingLabel.Click += new System.EventHandler(this.teerlingLabel_Click);
            // 
            // wepButton
            // 
            this.wepButton.Location = new System.Drawing.Point(125, 223);
            this.wepButton.Name = "wepButton";
            this.wepButton.Size = new System.Drawing.Size(75, 35);
            this.wepButton.TabIndex = 1;
            this.wepButton.Text = "Werp";
            this.wepButton.UseVisualStyleBackColor = true;
            this.wepButton.Visible = false;
            this.wepButton.Click += new System.EventHandler(this.wepButton_Click);
            // 
            // teerlingview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wepButton);
            this.Controls.Add(this.teerlingLabel);
            this.Name = "teerlingview";
            this.Size = new System.Drawing.Size(321, 316);
            this.Load += new System.EventHandler(this.teerlingview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label teerlingLabel;
        private System.Windows.Forms.Button wepButton;
    }
}
