using System.Data;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class BLL_NhomCongViec
    {
        DAL_Database database;
        public BLL_NhomCongViec()
        {
            database = new DAL_Database();
        }
        public DataSet LayNhomCongViec()
        {
            return database.executeQueryDataSet("select * from NhomCongViec", CommandType.Text);
        }

        public bool ThemNhomCongViec(
            string id_NhomCongViec, 
            string ten_NhomCongViec)
        {
            string stringSQL =
                "INSERT INTO NhomCongViec VALUES " +
                "(N'" + id_NhomCongViec + "', " +
                "N'" + ten_NhomCongViec + "')";

            return database.executeNonQuery(
                stringSQL,
                CommandType.Text);
        }

        public bool CapNhapNhomCongViec(
            string id_NhomCongViec, 
            string ten_NhomCongViec)
        {
            string sqlString = 
                "Update NhomCongViec Set "
                + "Ten_NhomCongViec = " + "N'" + ten_NhomCongViec + "' "
                + "Where ID_NhomCongViec = '" + id_NhomCongViec + "'";

            return database.executeNonQuery(
                sqlString,
                CommandType.Text);
        }
    }
}
