using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1, test2, test3, average;

        try
            {

            test1 = double.Parse(test1TextBox.Text);// 解析輸入的測驗成績。
                test2 = double.Parse(test2TextBox.Text);// 解析輸入的測驗成績。
                test3 = double.Parse(test3TextBox.Text);// 解析輸入的測驗成績。

                average = (test1 + test2 + test3) / 3;// 計算平均成績。

                averageLabel.Text = average.ToString("F1");// 顯示平均成績，並保留一位小數。
            }
        catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除所有測驗成績輸入欄位及平均成績顯示內容。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
