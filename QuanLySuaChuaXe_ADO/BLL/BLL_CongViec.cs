using System.Data;
using DAL;

namespace BLL
{
    public class BLL_CongViec
    {
        DAL_Database db = null;
        
        public BLL_CongViec()
        {
            db = new DAL_Database();
        }

        public DataSet LayCongViec()
        {
            string sqlString = "select * from CongViec";
            return db.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet TimCongViec(
            string id_CongViec,
            string ten_CongViec,
            string id_NhomCongViec)
        {
            string checkidcongviec = ((id_CongViec.Trim().Length > 0) ?
                        ("ID_CongViec = '" + id_CongViec + "' ") :
                        " ");
            string checktencongviec = ((ten_CongViec.Trim().Length > 0) ?
                        ("Ten_CongViec like N'%" + ten_CongViec + "%' ") :
                        " ");
            string checkidnhomcongviec = ((id_NhomCongViec.Trim().Length > 0) ?
                        ("ID_NhomCongViec = '" + id_NhomCongViec + "' ") :
                        " ");

            string conditionwhere = 
                    checkidcongviec +
                    ((checktencongviec != " ") ? "and " : " ") + checktencongviec +
                    ((checkidnhomcongviec != " ") ? "and " : " ") + checkidnhomcongviec;
            conditionwhere = conditionwhere.Trim();
            conditionwhere = (conditionwhere.StartsWith("and") ? conditionwhere.Substring(3) : conditionwhere);

            string sqlwhere =
                (checkidcongviec != " "
                || checktencongviec != " "
                || checkidnhomcongviec != " ") ?
                ("where " + conditionwhere) :
                " ";

            string sqlString =
                "Select * " +
                "from CongViec " +
                sqlwhere;
            return db.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public bool ThemCongViec(
            string id_CongViec, 
            string ten_CongViec, 
            string id_NhomCongViec)
        {
            string sqlString = 
                "Insert Into CongViec Values " +
                "(" + "'" + id_CongViec + "', " +
                "N'" + ten_CongViec + "', " +
                "'" + id_NhomCongViec + "')";
            return db.executeNonQuery(sqlString, CommandType.Text);
        }

        public bool CapNhatCongViec(string id_CongViec,
            string ten_CongViec,
            string id_NhomCongViec)
        {
            string sqlString = 
                "Update CongViec Set " +
                "Ten_CongViec = N'" + ten_CongViec + "', " +
                "ID_NhomCongViec = '" + id_NhomCongViec + "' " +
                "Where ID_CongViec = '" + id_CongViec + "'";
            return db.executeNonQuery(sqlString, CommandType.Text);
        }
    }
}
