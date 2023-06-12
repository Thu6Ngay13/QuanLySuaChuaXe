using System.Data;
using DAL;

namespace BLL
{
    public class BLL_KhaNang
    {
        DAL_Database db = null;

        public BLL_KhaNang()
        {
            db = new DAL_Database();
        }

        public DataSet LayKhaNang()
        {
            string sqlString = "select * from KhaNang";
            return db.executeQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet TimKhaNang(
            string id_Tho,
            string id_CongViec)
        {
            string checkidtho = ((id_Tho.Trim().Length > 0) ?
                        ("ID_Tho = '" + id_Tho + "' ") :
                        " ");
            string checkidcongviec = ((id_CongViec.Trim().Length > 0) ?
                        ("ID_CongViec = '" + id_CongViec + "' ") :
                        " ");

            string conditionwhere =
                    checkidtho +
                    ((checkidcongviec != " ") ? "and " : " ") + checkidcongviec;
            conditionwhere = conditionwhere.Trim();
            conditionwhere = (conditionwhere.StartsWith("and") ? conditionwhere.Substring(3) : conditionwhere);

            string sqlwhere =
                (checkidtho != " "
                || checkidcongviec != " ") ?
                ("where " + conditionwhere) :
                " ";

            string sqlString =
                "Select * " +
                "from KhaNang " +
                sqlwhere;
            return db.executeQueryDataSet(sqlString, CommandType.Text);
        }
        public bool ThemKhaNang(
            string id_Tho,
            string id_CongViec)
        {
            string sqlString =
                "Insert Into KhaNang Values " +
                "(" + "'" + id_Tho + "', " +
                "'" + id_CongViec + "')";
            return db.executeNonQuery(sqlString, CommandType.Text);
        }
        public bool XoaKhaNang(
            string id_Tho,
            string id_CongViec)
        {
            string sqlString =
                "Delete From KhaNang " +
                "Where " +
                    "ID_Tho = '" + id_Tho + "' " +
                    "and ID_CongViec = '" + id_CongViec + "' ";
            return db.executeNonQuery(sqlString, CommandType.Text);
        }
    }
}
