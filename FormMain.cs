﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            //Bắt buộc để try catch để kiểm tra lỗi khi sử lý với DataBase
            try
            {
                dataGridView1.LoadDataSource("tblKhachHang");
                comboBox1.LoadDataSource("tblMang", "sTenMang", "sMoTa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //thêm
        private void button1_Click(object sender, EventArgs e)
        {
            //Bắt buộc để try catch để kiểm tra lỗi khi sử lý với DataBase
            try
            {
                //Nên viết thứ tự parameter theo tứ tự trong DataBase
                DBConnection.Instance.InsertDB("tblKhachHang", "sp_ThemKhachHang",
                new SqlParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen") { Value = "test2" },
                new SqlParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai") { Value = "test2" },
                new SqlParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi") { Value = "test2" }, 
                new SqlParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail") { Value = "test2" });
                DBConnection.Instance.SelectDB("tblKhachHang");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //sửa
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Nên viết thứ tự parameter theo tứ tự trong DataBase
                DBConnection.Instance.UpdateDB("tblKhachHang",
                new SqlParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang") { Value = dataGridView1.CurrentRow.Cells[0].Value },
                new SqlParameter("@sHoTen", SqlDbType.Bit, 0, "sHoTen") { Value = "test434" },
                new SqlParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai") { Value = "test2" },
                new SqlParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi") { Value = "test2" },
                new SqlParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail") { Value = "test2" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //tìm
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = dataGridView1.DataSource as DataView;
                dataView.AddRowFilter($"sHoTen LIKE '%{textBox1.Text}%'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //xóa
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Nên viết thứ tự parameter theo tứ tự trong DataBase
                DBConnection.Instance.UpdateDB("tblKhachHang",
                new SqlParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang") { Value = dataGridView1.CurrentRow.Cells[0].Value },
                new SqlParameter("@bDeleted", SqlDbType.Bit, 0, "bDeleted") { Value = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            MessageBox.Show(comboBox.SelectedValue.ToString());
        }
    }
}
