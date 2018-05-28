namespace Meta_Game {
    partial class Welcome {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.Location = new System.Drawing.Point(507, 416);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(160, 70);
            this.StartButton.TabIndex = 6;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::Meta_Game.Properties.Resources.Exit_Button;
            this.ExitButton.Location = new System.Drawing.Point(507, 492);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(160, 70);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Meta_Game.Properties.Resources.Title_Screen;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Gather";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
    }
}