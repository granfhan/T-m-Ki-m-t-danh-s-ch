using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {

        public class SinhVien
        {
            public string MaSinhVien { get; set; }
            public string HoTen { get; set; }
            public string LopHoc { get; set; }
        } 

        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void HienThiDanhSach()
        {
            dataGridviewSV.DataSource = null;
            dataGridviewSV.DataSource = danhSachSinhVien;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSinhVien = mssv.Text,
                HoTen = tensv.Text,
                LopHoc = LopSV.Text
            };
            danhSachSinhVien.Add(sv);
            HienThiDanhSach();
            xoa();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridviewSV.CurrentRow != null)
            {
                mssv.Text = dataGridviewSV.CurrentRow.Cells[0].Value.ToString();
                tensv.Text = dataGridviewSV.CurrentRow.Cells[1].Value.ToString();
                LopSV.Text = dataGridviewSV.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void xoa()
        {
            mssv.Clear();
            tensv.Clear();
            LopSV.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridviewSV.CurrentRow != null)
            {
                int index = dataGridviewSV.CurrentRow.Index;
                danhSachSinhVien[index].MaSinhVien = mssv.Text;
                danhSachSinhVien[index].HoTen = tensv.Text;
                danhSachSinhVien[index].LopHoc = LopSV.Text;
                HienThiDanhSach();
                xoa();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridviewSV.CurrentRow != null)
            {
                int index = dataGridviewSV.CurrentRow.Index;
                danhSachSinhVien.RemoveAt(index);
                HienThiDanhSach();
                xoa();
            }
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void TK_Click(object sender, EventArgs e)
        {
            string mssvCanTim = TimKiem.Text;
            SinhVien sinhVien = danhSachSinhVien.FirstOrDefault(sv => sv.MaSinhVien == mssvCanTim);

            if (sinhVien != null)
            {
                MessageBox.Show($"Tìm thấy sinh viên:\nMSV: {sinhVien.MaSinhVien}\nHọ tên: {sinhVien.HoTen}\nLớp: {sinhVien.LopHoc}", "Kết quả tìm kiếm");
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với MSSV này.", "Kết quả tìm kiếm");
            }

        }
    }
}
