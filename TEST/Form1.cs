using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;
using System.Data;

namespace TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_TenMay_Leave(object sender, EventArgs e)
        {
            string tenMay = txt_TenMay.Text;
            if (string.IsNullOrEmpty(tenMay))
            {
                MessageBox.Show("Tên máy không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenMay.Focus();
            }                
        }

        private void txt_TenCSDL_TextChanged(object sender, EventArgs e)
        {
            string tenCSDL = txt_TenCSDL.Text;
            if (string.IsNullOrEmpty(tenCSDL))
            {
                MessageBox.Show("Tên csdl không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenCSDL.Focus();
            }                
        }

        private void btn_conn_Click(object sender, EventArgs e)
        {
            if (txt_TenMay.Text == "A209PC38" && txt_TenCSDL.Text == "BAI14" && txt_User.Text == "sa" && txt_PW.Text == "123")
            {
                SqlConnection conn = Bus_Layer.ConnectData();
                conn.Open();
                DialogResult r = MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK);
                if(r == DialogResult.OK)
                {
                    this.Hide();
                    frm_Main f = new frm_Main();
                    f.Show();                    
                }
            }
            else
                MessageBox.Show("Kết nối thất bại!");
        }
    }
}
