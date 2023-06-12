using System;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_Xe
    {
        DAL_Database database = null;
        public BLL_Xe()
        {
            database = new DAL_Database();
        }
        
        public DataSet LayXe()
        {
            return database.executeQueryDataSet("select * from Xe", CommandType.Text);
        }

        public DataSet TimXe(string id_Xe)
        {
            string sqlString =
                "select * " +
                "from Xe " +
                "where ID_Xe = '" + id_Xe + "'";

            return database.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet TimXe_KhachHang(string id_KhachHang)
        {
            string sqlString =
                "select Xe.ID_Xe " +
                "from Xe " +
                "join KhachHang on KhachHang.ID_KhachHang = Xe.ID_KhachHang " +
                "where KhachHang.ID_KhachHang = '" + id_KhachHang + "'";

            return database.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public bool ThemXe(
            string id_Xe, 
            string loai_Xe, 
            string hang_Xe, 
            string id_KhachHang)
        {
            string sqlString =
                "Insert Into Xe Values " +
                "('" + id_Xe + "', " +
                "N'" + loai_Xe + "', " +
                "N'" + hang_Xe + "', " +
                "'" + id_KhachHang + "')";
            return database.executeNonQuery(sqlString, CommandType.Text);
        }

        public bool XoaXe(string id_Xe)
        {
            string sqlString =
                "Delete From Xe " +
                "Where ID_Xe = '" + id_Xe + "'";
            return database.executeNonQuery(sqlString, CommandType.Text);
        }

        public bool CapnhatXe(
            string id_Xe,
            string loai_Xe,
            string hang_Xe,
            string id_KhachHang)
        {
            string sqlString =
                "Update Xe Set " +
                "Loai_Xe = N'" + loai_Xe + "', " +
                "Hang_Xe = N'" + hang_Xe + "', " +
                "ID_KhachHang = '" + id_KhachHang + "' " +
                "Where ID_Xe = '" + id_Xe + "'";
            return database.executeNonQuery(sqlString, CommandType.Text);
        }
    }
}