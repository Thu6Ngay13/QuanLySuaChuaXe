using System.Data;
using DAL;

namespace BLL
{
    public class BLL_ChiTietHopDong
    {
        DAL_Database db = null;
        
        public BLL_ChiTietHopDong()
        {
            db = new DAL_Database();
        }

        public DataSet LayChiTietHopDong()
        {
            string sqlString = "select * from ChiTietHopDong";
            return db.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet TimChiTietHopDong(
            string id_Tho,
            string id_CongViec,
            string id_HopDong)
        {
            string checkidtho = ((id_Tho.Trim().Length > 0) ?
                        ("ID_Tho = '" + id_Tho + "' ") :
                        " ");
            string checkidcongviec = ((id_CongViec.Trim().Length > 0) ?
                        ("ID_CongViec = '" + id_CongViec + "' ") :
                        " ");
            string checkidhopdong = ((id_HopDong.Trim().Length > 0) ?
                        ("ID_HopDong = '" + id_HopDong + "' ") :
                        " ");

            string conditionwhere =
                    checkidtho +
                    ((checkidcongviec != " ") ? "and " : " ") + checkidcongviec +
                    ((checkidhopdong != " ") ? "and " : " ") + checkidhopdong;
            conditionwhere = conditionwhere.Trim();
            conditionwhere = (conditionwhere.StartsWith("and") ? conditionwhere.Substring(3) : conditionwhere);

            string sqlwhere =
                (checkidtho != " "
                || checkidcongviec != " "
                || checkidhopdong != " ") ?
                ("where " + conditionwhere) :
                " ";

            string sqlString =
                "Select * " +
                "from ChiTietHopDong " +
                sqlwhere;
            return db.executeQueryDataSet(sqlString, CommandType.Text);
        }

        public bool ThemChiTietHopDong(
            string id_Tho,
            string id_CongViec,
            string id_HopDong)
        {
            string sqlString =
                "Insert Into ChiTietHopDong Values " +
                "(" + "'" + id_Tho + "', " +
                "'" + id_CongViec + "', " +
                "'" + id_HopDong + "')";
            return db.executeNonQuery(sqlString, CommandType.Text);
        }

        public bool XoaChiTietHopDong(
            string id_Tho,
            string id_CongViec,
            string id_HopDong)
        {
            string sqlString =
                "Delete From ChiTietHopDong " +
                "Where " +
                    "ID_Tho = '" + id_Tho + "' " +
                    "and ID_CongViec = '" + id_CongViec + "' " +
                    "and ID_HopDong = '" + id_HopDong + "' ";
            return db.executeNonQuery(sqlString, CommandType.Text);
        }

        public bool CapNhatChiTietHopDong(
            string id_Tho,
            string id_CongViec,
            string id_HopDong)
        {


            string sqlString =
                "Update ChiTietHopDong Set " +
                    (id_Tho == "" ? "ID_Tho = null " : "ID_Tho = '" + id_Tho + "' ") +
                "Where " +
                    "ID_CongViec = '" + id_CongViec + "' " +
                    "and ID_HopDong = '" + id_HopDong + "' ";
            return db.executeNonQuery(sqlString, CommandType.Text);
        }
    }
}
