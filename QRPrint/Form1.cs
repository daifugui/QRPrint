using QRPrint.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                this.tb_checker.Text = Settings.Default.Checker;
                this.tb_target_num.Text = Settings.Default.Target_num.ToString();
                this.tb_e_no.Text = Settings.Default.No;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       

            string nowdate=DateTime.Now.ToString("yyyy-MM-dd");
            string last_test_date = Settings.Default.Last_test_day;
            if (!nowdate.Equals(last_test_date))
            {
                this.tb_finished_num.Text = "0";
                Settings.Default.Finished_num = 0;
                Settings.Default.Save();
            }

            this.tb_checker.Text = Settings.Default.Checker;
            this.tb_e_no.Text = Settings.Default.No;
            this.tb_target_num.Text = Settings.Default.Target_num.ToString();            
            this.tb_finished_num.Text = Settings.Default.Finished_num.ToString();


            GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(this.textBox1.ClientRectangle);
            path.AddEllipse(this.textBox1.ClientRectangle.X + 3, this.textBox1.ClientRectangle.Y + 3, this.textBox1.ClientRectangle.Width - 6, this.textBox1.ClientRectangle.Height - 6);
            this.textBox1.Region = new Region(path);
           // textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lb_dt.Text=DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            string nowdate = DateTime.Now.ToString("yyyy-MM-dd");
            string last_test_date = Settings.Default.Last_test_day;
            if (!nowdate.Equals(last_test_date))
            {
                this.tb_finished_num.Text = "0";
                Settings.Default.Finished_num = 0;
                Settings.Default.Save();
            }

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                serialPort1.NewLine = "\r\n"; // test sscom \r\n  , \r really software 
                string ss = serialPort1.ReadLine();
                if (!string.IsNullOrEmpty(ss))
                {
                   // ss = ss.Substring(2); // remove 02 15
                   // this.Invoke(new InvokeHandler(delegate ()
                  //  {
                    this.tb_i_no.Text = ss;
                    if (tb_i_no.Text.Equals(tb_e_no.Text))
                    {
                       // int tn = Convert.ToInt32(this.tb_finished_num.Text);
                       // tn++;
                        //this.tb_finished_num.Text = tn.ToString();
                        Settings.Default.Finished_num++;
                        Settings.Default.Last_test_day= DateTime.Now.ToString("yyyy-MM-dd");
                        Settings.Default.Save();
                        this.tb_finished_num.Text = Settings.Default.Finished_num.ToString();



                    }
                       
                     



                 //   }));
                }

            }
            catch
            {
                ;
            }
        }
    }
}
