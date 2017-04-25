using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.FactoryPattern;

namespace WindowsForms
{
    public partial class FactoryPattern : Form
    {
        public FactoryPattern()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operation oper = OperationFactory.createOperate(textBox2.Text);
            oper.NumberA = Convert.ToDouble(textBox1.Text);
            oper.NumberB = Convert.ToDouble(textBox3.Text);

            double result = oper.GetResult();
            label4.Text = "结果：" + result;
        }
    }
}