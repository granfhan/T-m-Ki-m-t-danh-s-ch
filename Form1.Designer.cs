namespace QuanLySinhVien
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
            this.dataGridviewSV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mssv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tensv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LopSV = new System.Windows.Forms.TextBox();
            this.TimKiem = new System.Windows.Forms.TextBox();
            this.TK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridviewSV
            // 
            this.dataGridviewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridviewSV.Location = new System.Drawing.Point(5, 24);
            this.dataGridviewSV.Name = "dataGridviewSV";
            this.dataGridviewSV.RowHeadersWidth = 51;
            this.dataGridviewSV.RowTemplate.Height = 24;
            this.dataGridviewSV.Size = new System.Drawing.Size(720, 356);
            this.dataGridviewSV.TabIndex = 0;
            this.dataGridviewSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = " Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = " Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 603);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = " Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mssv
            // 
            this.mssv.Location = new System.Drawing.Point(107, 433);
            this.mssv.Name = "mssv";
            this.mssv.Size = new System.Drawing.Size(225, 22);
            this.mssv.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = " Mã Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = " Tên";
            // 
            // tensv
            // 
            this.tensv.Location = new System.Drawing.Point(107, 475);
            this.tensv.Name = "tensv";
            this.tensv.Size = new System.Drawing.Size(225, 22);
            this.tensv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = " Lớp";
            // 
            // LopSV
            // 
            this.LopSV.Location = new System.Drawing.Point(107, 523);
            this.LopSV.Name = "LopSV";
            this.LopSV.Size = new System.Drawing.Size(225, 22);
            this.LopSV.TabIndex = 8;
            // 
            // TimKiem
            // 
            this.TimKiem.Location = new System.Drawing.Point(742, 24);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(198, 22);
            this.TimKiem.TabIndex = 10;
            this.TimKiem.Text = " ";
            this.TimKiem.TextChanged += new System.EventHandler(this.TimKiem_TextChanged);
            // 
            // TK
            // 
            this.TK.Location = new System.Drawing.Point(959, 22);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(75, 23);
            this.TK.TabIndex = 11;
            this.TK.Text = " Tra cứu";
            this.TK.UseVisualStyleBackColor = true;
            this.TK.Click += new System.EventHandler(this.TK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 649);
            this.Controls.Add(this.TK);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LopSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tensv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mssv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridviewSV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridviewSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox mssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tensv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LopSV;
        private System.Windows.Forms.TextBox TimKiem;
        private System.Windows.Forms.Button TK;
    }
}

