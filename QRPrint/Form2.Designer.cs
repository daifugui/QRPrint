namespace QRPrint
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_checker = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_target_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_no = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHECKER:";
            // 
            // tb_checker
            // 
            this.tb_checker.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_checker.Location = new System.Drawing.Point(291, 62);
            this.tb_checker.Name = "tb_checker";
            this.tb_checker.Size = new System.Drawing.Size(309, 53);
            this.tb_checker.TabIndex = 1;
            this.tb_checker.Text = "张三";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(128, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "目标数:";
            // 
            // tb_target_num
            // 
            this.tb_target_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_target_num.Location = new System.Drawing.Point(294, 161);
            this.tb_target_num.Name = "tb_target_num";
            this.tb_target_num.Size = new System.Drawing.Size(309, 53);
            this.tb_target_num.TabIndex = 1;
            this.tb_target_num.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.Location = new System.Drawing.Point(166, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "品号:";
            // 
            // tb_no
            // 
            this.tb_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_no.Location = new System.Drawing.Point(294, 277);
            this.tb_no.Name = "tb_no";
            this.tb_no.Size = new System.Drawing.Size(309, 53);
            this.tb_no.TabIndex = 1;
            this.tb_no.Text = "100010";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(475, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_no);
            this.Controls.Add(this.tb_target_num);
            this.Controls.Add(this.tb_checker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_checker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_target_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_no;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}