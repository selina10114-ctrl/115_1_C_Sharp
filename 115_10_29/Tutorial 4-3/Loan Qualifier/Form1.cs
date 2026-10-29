using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單元件。
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // 設定符合貸款資格所需的最低年收入。
            const decimal MIN_SALARY = 30000m;
            // 設定符合貸款資格所需的最低工作年資。
            const int MIN_YEARS = 2;

            decimal salary;
            int yearsOnJob; 

            try
                {
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                // 判斷使用者是否符合貸款資格。
                if (salary >= MIN_SALARY)
                {
                   if (yearsOnJob >= MIN_YEARS)
                    {
                        decisionLabel.Text = "符合貸款資格";
                    }
                    else
                    {
                        decisionLabel.Text = "薪資符合但是年資不符合貸款資格";
                    }
                }
                else
                {
                    decisionLabel.Text = "薪資不符合貸款資格";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除輸入內容與審核結果。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標移回年收入輸入框。
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
