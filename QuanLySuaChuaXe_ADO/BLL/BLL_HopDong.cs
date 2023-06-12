using System;
using System.Data;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class BLL_HopDong
    {
        DAL_Database database = null;

        public BLL_HopDong()
        {
            database = new DAL_Database();
        }

        public DataSet LayHopDong()
        {
            return database.executeQueryDataSet("select * from HopDong", CommandType.Text);
        }

        public DataSet TimHopDong_Xe(string id_Xe)
        {
            string sqlString =
                "select HopDong.ID_HopDong " +
                "from HopDong " +
                "join Xe on Xe.ID_Xe = HopDong.ID_Xe " +
                "where Xe.ID_Xe = '" + id_Xe + "'";

            return database.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet TimHopDong_Xe_KhachHang(
            string ten_HopDong,
            DateTime ngaybatdau_HopDong,
            string dieukien,
            float giatri_HopDong,
            string hoten_KhachHang,
            DateTime ngaysinh_KhachHang,
            bool gioitinh_KhachHang,
            string id_Xe,
            string sodienthoai_KhachHang)
        {
            string nam = (gioitinh_KhachHang ? "1" : "0");
            string ngaybatdau = ngaybatdau_HopDong.ToString("yyyy-MM-dd");
            string ngaysinh = ngaysinh_KhachHang.ToString("yyyy-MM-dd");

            string checkhopdong = ((ten_HopDong.Trim().Length > 0) ?
                        ("Ten_HopDong like N'%" + ten_HopDong + "%' ") :
                        " ");
            string checkhoten = ((hoten_KhachHang.Trim().Length > 0) ?
                        ("and HoTen_KhachHang like N'%" + hoten_KhachHang + "%' ") :
                        " ");
            string checkidxe = ((id_Xe.Trim().Length > 0) ?
                        ("and ID_Xe = '%" + id_Xe + "%' ") :
                        " ");
            string checksodienthoai = ((sodienthoai_KhachHang.Trim().Length > 0) ?
                        ("and SoDienThoai_KhachHang = '%" + sodienthoai_KhachHang + "%' ") :
                        " ");

            string conditionwhere =
                    checkhopdong +
                    ((checkhopdong != " ") ? "and " : "") + "DATEDIFF(day, " + ngaybatdau + ", NgayBatDau_HopDong) >= 0 " +
                    "and GiaTri_HopDong " + dieukien + " " + giatri_HopDong + " " +
                    checkhoten +
                    "and NgaySinh_KhachHang = '" + ngaysinh + "' " +
                    "and GioiTinh_KhachHang = " + nam + " " +
                    checkidxe +
                    checksodienthoai;
            conditionwhere = conditionwhere.Trim();
            conditionwhere = (conditionwhere.StartsWith("and") ? conditionwhere.Substring(3) : conditionwhere);

            string sqlwhere =
                "where " + conditionwhere;

            string sqlString =
                "select ID_HopDong, " +
                    "Ten_HopDong, " +
                    "NgayBatDau_HopDong, " +
                    "NgayKetThuc_HopDong, " +
                    "GiaTri_HopDong, " +
                    "Xe.ID_Xe " +
                "from HopDong " +
                "join Xe on Xe.ID_Xe = HopDong.ID_Xe " +
                "join KhachHang on KhachHang.ID_KhachHang = xe.ID_KhachHang " +
                sqlwhere;

            return database.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public bool ThemHopDong(
            string id_HopDong, 
            string ten_HopDong, 
            DateTime ngaybatdau_HopDong, 
            DateTime ngayketthuc_HopDong, 
            float giatri_HopDong, 
            string id_Xe)
        {
            string ngaybatdau = ngaybatdau_HopDong.ToString("yyyy-MM-dd");
            string ngayketthuc = ngayketthuc_HopDong.ToString("yyyy-MM-dd");

            string sqlString = 
                "Insert Into HopDong Values" +
                "('" + id_HopDong + "', " +
                "N'" + ten_HopDong + "', " +
                "'" + ngaybatdau + "', " +
                "'" + ngayketthuc + "', " +
                "" + giatri_HopDong + ", " +
                "N'" + id_Xe + "')";
            return database.executeNonQuery(sqlString, CommandType.Text);
        }
        public bool XoaHopDong(string id_HopDong)
        {
            string sqlString = 
                "Delete From HopDong " +
                "Where id_HopDong = '" + id_HopDong + "'";
            return database.executeNonQuery(sqlString, CommandType.Text);
        }

        public bool CapNhatHopDong(
            string id_HopDong,
            string ten_HopDong,
            DateTime ngaybatdau_HopDong,
            DateTime ngayketthuc_HopDong,
            float giatri_HopDong,
            string id_Xe)
        {
            string ngaybatdau = ngaybatdau_HopDong.ToString("yyyy-MM-dd");
            string ngayketthuc = ngayketthuc_HopDong.ToString("yyyy-MM-dd");

            string sqlString = 
                "Update HopDong Set " +
                    "Ten_HopDong = N'" + ten_HopDong + "', " +
                    "NgayBatDau_HopDong = '" + ngaybatdau + "', " +
                    "NgayKetThuc_HopDong = '" + ngayketthuc + "', " +
                    "GiaTri_HopDong = " + giatri_HopDong + ", " +
                    "ID_Xe = '" + id_Xe + "' " + 
                "Where ID_HopDong = '" + id_HopDong + "'";
            return database.executeNonQuery(sqlString, CommandType.Text);
        }
    }
}
