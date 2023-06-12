using System;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_PhieuThu
    {
        DAL_Database dal = null;
        
        public BLL_PhieuThu()
        {
            dal = new DAL_Database();
        }

        public DataSet LayPhieuThu()
        {
            string stringSQL = "select * from PhieuThu";
            return dal.executeQueryDataSet(stringSQL, CommandType.Text);
        }

        public DataSet TimPhieuThu_HopDong(string id_HopDong)
        {
            string stringSQL = 
                "select PhieuThu.ID_PhieuThu " +
                "from PhieuThu " +
                "join HopDong on HopDong.ID_HopDong = PhieuThu.ID_HopDong " +
                "where HopDong.ID_HopDong = '" + id_HopDong + "'";
            return dal.executeQueryDataSet(stringSQL, CommandType.Text);
        }

        public bool ThemPhieuThu(
            string id_HopDong,
            DateTime ngaythu_PhieuThu,
            string id_PhieuThu, 
            string hotennguoithu_PhieuThu, 
            string hotennguoinop_PhieuThu, 
            float sotienthu_PhieuThu)
        {
            string ngaythu = ngaythu_PhieuThu.ToString("yyyy-MM-dd");

            string stringSQL =
               "INSERT INTO PhieuThu VALUES " +
               "('" + id_PhieuThu + "', " +
               "N'" + hotennguoithu_PhieuThu + "', " +
               "N'" + hotennguoinop_PhieuThu + "', " +
               "'" + ngaythu + "', " +
               "" + sotienthu_PhieuThu + ", " +
               "'" + id_HopDong + "')";

            return dal.executeNonQuery(stringSQL, CommandType.Text);
        }
        
        public bool XoaPhieuThu(string id_PhieuThu)
        {
            string sqlString = 
                "Delete From PhieuThu " +
                "Where ID_PhieuThu = '" + id_PhieuThu + "'";
            return dal.executeNonQuery(sqlString, CommandType.Text);
        }
        public bool CapNhatPhieuThu(
            string id_HopDong,
            DateTime ngaythu_PhieuThu,
            string id_PhieuThu,
            string hotennguoithu_PhieuThu,
            string hotennguoinop_PhieuThu,
            float sotienthu_PhieuThu)
        {
            string ngaythu = ngaythu_PhieuThu.ToString("yyyy-MM-dd");

            string sqlString =
                "Update PhieuThu Set " +
                "HoTenNguoiThu_PhieuThu = N'" + hotennguoithu_PhieuThu + "', " +
                "HoTenNguoiNop_PhieuThu = N'" + hotennguoinop_PhieuThu + "', " +
                "NgayThu_PhieuThu = '" + ngaythu + "', " +
                "SoTienThu_PhieuThu = " + sotienthu_PhieuThu + ", " +
                "ID_HopDong = '" + id_HopDong + "' " +
                "Where ID_PhieuThu = '" + id_PhieuThu + "'";
            return dal.executeNonQuery(sqlString, CommandType.Text);
        }
    }
}