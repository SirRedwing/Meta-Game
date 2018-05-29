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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.flower = new System.Windows.Forms.Button();
            this.PointsBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flower
            // 
            this.flower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flower.BackColor = System.Drawing.Color.Transparent;
            this.flower.CausesValidation = false;
            this.flower.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.flower.FlatAppearance.BorderSize = 0;
            this.flower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.flower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.flower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flower.ForeColor = System.Drawing.Color.Transparent;
            this.flower.Image = ((System.Drawing.Image)(resources.GetObject("flower.Image")));
            this.flower.Location = new System.Drawing.Point(134, 215);
            this.flower.Margin = new System.Windows.Forms.Padding(0);
            this.flower.Name = "flower";
            this.flower.Size = new System.Drawing.Size(146, 146);
            this.flower.TabIndex = 7;
            this.flower.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.flower.UseVisualStyleBackColor = false;
            this.flower.Click += new System.EventHandler(this.Flower_Click);
            // 
            // PointsBox
            // 
            this.PointsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PointsBox.BackColor = System.Drawing.Color.Firebrick;
            this.PointsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PointsBox.Location = new System.Drawing.Point(12, 32);
            this.PointsBox.Name = "PointsBox";
            this.PointsBox.ReadOnly = true;
            this.PointsBox.Size = new System.Drawing.Size(200, 20);
            this.PointsBox.TabIndex = 17;
            this.PointsBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.CausesValidation = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Meta_Game.Properties.Resources.Strange_Blob;
            this.button2.Location = new System.Drawing.Point(868, 359);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 146);
            this.button2.TabIndex = 18;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Meta_Game.Properties.Resources.Point_Box;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 40);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Meta_Game.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PointsBox);
            this.Controls.Add(this.flower);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.Button flower;
        private System.Windows.Forms.TextBox PointsBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

