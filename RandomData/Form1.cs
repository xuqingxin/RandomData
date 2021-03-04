using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomData
{
    public partial class FrmMain : Form
    {
        private Random random = new Random();
        private int digits = 4;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int n = (int)Math.Pow(10, digits);
            StringBuilder builder = new StringBuilder();
            int upper = (int)((double)nudUpper.Value * n) + 1;
            int lower = (int)((double)nudLower.Value * n);

            for (int i = 0; i < nudNumber.Value; i++)
            {
                int iValue = random.Next(lower, upper);
                double dValue = iValue * 1.0 / n;
                string str = dValue.ToString($"F{digits}");
                builder.Append($"{i + 1},{str}\r\n");
            }
            string filename = $"{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.csv";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            File.WriteAllText(filename, builder.ToString());
            MessageBox.Show($"数据生成成功，文件名：{filename}");
        }
    }
}