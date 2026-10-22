using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有控制項。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice; // 儲存商品原價的變數。
            decimal discountPercentage; // 儲存折扣百分比的變數。
            decimal price;   // 儲存計算後的售價的變數。

            // 嘗試讀取商品原價，若輸入格式錯誤則提示使用者。
            if (!decimal.TryParse(originalPriceTextBox.Text, out originalPrice) || originalPrice < 0)
            {
                MessageBox.Show("請輸入有效的商品原價。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                originalPriceTextBox.Focus();
                return;
            }

            // 嘗試讀取折扣百分比，並確認折扣介於 0 到 100 之間。
            if (!decimal.TryParse(discountPercentageTextBox.Text, out discountPercentage) ||
                discountPercentage < 0 || discountPercentage > 100)
            {
                MessageBox.Show("請輸入 0 到 100 之間的折扣百分比。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                discountPercentageTextBox.Focus();
                return;
            }

            // 根據原價與折扣百分比計算折扣後的售價。
            price = originalPrice * (1 - discountPercentage / 100.0m);

            // 將計算後的售價顯示在售價標籤上，並以貨幣格式呈現。
            salePriceLabel.Text = price.ToString("C");
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單並結束操作。
            this.Close();
        }
    }
}
