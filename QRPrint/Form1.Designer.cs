namespace QRPrint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_e_no = new System.Windows.Forms.TextBox();
            this.tb_target_num = new System.Windows.Forms.TextBox();
            this.tb_checker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_finished_num = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_dt = new System.Windows.Forms.Label();
            this.tb_i_no = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.manageToolStripMenuItem.Text = "后台管理";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox1.Location = new System.Drawing.Point(585, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(215, 232);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "\r\nNG";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_e_no
            // 
            this.tb_e_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_e_no.Location = new System.Drawing.Point(209, 148);
            this.tb_e_no.Name = "tb_e_no";
            this.tb_e_no.ReadOnly = true;
            this.tb_e_no.Size = new System.Drawing.Size(357, 53);
            this.tb_e_no.TabIndex = 5;
            this.tb_e_no.TabStop = false;
            this.tb_e_no.Text = "100010";
            // 
            // tb_target_num
            // 
            this.tb_target_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_target_num.Location = new System.Drawing.Point(194, 236);
            this.tb_target_num.Name = "tb_target_num";
            this.tb_target_num.ReadOnly = true;
            this.tb_target_num.Size = new System.Drawing.Size(163, 53);
            this.tb_target_num.TabIndex = 6;
            this.tb_target_num.TabStop = false;
            this.tb_target_num.Text = "100";
            // 
            // tb_checker
            // 
            this.tb_checker.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_checker.Location = new System.Drawing.Point(657, 368);
            this.tb_checker.Name = "tb_checker";
            this.tb_checker.ReadOnly = true;
            this.tb_checker.Size = new System.Drawing.Size(154, 53);
            this.tb_checker.TabIndex = 7;
            this.tb_checker.TabStop = false;
            this.tb_checker.Text = "张三";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "期望品号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(37, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "目标数:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(471, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Checker:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.Location = new System.Drawing.Point(37, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "完成数:";
            // 
            // tb_finished_num
            // 
            this.tb_finished_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_finished_num.Location = new System.Drawing.Point(194, 295);
            this.tb_finished_num.Name = "tb_finished_num";
            this.tb_finished_num.ReadOnly = true;
            this.tb_finished_num.Size = new System.Drawing.Size(163, 53);
            this.tb_finished_num.TabIndex = 6;
            this.tb_finished_num.TabStop = false;
            this.tb_finished_num.Text = "10";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_dt
            // 
            this.lb_dt.AutoSize = true;
            this.lb_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_dt.Location = new System.Drawing.Point(492, 444);
            this.lb_dt.Name = "lb_dt";
            this.lb_dt.Size = new System.Drawing.Size(265, 31);
            this.lb_dt.TabIndex = 8;
            this.lb_dt.Text = "2019-06-30 18:23:56";
            // 
            // tb_i_no
            // 
            this.tb_i_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_i_no.Location = new System.Drawing.Point(209, 67);
            this.tb_i_no.Name = "tb_i_no";
            this.tb_i_no.ReadOnly = true;
            this.tb_i_no.Size = new System.Drawing.Size(357, 53);
            this.tb_i_no.TabIndex = 10;
            this.tb_i_no.TabStop = false;
            this.tb_i_no.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "扫描品号:";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("SimSun", 40F);
            this.label6.Location = new System.Drawing.Point(45, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 54);
            this.label6.TabIndex = 11;
            this.label6.Text = "目标未完成";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 487);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_i_no);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_dt);
            this.Controls.Add(this.tb_e_no);
            this.Controls.Add(this.tb_finished_num);
            this.Controls.Add(this.tb_target_num);
            this.Controls.Add(this.tb_checker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_e_no;
        private System.Windows.Forms.TextBox tb_target_num;
        private System.Windows.Forms.TextBox tb_checker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_finished_num;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_dt;
        private System.Windows.Forms.TextBox tb_i_no;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.Label label6;
    }
}

