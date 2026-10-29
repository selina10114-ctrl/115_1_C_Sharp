using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單元件。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕的處理程式。
            const int BASE_HOURS = 40; // 基本工時
            const decimal OVERTIME_RATE = 1.5m; // 加班費率
            decimal hoursWorked; // 工作時數
            decimal hourlyPayRate; // 時薪
            decimal grossPay; // 總薪資

            try
            { 
            hoursWorked = decimal.Parse(hoursWorkedTextBox.Text); // 取得工作時數
            hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text); // 取得時薪

                // 計算總薪資。
                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate; // 沒有加班
                }
                else
                {
                    decimal overtimeHours = hoursWorked - BASE_HOURS; // 計算加班時數
                    grossPay = (BASE_HOURS * hourlyPayRate) + (overtimeHours * hourlyPayRate * OVERTIME_RATE); // 計算總薪資
                }

                grossPayLabel.Text = grossPay.ToString("C"); // 顯示總薪資，格式化為貨幣
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除輸入欄位與總薪資顯示。
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將游標移回工作時數欄位。
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
