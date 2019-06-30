using QRPrint.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRPrint
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Settings.Default.Checker=this.tb_checker.Text;
            Settings.Default.Target_num= Convert.ToInt32(this.tb_target_num.Text);
            Settings.Default.No= tb_no.Text;
            Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.tb_checker.Text = Settings.Default.Checker;
            this.tb_target_num.Text = Settings.Default.Target_num.ToString();
            this.tb_no.Text = Settings.Default.No;
        }
    }
}
