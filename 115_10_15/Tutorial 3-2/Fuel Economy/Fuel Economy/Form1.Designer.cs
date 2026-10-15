namespace Fuel_Economy
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
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.milesPromptLabel.Location = new System.Drawing.Point(20, 20);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(220, 40);
            this.milesPromptLabel.TabIndex = 0;
            this.milesPromptLabel.Text = "請輸入行駛公里";
            this.milesPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gallonsPromptLabel.Location = new System.Drawing.Point(20, 103);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(220, 40);
            this.gallonsPromptLabel.TabIndex = 1;
            this.gallonsPromptLabel.Text = "請輸入使用汽油公升";
            this.gallonsPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // milesTextBox
            // 
            this.milesTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.milesTextBox.Location = new System.Drawing.Point(363, 14);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(110, 53);
            this.milesTextBox.TabIndex = 2;
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gallonsTextBox.Location = new System.Drawing.Point(363, 97);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(110, 53);
            this.gallonsTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(20, 186);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(220, 43);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "每公升行駛公里";
            this.outputDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mpgLabel.Location = new System.Drawing.Point(363, 186);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(110, 43);
            this.mpgLabel.TabIndex = 5;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(70, 276);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 55);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算油耗";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(425, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 55);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 368);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "燃油效率計算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesPromptLabel;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

