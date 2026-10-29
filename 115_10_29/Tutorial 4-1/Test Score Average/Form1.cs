using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        private double PASSING_SCORE;

        public Form1()
        {
            // 初始化表單上的所有控制項。
            InitializeComponent();
        }

        /// <summary>
        /// 按下「計算平均」按鈕時，讀取三次測驗成績並計算平均分數。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 設定高分門檻，保留供後續判斷成績等級時使用。
            const double HIGH_SCORE = 95.0;

 double _SCORE = 60.0;// 設定及格分數門檻，保留供後續判斷成績等級時使用。

            // 宣告三次測驗成績與平均分數的變數。
            double test1, test2, test3, average;

            try
            {
                // 將文字框中的內容轉換為 double 數值。
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三次測驗成績的平均分數。
                average = (test1 + test2 + test3) / 3.0;

                // 將計算結果顯示在平均分數標籤中。
                averageLabel.Text = average.ToString("F1");

                //    if (average >= HIGH_SCORE)
                //    {
                //        // 如果平均分數大於或等於高分門檻，顯示「優異」訊息。
                //        MessageBox.Show("恭喜! 平均分數達到最高門檻!");
                //    }
                //}

                if (average >= PASSING_SCORE)
                {
                    // 如果平均分數大於或等於高分門檻，顯示「優異」訊息。
                    MessageBox.Show("恭喜! 平均分數及格!");
                }
                else
                {
                    // 如果平均分數小於及格分數門檻，顯示「不及格」訊息。
                    MessageBox.Show("很遺憾平均分數不及格!");
                }
            }
            catch (Exception ex)
            {
                // 輸入內容不是有效數字時，顯示錯誤訊息。
                MessageBox.Show(ex.Message, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個成績輸入框及平均分數顯示標籤的內容。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 將輸入焦點移回第一個成績輸入框。
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
