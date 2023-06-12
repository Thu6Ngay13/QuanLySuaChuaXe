using System;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_KhachHang
    {
        DAL_Database database = null;
        public BLL_KhachHang()
        {
            database = new DAL_Database();
        }

        public DataSet LayKhachHang(string id_KhachHang)
        {
            string checkidkhachhang = ((id_KhachHang.Trim().Length > 0) ?
                       ("ID_KhachHang = '" + id_KhachHang + "' ") :
                       " ");

            string conditionwhere =
                    checkidkhachhang;

            conditionwhere = conditionwhere.Trim();
            conditionwhere = (conditionwhere.StartsWith("and") ? conditionwhere.Substring(3) : conditionwhere);

            string sqlwhere =
                (checkidkhachhang != " ") ? 
                "where " + conditionwhere :
                " ";

            string sqlString =
                "select * " +
                "from KhachHang " +
                sqlwhere;

            return database.executeQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet TimKhachHang(
            string id_KhachHang,
            string hoten_KhachHang,
            bool gioitinh_KhachHang,
            DateTime ngaysinh_KhachHang,
            string sodienthoai_KhachHang)
        {
            string nam = (gioitinh_KhachHang ? "1" : "0");
            string ngaysinh = ngaysinh_KhachHang.ToString("yyyy-MM-dd");

            string checkidkhachhang = ((id_KhachHang.Trim().Length > 0) ?
                        ("ID_KhachHang = '" + id_KhachHang + "' ") :
                        " ");
            string checkhotenkhachhang = ((hoten_KhachHang.Trim().Length > 0) ?
                        ("HoTen_KhachHang like N'%" + hoten_KhachHang + "%' ") :
                        " ");
            string checksodienthoaikhachhang = ((sodienthoai_KhachHang.Trim().Length > 0) ?
                        ("SoDienThoai_KhachHang = '" + sodienthoai_KhachHang + "' ") :
                        " ");

            string conditionwhere =
                    checkidkhachhang +
                    ((checkhotenkhachhang != " ") ? "and " : " ") + checkhotenkhachhang +
                    "and GioiTinh_KhachHang = " + nam + " " +
                    "and NgaySinh_KhachHang = '" + ngaysinh + "' " +
                    ((checksodienthoaikhachhang != " ") ? "and " : " ") + checksodienthoaikhachhang;

            conditionwhere = conditionwhere.Trim();
            conditionwhere = (conditionwhere.StartsWith("and") ? conditionwhere.Substring(3) : conditionwhere);

            string sqlwhere =
                "where " + conditionwhere;

            string sqlString =
                "select * " +
                "from KhachHang " +
                sqlwhere;

            return database.executeQueryDataSet(sqlString, CommandType.Text);
        }
        public bool ThemKhachHang(
            string id_KhachHang, 
            string hoten_KhachHang, 
            bool gioitinh_KhachHang,
            DateTime ngaysinh_KhachHang,
            string sodienthoai_KhacHang)
        {
            string nam = (gioitinh_KhachHang ? "1" : "0");
            string ngaysinh = ngaysinh_KhachHang.ToString("yyyy-MM-dd");

            string sqlString = 
                "Insert Into KhachHang Values " +
                "('" + id_KhachHang + "', " +
                "N'" + hoten_KhachHang + "', " +
                "" + nam + ", " +
                "'" + ngaysinh + "', " +
                "'" + sodienthoai_KhacHang + "')";
            return database.executeNonQuery(sqlString, CommandType.Text);
        }
        public bool XoaKhachHang(string id_KhachHang)
        {
            string sqlString = 
                "Delete From KhachHang " +
                "Where ID_KhachHang = '" + id_KhachHang + "'";
            return database.executeNonQuery(sqlString, CommandType.Text);
        }
        public bool CapNhatKhachHang(
            string id_KhachHang,
            string hoten_KhachHang,
            bool gioitinh_KhachHang,
            DateTime ngaysinh_KhachHang,
            string sodienthoai_KhacHang)
        {
            string nam = (gioitinh_KhachHang ? "1" : "0");
            string ngaysinh = ngaysinh_KhachHang.ToString("yyyy-MM-dd");

            string sqlString = 
                "Update KhachHang Set " +
                "HoTen_KhachHang = N'" + hoten_KhachHang + "', " +
                "GioiTinh_KhachHang = " + nam + ", " +
                "NgaySinh_KhachHang = '" + ngaysinh + "', " +
                "SoDienThoai_KhachHang = '" + sodienthoai_KhacHang + "' " +
                "Where ID_KhachHang = '" + id_KhachHang + "'";
            return database.executeNonQuery(sqlString, CommandType.Text);
        }
    }
  }
