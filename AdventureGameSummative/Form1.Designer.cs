namespace AdventureGameSummative
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTitle = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.pictureBoxM = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.pictureBoxN = new System.Windows.Forms.PictureBox();
            this.optionLabel1 = new System.Windows.Forms.Label();
            this.optionLabel2 = new System.Windows.Forms.Label();
            this.optionLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxN)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle.Font = new System.Drawing.Font("Rockwell", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(-3, 220);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(470, 120);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "The Hunt";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Schneidler BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(33, 360);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(202, 67);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Hunt";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Schneidler Md BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.outputLabel.Location = new System.Drawing.Point(75, 22);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(661, 191);
            this.outputLabel.TabIndex = 2;
            // 
            // pictureBoxM
            // 
            this.pictureBoxM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxM.BackgroundImage = global::AdventureGameSummative.Properties.Resources.bloodSplatter;
            this.pictureBoxM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxM.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxM.InitialImage")));
            this.pictureBoxM.Location = new System.Drawing.Point(198, 220);
            this.pictureBoxM.Name = "pictureBoxM";
            this.pictureBoxM.Size = new System.Drawing.Size(48, 43);
            this.pictureBoxM.TabIndex = 3;
            this.pictureBoxM.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.Location = new System.Drawing.Point(198, 283);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(48, 46);
            this.pictureBoxB.TabIndex = 5;
            this.pictureBoxB.TabStop = false;
            // 
            // pictureBoxN
            // 
            this.pictureBoxN.Location = new System.Drawing.Point(198, 343);
            this.pictureBoxN.Name = "pictureBoxN";
            this.pictureBoxN.Size = new System.Drawing.Size(48, 46);
            this.pictureBoxN.TabIndex = 6;
            this.pictureBoxN.TabStop = false;
            // 
            // optionLabel1
            // 
            this.optionLabel1.BackColor = System.Drawing.Color.Transparent;
            this.optionLabel1.Font = new System.Drawing.Font("Schneidler Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel1.Location = new System.Drawing.Point(269, 213);
            this.optionLabel1.Name = "optionLabel1";
            this.optionLabel1.Size = new System.Drawing.Size(426, 50);
            this.optionLabel1.TabIndex = 7;
            // 
            // optionLabel2
            // 
            this.optionLabel2.BackColor = System.Drawing.Color.Transparent;
            this.optionLabel2.Font = new System.Drawing.Font("Schneidler Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel2.Location = new System.Drawing.Point(273, 283);
            this.optionLabel2.Name = "optionLabel2";
            this.optionLabel2.Size = new System.Drawing.Size(422, 46);
            this.optionLabel2.TabIndex = 8;
            // 
            // optionLabel3
            // 
            this.optionLabel3.BackColor = System.Drawing.Color.Transparent;
            this.optionLabel3.Font = new System.Drawing.Font("Schneidler Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel3.Location = new System.Drawing.Point(274, 343);
            this.optionLabel3.Name = "optionLabel3";
            this.optionLabel3.Size = new System.Drawing.Size(421, 46);
            this.optionLabel3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdventureGameSummative.Properties.Resources.TheHuntImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 467);
            this.Controls.Add(this.pictureBoxN);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxM);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.optionLabel2);
            this.Controls.Add(this.optionLabel3);
            this.Controls.Add(this.optionLabel1);
            this.Name = "Form1";
            this.Text = "TheHuntGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBoxM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.PictureBox pictureBoxN;
        private System.Windows.Forms.Label optionLabel1;
        private System.Windows.Forms.Label optionLabel2;
        private System.Windows.Forms.Label optionLabel3;
    }
}

