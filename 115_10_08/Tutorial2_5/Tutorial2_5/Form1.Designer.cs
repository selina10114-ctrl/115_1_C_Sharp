using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Tutorial2_5
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            cardBackPictureBox = new PictureBox();
            cardFacePictureBox = new PictureBox();
            showBackButton = new Button();
            showFaceButton = new Button();
            ((ISupportInitialize)cardBackPictureBox).BeginInit();
            ((ISupportInitialize)cardFacePictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardBackPictureBox
            // 
            cardBackPictureBox.Image = (Image)resources.GetObject("cardBackPictureBox.Image");
            cardBackPictureBox.Location = new Point(105, 88);
            cardBackPictureBox.Name = "cardBackPictureBox";
            cardBackPictureBox.Size = new Size(209, 269);
            cardBackPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBackPictureBox.TabIndex = 0;
            cardBackPictureBox.TabStop = false;
            // 
            // cardFacePictureBox
            // 
            cardFacePictureBox.Image = (Image)resources.GetObject("cardFacePictureBox.Image");
            cardFacePictureBox.Location = new Point(476, 88);
            cardFacePictureBox.Name = "cardFacePictureBox";
            cardFacePictureBox.Size = new Size(209, 269);
            cardFacePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardFacePictureBox.TabIndex = 1;
            cardFacePictureBox.TabStop = false;
            cardFacePictureBox.Visible = false;
            // 
            // showBackButton
            // 
            showBackButton.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showBackButton.Location = new Point(114, 423);
            showBackButton.Name = "showBackButton";
            showBackButton.Size = new Size(196, 91);
            showBackButton.TabIndex = 2;
            showBackButton.Text = "顯示背面";
            showBackButton.TextAlign = ContentAlignment.MiddleRight;
            showBackButton.UseVisualStyleBackColor = true;
            showBackButton.Click += showBackButton_Click;
            // 
            // showFaceButton
            // 
            showFaceButton.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showFaceButton.Location = new Point(489, 423);
            showFaceButton.Name = "showFaceButton";
            showFaceButton.Size = new Size(196, 91);
            showFaceButton.TabIndex = 3;
            showFaceButton.Text = "顯示正面";
            showFaceButton.UseVisualStyleBackColor = true;
            showFaceButton.Click += showFaceButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 581);
            Controls.Add(showFaceButton);
            Controls.Add(showBackButton);
            Controls.Add(cardFacePictureBox);
            Controls.Add(cardBackPictureBox);
            Name = "Form1";
            Text = "撲克牌展示";
            ((ISupportInitialize)cardBackPictureBox).EndInit();
            ((ISupportInitialize)cardFacePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardBackPictureBox;
        private PictureBox cardFacePictureBox;
        private Button showBackButton;
        private Button showFaceButton;
    }
}
