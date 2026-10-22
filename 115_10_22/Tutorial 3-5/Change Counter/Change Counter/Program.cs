using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Change_Counter
{
    static class Program
    {
        /// <summary>
        /// 應用程式的進入點，負責設定並啟動主表單。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows 視覺樣式，並設定文字繪製相容模式。
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 建立並顯示主表單，直到表單關閉為止。
            Application.Run(new Form1());
        }
    }
}
