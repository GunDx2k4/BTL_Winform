using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public class Example
    {
        //thêm
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Instance.InsertDB("tblKhachHang", "sp_ThemKhachHang",
                new SqlParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen") { Value = "133" },
                new SqlParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai") { Value = "123" },
                new SqlParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi") { Value = "123" },
                new SqlParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail") { Value = "123" });
                DBConnection.Instance.SelectDB("tblKhachHang");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //sửa
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Nên viết thứ tự parameter theo tứ tự trong DataBase
                DBConnection.Instance.UpdateDB("tblKhachHang",
                new SqlParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang") { Value = 123 },
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

        //xóa
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Nên viết thứ tự parameter theo tứ tự trong DataBase
                DBConnection.Instance.UpdateDB("tblKhachHang",
                new SqlParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang") { Value = 123 },
                new SqlParameter("@bDeleted", SqlDbType.Bit, 0, "bDeleted") { Value = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //tìm
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = /*dtThongTinCTHoaDon.DataSource bỏ sender đi thay bằng datagridview cần tìm*/sender as DataView;
                dataView.AddRowFilter($"bDeleted=0 AND  sHoTen LIKE '%abcxyz%'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
