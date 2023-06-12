using System.Data;
using DAL;

namespace BLL
{
    public class BLL_NhomTho
    {
        DAL_Database database;
        public BLL_NhomTho()
        {
            database = new DAL_Database();
        }
        public DataSet LayNhomTho()
        {
            return database.executeQueryDataSet("select * from NhomTho", CommandType.Text);
        }
        public bool ThemNhomTho(string id_NhomTho, string ten_NhomTho, string id_TruongNhom)
        {
            string stringSQL =
                "INSERT INTO NhomTho VALUES " +
                "('" + id_NhomTho + "', " +
                "N'" + ten_NhomTho + "', " +
                "'" + id_TruongNhom + "')";

            return database.executeNonQuery(
                stringSQL,
                CommandType.Text);
        }
        public bool XoaNhomTho(string id_NhomTho)
        {
            string stringSQL =
                "Delete From NhomTho " +
                "Where ID_NhomTho = '" + id_NhomTho + "'";

            return database.executeNonQuery(
                stringSQL,
                CommandType.Text);
        }

        public bool CapNhapNhomTho(string id_NhomTho, string ten_NhomTho, string id_TruongNhom)
        {
            string checktennhomtho = ((ten_NhomTho.Trim().Length > 0) ?
                    ("Ten_NhomTho = N'" + ten_NhomTho + "' ") :
                    " ");
            string checkidtruongnhom = ((id_TruongNhom.Trim().Length > 0) ?
                        ("ID_TruongNhom = '" + id_TruongNhom + "' ") :
                        ("ID_TruongNhom = null "));

            string setattribute =
                checktennhomtho != " " ? checktennhomtho + ", " : " " +
                checkidtruongnhom;

            string sqlString =
                "Update NhomTho Set " +
                    setattribute +
                "Where ID_NhomTho = '" + id_NhomTho + "'";

            return database.executeNonQuery(
                sqlString,
                CommandType.Text);
        }
    }
}
