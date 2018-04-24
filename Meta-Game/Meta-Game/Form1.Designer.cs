namespace Meta_Game {
    partial class Form1 {
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
            this.Menu = new System.Windows.Forms.Button();
            this.flower = new System.Windows.Forms.Button();
            this.FunctionTest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.Location = new System.Drawing.Point(1128, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(44, 26);
            this.Menu.TabIndex = 6;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // flower
            // 
            this.flower.Location = new System.Drawing.Point(309, 191);
            this.flower.Name = "flower";
            this.flower.Size = new System.Drawing.Size(75, 23);
            this.flower.TabIndex = 7;
            this.flower.Text = "FLOWER";
            this.flower.UseVisualStyleBackColor = true;
            this.flower.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FunctionTest
            // 
            this.FunctionTest.Location = new System.Drawing.Point(462, 29);
            this.FunctionTest.Name = "FunctionTest";
            this.FunctionTest.Size = new System.Drawing.Size(128, 23);
            this.FunctionTest.TabIndex = 16;
            this.FunctionTest.Text = "Function Test";
            this.FunctionTest.UseVisualStyleBackColor = true;
            this.FunctionTest.Click += new System.EventHandler(this.Button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(596, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Points: ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FunctionTest);
            this.Controls.Add(this.flower);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button flower;
        private System.Windows.Forms.Button FunctionTest;
        private System.Windows.Forms.TextBox textBox1;
    }
}

