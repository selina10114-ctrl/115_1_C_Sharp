using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        // 建立表單並初始化所有控制項。
        public Form1()
        {
            InitializeComponent();
        }

        // 驗證輸入資料後，組合並顯示生日日期字串。
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 確認所有欄位都已輸入資料。
            if (string.IsNullOrWhiteSpace(dayOfWeekTextBox.Text) ||
                string.IsNullOrWhiteSpace(monthTextBox.Text) ||
                string.IsNullOrWhiteSpace(dayOfMonthTextBox.Text) ||
                string.IsNullOrWhiteSpace(yearTextBox.Text))
            {
                MessageBox.Show("請完整輸入日期資料。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 確認月份中的日期是 1 到 31 之間的有效數字。
            if (!int.TryParse(dayOfMonthTextBox.Text, out int dayOfMonth) || dayOfMonth < 1 || dayOfMonth > 31)
            {
                MessageBox.Show("月份中的日期必須是 1 到 31 之間的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dayOfMonthTextBox.Focus();
                return;
            }

            // 確認年份欄位只包含數字。
            if (!int.TryParse(yearTextBox.Text, out _))
            {
                MessageBox.Show("年份必須是數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yearTextBox.Focus();
                return;
            }

            // 將使用者輸入的日期資料組合成完整字串並顯示。
            dateOutputLabel.Text = $"{dayOfWeekTextBox.Text}，{monthTextBox.Text} {dayOfMonth}，{yearTextBox.Text}";
        }

        // 清除所有輸入欄位與日期輸出結果。
        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();
            dateOutputLabel.Text = string.Empty;
            dayOfWeekTextBox.Focus();
        }

        // 關閉目前的表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
           this. Close();
        }

        // 保留給標籤文字變更事件使用，目前不需要額外處理。
        private void dayOfMonthPromptLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
