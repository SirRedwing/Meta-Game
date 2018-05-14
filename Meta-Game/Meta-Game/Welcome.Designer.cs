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
            this.OpeningDialogue = new System.Windows.Forms.TextBox();
            this.Option1 = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.Option3 = new System.Windows.Forms.Button();
            this.Option4 = new System.Windows.Forms.Button();
            this.Function_Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpeningDialogue
            // 
            this.OpeningDialogue.Location = new System.Drawing.Point(12, 511);
            this.OpeningDialogue.Multiline = true;
            this.OpeningDialogue.Name = "OpeningDialogue";
            this.OpeningDialogue.ReadOnly = true;
            this.OpeningDialogue.Size = new System.Drawing.Size(1160, 158);
            this.OpeningDialogue.TabIndex = 0;
            // 
            // Option1
            // 
            this.Option1.Location = new System.Drawing.Point(12, 405);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(286, 100);
            this.Option1.TabIndex = 1;
            this.Option1.Text = "button1";
            this.Option1.UseVisualStyleBackColor = true;
            // 
            // Option2
            // 
            this.Option2.Location = new System.Drawing.Point(304, 405);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(286, 100);
            this.Option2.TabIndex = 2;
            this.Option2.Text = "button2";
            this.Option2.UseVisualStyleBackColor = true;
            // 
            // Option3
            // 
            this.Option3.Location = new System.Drawing.Point(594, 405);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(286, 100);
            this.Option3.TabIndex = 3;
            this.Option3.Text = "button3";
            this.Option3.UseVisualStyleBackColor = true;
            // 
            // Option4
            // 
            this.Option4.Location = new System.Drawing.Point(886, 405);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(286, 100);
            this.Option4.TabIndex = 4;
            this.Option4.Text = "button4";
            this.Option4.UseVisualStyleBackColor = true;
            // 
            // Function_Test
            // 
            this.Function_Test.Location = new System.Drawing.Point(12, 12);
            this.Function_Test.Name = "Function_Test";
            this.Function_Test.Size = new System.Drawing.Size(91, 23);
            this.Function_Test.TabIndex = 5;
            this.Function_Test.Text = "Function Test";
            this.Function_Test.UseVisualStyleBackColor = true;
            this.Function_Test.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Meta_Game.Properties.Resources.Title_Screen;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.Function_Test);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.OpeningDialogue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Gather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OpeningDialogue;
        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button Option2;
        private System.Windows.Forms.Button Option3;
        private System.Windows.Forms.Button Option4;
        private System.Windows.Forms.Button Function_Test;
    }
}