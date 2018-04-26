namespace Meta_Game {
    partial class Game {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Menu = new System.Windows.Forms.Button();
            this.flower = new System.Windows.Forms.Button();
            this.FunctionTest = new System.Windows.Forms.Button();
            this.PointsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.Image = global::Meta_Game.Properties.Resources.Menu_Button;
            this.Menu.Location = new System.Drawing.Point(1122, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 25);
            this.Menu.TabIndex = 6;
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // flower
            // 
            this.flower.BackColor = System.Drawing.Color.Transparent;
            this.flower.CausesValidation = false;
            this.flower.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.flower.FlatAppearance.BorderSize = 0;
            this.flower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.flower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.flower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flower.ForeColor = System.Drawing.Color.Transparent;
            this.flower.Image = ((System.Drawing.Image)(resources.GetObject("flower.Image")));
            this.flower.Location = new System.Drawing.Point(305, 159);
            this.flower.Margin = new System.Windows.Forms.Padding(0);
            this.flower.Name = "flower";
            this.flower.Size = new System.Drawing.Size(150, 150);
            this.flower.TabIndex = 7;
            this.flower.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.flower.UseVisualStyleBackColor = false;
            this.flower.Click += new System.EventHandler(this.Flower_Click);
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
            // PointsBox
            // 
            this.PointsBox.Location = new System.Drawing.Point(596, 29);
            this.PointsBox.Name = "PointsBox";
            this.PointsBox.Size = new System.Drawing.Size(107, 20);
            this.PointsBox.TabIndex = 17;
            this.PointsBox.Text = "Points: ";
            this.PointsBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Meta_Game.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.PointsBox);
            this.Controls.Add(this.FunctionTest);
            this.Controls.Add(this.flower);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "Game";
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
        private System.Windows.Forms.TextBox PointsBox;
    }
}

