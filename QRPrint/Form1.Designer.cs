﻿namespace QRPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label7 = new System.Windows.Forms.Label();
            this.tb_e_no_0 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_i_no_0 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
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
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 21);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Visible = false;
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.textBox1.Location = new System.Drawing.Point(720, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(283, 272);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "\r\nNG";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_e_no
            // 
            this.tb_e_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tb_e_no.Location = new System.Drawing.Point(280, 264);
            this.tb_e_no.Name = "tb_e_no";
            this.tb_e_no.ReadOnly = true;
            this.tb_e_no.Size = new System.Drawing.Size(427, 68);
            this.tb_e_no.TabIndex = 5;
            this.tb_e_no.TabStop = false;
            this.tb_e_no.Text = "100010";
            // 
            // tb_target_num
            // 
            this.tb_target_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tb_target_num.Location = new System.Drawing.Point(280, 349);
            this.tb_target_num.Name = "tb_target_num";
            this.tb_target_num.ReadOnly = true;
            this.tb_target_num.Size = new System.Drawing.Size(163, 68);
            this.tb_target_num.TabIndex = 6;
            this.tb_target_num.TabStop = false;
            this.tb_target_num.Text = "100";
            // 
            // tb_checker
            // 
            this.tb_checker.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tb_checker.Location = new System.Drawing.Point(829, 615);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label3.Location = new System.Drawing.Point(16, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 63);
            this.label3.TabIndex = 2;
            this.label3.Text = "期望品号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label2.Location = new System.Drawing.Point(70, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "目标数:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(596, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHECKER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label4.Location = new System.Drawing.Point(70, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 63);
            this.label4.TabIndex = 3;
            this.label4.Text = "完成数:";
            // 
            // tb_finished_num
            // 
            this.tb_finished_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tb_finished_num.Location = new System.Drawing.Point(280, 423);
            this.tb_finished_num.Name = "tb_finished_num";
            this.tb_finished_num.ReadOnly = true;
            this.tb_finished_num.Size = new System.Drawing.Size(163, 68);
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
            this.lb_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lb_dt.Location = new System.Drawing.Point(596, 675);
            this.lb_dt.Name = "lb_dt";
            this.lb_dt.Size = new System.Drawing.Size(387, 46);
            this.lb_dt.TabIndex = 8;
            this.lb_dt.Text = "2019-06-30 18:23:56";
            // 
            // tb_i_no
            // 
            this.tb_i_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tb_i_no.Location = new System.Drawing.Point(280, 190);
            this.tb_i_no.Name = "tb_i_no";
            this.tb_i_no.ReadOnly = true;
            this.tb_i_no.Size = new System.Drawing.Size(427, 68);
            this.tb_i_no.TabIndex = 10;
            this.tb_i_no.TabStop = false;
            this.tb_i_no.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label5.Location = new System.Drawing.Point(16, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 63);
            this.label5.TabIndex = 9;
            this.label5.Text = "扫描品号:";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM12";
            // 
            // serialPort3
            // 
            this.serialPort3.PortName = "COM3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("SimSun", 60F);
            this.label6.Location = new System.Drawing.Point(35, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 80);
            this.label6.TabIndex = 11;
            this.label6.Text = "目标未完成";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label7.Location = new System.Drawing.Point(16, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 63);
            this.label7.TabIndex = 2;
            this.label7.Text = "期望代码:";
            // 
            // tb_e_no_0
            // 
            this.tb_e_no_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tb_e_no_0.Location = new System.Drawing.Point(280, 116);
            this.tb_e_no_0.Name = "tb_e_no_0";
            this.tb_e_no_0.ReadOnly = true;
            this.tb_e_no_0.Size = new System.Drawing.Size(427, 68);
            this.tb_e_no_0.TabIndex = 5;
            this.tb_e_no_0.TabStop = false;
            this.tb_e_no_0.Text = "100010";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label8.Location = new System.Drawing.Point(16, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 63);
            this.label8.TabIndex = 9;
            this.label8.Text = "扫描代码:";
            // 
            // tb_i_no_0
            // 
            this.tb_i_no_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tb_i_no_0.Location = new System.Drawing.Point(280, 42);
            this.tb_i_no_0.Name = "tb_i_no_0";
            this.tb_i_no_0.ReadOnly = true;
            this.tb_i_no_0.Size = new System.Drawing.Size(427, 68);
            this.tb_i_no_0.TabIndex = 10;
            this.tb_i_no_0.TabStop = false;
            this.tb_i_no_0.Text = "100";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("SimSun", 32F);
            this.button1.Location = new System.Drawing.Point(756, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 60);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.Text = "复位";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_i_no_0);
            this.Controls.Add(this.tb_i_no);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_e_no_0);
            this.Controls.Add(this.lb_dt);
            this.Controls.Add(this.tb_e_no);
            this.Controls.Add(this.tb_finished_num);
            this.Controls.Add(this.tb_target_num);
            this.Controls.Add(this.tb_checker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "QRPrint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_e_no_0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_i_no_0;
        private System.Windows.Forms.Button button1;
    }
}

