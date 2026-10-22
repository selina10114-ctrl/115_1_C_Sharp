using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FiveCents = 5.0m; // 五分硬幣的面額
        const decimal TenCents = 10.0m; // 一角硬幣的面額
       const decimal TwentyFiveCents = 25.0m; // 二角五分硬幣的面額
       const decimal FiftyCents = 50.0m; // 五角硬幣的面額
       private decimal total = 0.00m; // 初始化總金額為零

        public Form1()
        {
            // 初始化表單上的控制項及其版面設定。
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            decimal total =0.00m; // 初始化總金額為零
            total += FiveCents; // 將五分硬幣的面額加到總金額中
            totalLabel.Text = total.ToString("C"); // 將總金額格式化為貨幣形式並顯示在標籤上
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
           decimal total = 0.00m; // 初始化總金額為零
            total += TenCents; // 將一角硬幣的面額加到總金額中
            totalLabel.Text = total.ToString("C"); // 將總金額格式化為貨幣形式並顯示在標籤上
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total =total + TwentyFiveCents; // 將二角五分硬幣的面額加到總金額中
            totalLabel.Text = total.ToString("C"); // 將總金額格式化為貨幣形式並顯示在標籤上
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total + FiftyCents; // 將五角硬幣的面額加到總金額中
            totalLabel.Text = total.ToString("C"); // 將總金額格式化為貨幣形式並顯示在標籤上
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前表單並結束應用程式。
            this.Close();
        }
    }
}
