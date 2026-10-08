namespace Tutorial2_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            germanPictureBox = new PictureBox();
            francePictureBox = new PictureBox();
            finlandPictureBox = new PictureBox();
            countryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)germanPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).BeginInit();
            SuspendLayout();
            // 
            // germanPictureBox
            // 
            germanPictureBox.Image = (Image)resources.GetObject("germanPictureBox.Image");
            germanPictureBox.Location = new Point(544, 117);
            germanPictureBox.Name = "germanPictureBox";
            germanPictureBox.Size = new Size(255, 142);
            germanPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            germanPictureBox.TabIndex = 0;
            germanPictureBox.TabStop = false;
            germanPictureBox.Click += germanPictureBox_Click;
            // 
            // francePictureBox
            // 
            francePictureBox.Image = (Image)resources.GetObject("francePictureBox.Image");
            francePictureBox.Location = new Point(272, 117);
            francePictureBox.Name = "francePictureBox";
            francePictureBox.Size = new Size(255, 142);
            francePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            francePictureBox.TabIndex = 1;
            francePictureBox.TabStop = false;
            francePictureBox.Click += francePictureBox_Click;
            // 
            // finlandPictureBox
            // 
            finlandPictureBox.Image = (Image)resources.GetObject("finlandPictureBox.Image");
            finlandPictureBox.Location = new Point(1, 117);
            finlandPictureBox.Name = "finlandPictureBox";
            finlandPictureBox.Size = new Size(255, 142);
            finlandPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            finlandPictureBox.TabIndex = 2;
            finlandPictureBox.TabStop = false;
            finlandPictureBox.Click += finlandPictureBox_Click;
            // 
            // countryLabel
            // 
            countryLabel.AutoEllipsis = true;
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            countryLabel.Location = new Point(341, 338);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(102, 50);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "德國";
            countryLabel.Click += countryLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countryLabel);
            Controls.Add(finlandPictureBox);
            Controls.Add(francePictureBox);
            Controls.Add(germanPictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)germanPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox germanPictureBox;
        private PictureBox francePictureBox;
        private PictureBox finlandPictureBox;
        private Label countryLabel;
    }
}
