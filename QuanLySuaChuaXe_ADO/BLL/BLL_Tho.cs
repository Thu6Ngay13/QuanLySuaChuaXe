using System;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_Tho
    {
        DAL_Database dal = null;

        public BLL_Tho()
        {
            dal = new DAL_Database();
        }

        public DataSet LayTho()
        {
            string sqlString = "select * from Tho";
            return dal.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet LayTho_CongViec(string id_CongViec)
        {
            string sqlString =
                "select Tho.ID_Tho, Tho.HoTen_Tho " +
                "from Tho " +
                "join KhaNang on KhaNang.ID_Tho = Tho.ID_Tho " +
                "join CongViec on CongViec.ID_CongViec = KhaNang.ID_CongViec " +
                "where CongViec.ID_CongViec = '" + id_CongViec + "'";

            return dal.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet LayTho_NhomTho(string id_NhomTho)
        {
            string sqlString =
                "select Tho.ID_Tho " +
                "from Tho " +
                "join NhomTho on NhomTho.ID_NhomTho = Tho.ID_NhomTho " +
                "where NhomTho.ID_NhomTho = '" + id_NhomTho + "'";

            return dal.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet LayTho_HopDong_CongViec(string id_HopDong, string id_CongViec)
        {
            string checkidhopdong = ((id_HopDong.Trim().Length > 0) ?
                        ("ID_HopDong = '" + id_HopDong + "' ") :
                        " ");
            string checkidcongviec = ((id_CongViec.Trim().Length > 0) ?
                        ("ID_CongViec = '" + id_CongViec + "' ") :
                        " ");

            string conditionwhere =
                    checkidhopdong +
                    ((checkidcongviec != " ") ? "and " : " ") + checkidcongviec;
            conditionwhere = conditionwhere.Trim();
            conditionwhere = (conditionwhere.StartsWith("and") ? conditionwhere.Substring(3) : conditionwhere);

            string sqlwhere =
                "where " + conditionwhere;

            string sqlString =
                "select Tho.ID_Tho, HoTen_Tho " +
                "from Tho " +
                "join ChiTietHopDong on ChiTietHopDong.ID_Tho = Tho.ID_Tho " +
                sqlwhere;

            return dal.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet TimKiemTho(
            string id_Tho,
            string hoten_Tho,
            bool gioitinh_Tho,
            DateTime ngaysinh_Tho,
            string diachi_Tho,
            string dieukien,
            float luong_Tho,
            string id_NhomTho)
        {
            string nam = (gioitinh_Tho ? "1" : "0");
            string ngaysinh = ngaysinh_Tho.ToString("yyyy-MM-dd");

            string checkidtho = ((id_Tho.Trim().Length > 0) ?
                        ("ID_Tho = '" + id_Tho + "' ") :
                        " ");
            string checkhotentho = ((hoten_Tho.Trim().Length > 0) ?
                        ("HoTen_Tho like N'%" + hoten_Tho + "%' ") :
                        " ");
            string checkdiachiatho = ((diachi_Tho.Trim().Length > 0) ?
                        ("DiaChi_Tho like N'%" + diachi_Tho + "%' ") :
                        " ");
            string checkidnhomtho = ((id_NhomTho.Trim().Length > 0) ?
                        ("ID_NhomTho = '" + id_NhomTho + "' ") :
                        " ");

            string conditionwhere =
                    checkidtho +
                    ((checkhotentho != " ") ? "and " : " ") + checkhotentho +
                    "and GioiTinh_Tho = " + nam + " " +
                    "and NgaySinh_Tho = '" + ngaysinh + "' " +
                    ((checkdiachiatho != " ") ? "and " : " ") + checkdiachiatho +
                    "and Luong_Tho " + dieukien + " " + luong_Tho +
                    ((checkidnhomtho != " ") ? "and " : " ") + checkidnhomtho;
            conditionwhere = conditionwhere.Trim();
            conditionwhere = (conditionwhere.StartsWith("and") ? conditionwhere.Substring(3) : conditionwhere);

            string sqlwhere = 
                "where " + conditionwhere;

            string sqlString =
                "select * " +
                "from Tho " +
                sqlwhere;

            return dal.executeQueryDataSet(sqlString, CommandType.Text);
        }
        public bool ThemTho(
            string id_Tho,
            string hoten_Tho,
            bool gioitinh_Tho,
            DateTime ngaysinh_Tho,
            string diachi_Tho,
            float luong_Tho,
            string id_NhomTho)
        {
            string nam = (gioitinh_Tho ? "1" : "0");
            string ngaysinh = ngaysinh_Tho.ToString("yyyy-MM-dd");

            string stringSQL =
                "INSERT INTO Tho VALUES " +
                "('" + id_Tho + "', " +
                "N'" + hoten_Tho + "', " +
                "" + nam + ", " +
                "'" + ngaysinh + "' , " +
                "N'" + diachi_Tho + "', " +
                "'" + luong_Tho + "', " +
                "'" + id_NhomTho + "')";

            return dal.executeNonQuery(stringSQL, CommandType.Text);
        }
        public bool XoaTho(string id_Tho)
        {
            string sqlString = 
                "Delete From Tho " +
                "Where ID_Tho = '" + id_Tho + "'";
            return dal.executeNonQuery(sqlString, CommandType.Text);

        }
        public bool CapNhatTho(
            string id_Tho, 
            string hoten_Tho, 
            bool gioitinh_Tho, 
            DateTime ngaysinh_Tho, 
            string diachi_Tho, 
            float luong_Tho, 
            string id_NhomTho)
        {
            string nam = (gioitinh_Tho ? "1" : "0");
            string ngaysinh = ngaysinh_Tho.ToString("yyyy-MM-dd");

            string sqlString = 
                "Update Tho Set " +
                    "HoTen_Tho = N'" + hoten_Tho + "', " +
                    "GioiTinh_Tho = " + nam + ", " +
                    "NgaySinh_Tho = '" + ngaysinh + "', " +
                    "DiaChi_Tho = N'" + diachi_Tho + "', " +
                    "Luong_Tho = " + luong_Tho + ", "  +
                    "ID_NhomTho = '" + id_NhomTho + "' " +
                "Where ID_Tho = '" + id_Tho + "'";
            return dal.executeNonQuery(sqlString, CommandType.Text);
        }

        public bool CapNhatTho_ID_Tho(string id_Tho)
        {
            string sqlString =
                "Update Tho Set " +
                    "ID_NhomTho = null " +
                "Where ID_Tho = '" + id_Tho + "'";
            return dal.executeNonQuery(sqlString, CommandType.Text);
        }
    }

}