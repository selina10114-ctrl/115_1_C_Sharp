namespace Test_Average
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的元件容器。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 釋放表單使用的資源。
        /// </summary>
        /// <param name="disposing">若為 true，則一併釋放受控資源。</param>
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
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test1PromptLabel = new System.Windows.Forms.Label();
            this.test2PromptLabel = new System.Windows.Forms.Label();
            this.test3PromptLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 第 1 次測驗成績輸入框。
            this.test1TextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.test1TextBox.Location = new System.Drawing.Point(393, 18);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(194, 53);
            this.test1TextBox.TabIndex = 0;
            // 第 2 次測驗成績輸入框。
            this.test2TextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.test2TextBox.Location = new System.Drawing.Point(393, 91);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(194, 53);
            this.test2TextBox.TabIndex = 1;
            // 第 3 次測驗成績輸入框。
            this.test3TextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.test3TextBox.Location = new System.Drawing.Point(393, 171);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(194, 53);
            this.test3TextBox.TabIndex = 2;
            // 第 1 次測驗提示標籤。
            this.test1PromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.test1PromptLabel.Location = new System.Drawing.Point(181, 18);
            this.test1PromptLabel.Name = "test1PromptLabel";
            this.test1PromptLabel.Size = new System.Drawing.Size(161, 50);
            this.test1PromptLabel.TabIndex = 3;
            this.test1PromptLabel.Text = "測驗 1：";
            // 第 2 次測驗提示標籤。
            this.test2PromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.test2PromptLabel.Location = new System.Drawing.Point(168, 91);
            this.test2PromptLabel.Name = "test2PromptLabel";
            this.test2PromptLabel.Size = new System.Drawing.Size(174, 53);
            this.test2PromptLabel.TabIndex = 4;
            this.test2PromptLabel.Text = "測驗 2：";
            // 第 3 次測驗提示標籤。
            this.test3PromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.test3PromptLabel.Location = new System.Drawing.Point(181, 178);
            this.test3PromptLabel.Name = "test3PromptLabel";
            this.test3PromptLabel.Size = new System.Drawing.Size(164, 46);
            this.test3PromptLabel.TabIndex = 5;
            this.test3PromptLabel.Text = "測驗 3：";
            // 平均成績顯示標籤。
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.averageLabel.Location = new System.Drawing.Point(393, 254);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(194, 42);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 平均成績說明標籤。
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(81, 245);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(287, 51);
            this.outputDescriptionLabel.TabIndex = 7;
            this.outputDescriptionLabel.Text = "測驗平均成績：";
            // 計算平均成績按鈕。
            this.calculateButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(33, 319);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(193, 55);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "計算平均";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 清除輸入內容按鈕。
            this.clearButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(311, 319);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(133, 55);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 關閉表單按鈕。
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(539, 319);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 55);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 表單基本設定與控制項配置。
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 424);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.test3PromptLabel);
            this.Controls.Add(this.test2PromptLabel);
            this.Controls.Add(this.test1PromptLabel);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "測驗平均分數";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Label test1PromptLabel;
        private System.Windows.Forms.Label test2PromptLabel;
        private System.Windows.Forms.Label test3PromptLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

