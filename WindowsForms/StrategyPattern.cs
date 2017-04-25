using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.StrategyPattern;

namespace WindowsForms
{
    public partial class StrategyPattern : Form
    {
        public StrategyPattern()
        {
            InitializeComponent();
        }

        private void StrategyPattern_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "正常收费", "满300返100", "打8折" });
            comboBox1.SelectedIndex = 0;
        }

        private double total = 0.0d;

        private void button1_Click(object sender, EventArgs e)
        {
            CashContext context = new CashContext(comboBox1.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = context.GetResult(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));

            total += totalPrices;
            listBox1.Items.Add(string.Format("单价：{0} 数量：{1} 合计：{2}", textBox1.Text, textBox2.Text, totalPrices));

            label4.Text = "总计：" + total;
        }
    }
}