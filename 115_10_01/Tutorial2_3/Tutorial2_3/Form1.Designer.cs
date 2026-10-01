namespace Tutorial2_3
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
            label1 = new Label();
            button1 = new Button();
            translateLabel = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(87, 94);
            label1.Name = "label1";
            label1.Size = new Size(626, 46);
            label1.TabIndex = 1;
            label1.Text = "選擇一個語言，我告訴你怎麼說\"早安\"\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(87, 313);
            button1.Name = "button1";
            button1.Size = new Size(162, 58);
            button1.TabIndex = 3;
            button1.Text = "義大利";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // translateLabel
            // 
            translateLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            translateLabel.Location = new Point(98, 176);
            translateLabel.Name = "translateLabel";
            translateLabel.Size = new Size(596, 40);
            translateLabel.TabIndex = 4;
            translateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(323, 313);
            button2.Name = "button2";
            button2.Size = new Size(162, 58);
            button2.TabIndex = 5;
            button2.Text = "西班牙";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button3.Location = new Point(561, 313);
            button3.Name = "button3";
            button3.Size = new Size(162, 58);
            button3.TabIndex = 6;
            button3.Text = "德國";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(translateLabel);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label translateLabel;
        private Button button2;
        private Button button3;
    }
}
