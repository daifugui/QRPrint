using QRPrint.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                
                if(!(tb_e_no.Text).Equals(Settings.Default.No)|| !this.tb_checker.Text.Equals(Settings.Default.Checker))
                {
                    this.tb_finished_num.Text = "0";
                    Settings.Default.Finished_num = 0;
                    Settings.Default.Save();
                    this.tb_i_no.Text = "";
                    this.label6.Text = "";
                }
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
                this.tb_i_no.Text = "";
                this.label6.Text = "";
            }

            this.tb_checker.Text = Settings.Default.Checker;
            this.tb_e_no.Text = Settings.Default.No;
            this.tb_target_num.Text = Settings.Default.Target_num.ToString();            
            this.tb_finished_num.Text = Settings.Default.Finished_num.ToString();


            GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(this.textBox1.ClientRectangle);
            path.AddEllipse(this.textBox1.ClientRectangle.X + 3, this.textBox1.ClientRectangle.Y + 3, this.textBox1.ClientRectangle.Width - 6, this.textBox1.ClientRectangle.Height - 6);
            this.textBox1.Region = new Region(path);
            try
            {
                serialPort2.Open();
                serialPort3.Open();
            }
            catch 
            {
                MessageBox.Show("serial port open error!!!");
            }
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
                this.tb_i_no.Text = "";
                this.label6.Text = "";
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


        private static string Chinese2ZPLStringxxx(string css)
        { //13,13,8
            int sn = css.Length;
            Bitmap bmp = new Bitmap(13 * sn, 13);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
                Font drawFont = new Font("Arial", 8);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                g.DrawString(css, drawFont, drawBrush, 0, 0);
            }
            Color srcColor;
            int wide = bmp.Width;
            int height = bmp.Height;
            string cssHex = "\r\n";
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < wide; x++)
                {
                    srcColor = bmp.GetPixel(x, y);
                    cssHex += srcColor.R.ToString("X2");
                }
                cssHex += "\r\n";
            }

            bmp.Dispose();

            string ss1 = "~DGcName," + (wide * height).ToString() + "," + wide.ToString() + "," + cssHex;
            return ss1;
        }


        private static string Chinese2ZPLString(string css)
        {
            int sn = css.Length;
            Bitmap bmp = new Bitmap(64 * sn, 60);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
                Font drawFont = new Font("Arial", 40);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                g.DrawString(css, drawFont, drawBrush, 0, 0);
            }
           
            Color srcColor;
            int wide = bmp.Width;
            int height = bmp.Height;
            string cssHex = "\r\n";
            for (int y = 0; y < height; y++)
            {
                int k = 0;
                int s = 0;
                for (int x = 0; x < wide; x++)
                {
                    srcColor = bmp.GetPixel(x, y);
                    // cssHex += srcColor.R.ToString("X2");
                    s = s << 1;
                    s = s | (srcColor.R > 0 ? 1 : 0);
                    k++;
                    if (k % 8 == 0)
                    {
                        cssHex += (s & 0xff).ToString("X2");
                        s = 0;
                    }
                }
                cssHex += "\r\n";
              
            }

            //  bmp.Dispose();

            string ss1 = "~DGcName," + (wide / 8 * height).ToString() + "," + (wide / 8).ToString() + "," + cssHex;
            return ss1;
        }

  
        private static string ZPLWriteChineseSS(int px, int py, string css)
        {
            string css1 = Chinese2ZPLString(css);
            return css1 + "^FT" + px.ToString() + "," + py.ToString() + "^XGcName,1,1^FS\r\n";
        }
        static bool ContainChinese(string input)
        {
            string pattern = "[\u4e00-\u9fbb]";
            return Regex.IsMatch(input, pattern);
        }

        private void printlabel()
        {
            if (ContainChinese(tb_checker.Text))
            {
                string print_com_ss = "^XA\r\n"
                                 + "^FT300,150^A0N,150,150^FD" + "OK" + "^FS\r\n"
                                 + "^FT150,220^A0N,50,50^FD" + "CHECKER:" + "^FS\r\n"
                                 + ZPLWriteChineseSS(360,240, tb_checker.Text)
                                 + "^FT150,300^A0N,50,50^FD" + "TRACE NO.:" + tb_e_no.Text + "^FS\r\n"
                                 + "^FT350,365^A0N,50,50^FD" + "INFAC" + "^FS\r\n"
                                + "^XZ";
                serialPort3.WriteLine(print_com_ss);
            }
            else
            {
                string print_com_ss = "^XA\r\n"
                                  + "^FT300,150^A0N,150,150^FD" + "OK" + "^FS\r\n"
                                  + "^FT150,220^A0N,50,50^FD" + "CHECKER:" + tb_checker.Text + "^FS\r\n"
                                  + "^FT150,300^A0N,50,50^FD" + "TRACE NO.:" + tb_e_no.Text + "^FS\r\n"
                                  + "^FT350,365^A0N,50,50^FD" + "INFAC" + "^FS\r\n"
                                 + "^XZ";
                serialPort3.WriteLine(print_com_ss);

            }

        }

        void backupcode()
        {
            string print_com_ss = "^XA^CW1,ANMDJ.TTF^CI28\r\n"
                                     + "^FT300,150^A0N,150,150^FD" + "OK" + "^FS\r\n"
                                     + "^FT150,220^A0N,50,50^FD" + "CHECKER:" + tb_checker.Text + "^FS\r\n"
                                     + "^FT150,300^A0N,50,50^FD" + "TRACE NO.:" + tb_e_no.Text + "^FS\r\n"
                                     + "^FT350,365^A0N,50,50^FD" + "INFAC" + "^FS\r\n"
                                    + "^XZ";
            //CW1,SIMSUN.TTF
            //SIMSUM.FNT
            // string print_com_ss1 = "^XA^CWJ,E:MSUNG.FNT^FS\r\n"
            //string print_com_ss1 = "^XA^CWJ,E:SIMSUN.FNT^FS\r\n"
            string print_com_ss1 = "^XA^CW1,E:SIMSUN.TTF^FS\r\n"
            + "^FT300,150^A0N,150,150^CI17^F8^FD" + "张三" + "^FS\r\n"
            + "^FT300,250^A0N,150,150^CI28^FD" + "张三" + "^FS\r\n"
                          //      + "^FO220,250^A@B,45,45,E:SIMSUN.FNT^CI17^F8^FD样张名称:^FS\r\n"
                          //  + "^FT150,220^A0N,50,50^FD" + "CHECKER:" + tb_checker.Text + "^FS\r\n"
                          //+ "^FT150,300^A0N,50,50^FD" + "TRACE NO.:" + tb_e_no.Text + "^FS\r\n"
                          // + "^FT350,365^A0N,50,50^FD" + "INFAC" + "^FS\r\n"
                          + "^XZ";
            serialPort3.WriteLine(print_com_ss1);
        }
        List<char> list_ss = new List<char>();
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this.Text = e.KeyChar.ToString();
            char cc = e.KeyChar;
            if (cc == '\r')
            {
                this.tb_i_no.Text = new string(list_ss.ToArray());
                list_ss.Clear();
                //if (list_ss.Count() != 0)
                if(!string.IsNullOrEmpty(tb_i_no.Text))
                {
                    if (tb_i_no.Text.Equals(tb_e_no.Text))
                    {
                        // int tn = Convert.ToInt32(this.tb_finished_num.Text);
                        // tn++;
                        //this.tb_finished_num.Text = tn.ToString();
                        Settings.Default.Finished_num++;
                        Settings.Default.Last_test_day = DateTime.Now.ToString("yyyy-MM-dd");
                        Settings.Default.Save();
                        this.tb_finished_num.Text = Settings.Default.Finished_num.ToString();
                        this.textBox1.Text = "\r\nOK";
                        this.textBox1.BackColor = Color.Green;
                        byte[] sendbuf = { 0x7e, 0x05,0x41,0x00,0x01,0x45,0xef };
                        serialPort2.Write(sendbuf, 0, 7);


                        if (Settings.Default.Finished_num == Settings.Default.Target_num)
                        {
                            this.label6.BackColor = Color.Green;
                            this.label6.Text = "目标已完成";
                            //printlabel();
                            byte[] sendbuf1 = { 0x7e, 0x05, 0x41, 0x00, 0x03, 0x47, 0xef };
                            serialPort2.Write(sendbuf1, 0, 7);
                            for(int i=0;i< Settings.Default.Print_num;i++)
                                 printlabel();
                            //MessageBox.Show("目标已完成！！！");
                        }
                        else if (Settings.Default.Finished_num > Settings.Default.Target_num)
                        {
                            Settings.Default.Finished_num = 1;
                            Settings.Default.Save();
                            this.tb_finished_num.Text = Settings.Default.Finished_num.ToString();
                            this.label6.BackColor = Color.Red;
                            this.label6.Text = "目标未完成";
                        }
                        else
                        {
                            this.label6.BackColor = Color.Red;
                            this.label6.Text = "目标未完成";

                        }


                    }
                    else
                    {
                        this.textBox1.Text = "\r\nNG";
                        this.textBox1.BackColor = Color.Red;
                        byte[] sendbuf = { 0x7e, 0x05, 0x41, 0x00, 0x02, 0x46, 0xef };
                        serialPort2.Write(sendbuf, 0, 7);
                    }
                    

                }
            }
            else
            {
                list_ss.Add(cc);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort2.Close();
            serialPort3.Close();
        }
    }
}
