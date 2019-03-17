namespace QuanLiKhachSan
{
    partial class dkthuephong
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbngaytao = new System.Windows.Forms.Label();
            this.datengaytao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lbmnv = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timengaydi = new System.Windows.Forms.DateTimePicker();
            this.timengayden = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.datengaydi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.datengayden = new System.Windows.Forms.DateTimePicker();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtmkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ghi chú: ";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(414, 66);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(349, 141);
            this.txtghichu.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(349, 66);
            this.button2.TabIndex = 11;
            this.button2.Text = "Đăng kí";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbngaytao
            // 
            this.lbngaytao.AutoSize = true;
            this.lbngaytao.Location = new System.Drawing.Point(352, 30);
            this.lbngaytao.Name = "lbngaytao";
            this.lbngaytao.Size = new System.Drawing.Size(53, 13);
            this.lbngaytao.TabIndex = 13;
            this.lbngaytao.Text = "Ngày tạo:";
            // 
            // datengaytao
            // 
            this.datengaytao.Enabled = false;
            this.datengaytao.Location = new System.Drawing.Point(414, 28);
            this.datengaytao.Name = "datengaytao";
            this.datengaytao.Size = new System.Drawing.Size(182, 20);
            this.datengaytao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(602, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã nhân viên tạo:";
            // 
            // lbmnv
            // 
            this.lbmnv.AutoSize = true;
            this.lbmnv.Location = new System.Drawing.Point(695, 30);
            this.lbmnv.Name = "lbmnv";
            this.lbmnv.Size = new System.Drawing.Size(13, 13);
            this.lbmnv.TabIndex = 15;
            this.lbmnv.Text = "1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(349, 57);
            this.button3.TabIndex = 16;
            this.button3.Text = "Trả Phòng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timengaydi);
            this.groupBox1.Controls.Add(this.timengayden);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.datengaydi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datengayden);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtmkh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 249);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng kí thuê";
            // 
            // timengaydi
            // 
            this.timengaydi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timengaydi.Location = new System.Drawing.Point(196, 209);
            this.timengaydi.Name = "timengaydi";
            this.timengaydi.Size = new System.Drawing.Size(122, 20);
            this.timengaydi.TabIndex = 19;
            // 
            // timengayden
            // 
            this.timengayden.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timengayden.Location = new System.Drawing.Point(196, 136);
            this.timengayden.Name = "timengayden";
            this.timengayden.Size = new System.Drawing.Size(122, 20);
            this.timengayden.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày đi (dự kiến) :";
            // 
            // datengaydi
            // 
            this.datengaydi.Location = new System.Drawing.Point(115, 183);
            this.datengaydi.Name = "datengaydi";
            this.datengaydi.Size = new System.Drawing.Size(203, 20);
            this.datengaydi.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày đến:";
            // 
            // datengayden
            // 
            this.datengayden.Location = new System.Drawing.Point(115, 110);
            this.datengayden.Name = "datengayden";
            this.datengayden.Size = new System.Drawing.Size(203, 20);
            this.datengayden.TabIndex = 14;
            // 
            // txttenkh
            // 
            this.txttenkh.Enabled = false;
            this.txttenkh.Location = new System.Drawing.Point(115, 71);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(203, 20);
            this.txttenkh.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên khách hàng: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtmkh
            // 
            this.txtmkh.Enabled = false;
            this.txtmkh.Location = new System.Drawing.Point(115, 36);
            this.txtmkh.Name = "txtmkh";
            this.txtmkh.Size = new System.Drawing.Size(122, 20);
            this.txtmkh.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã khách hàng: ";
            // 
            // dkthuephong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbmnv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbngaytao);
            this.Controls.Add(this.datengaytao);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "dkthuephong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dkthuephong";
            this.Load += new System.EventHandler(this.dkthuephong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbngaytao;
        private System.Windows.Forms.DateTimePicker datengaytao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbmnv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datengaydi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datengayden;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtmkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timengaydi;
        private System.Windows.Forms.DateTimePicker timengayden;
    }
}