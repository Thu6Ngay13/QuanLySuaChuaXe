using DAL;
using System;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_DangNhap
    {
        DAL_Database db = null;

        public BLL_DangNhap()
        {
            db = new DAL_Database();
        }

        public bool AuthenticateUser(string username, string password)
        {
            string stringSQL =
                    "SELECT COUNT(*) " +
                    "FROM Users " +
                    "WHERE " +
                        "User_name = '" + username.Trim() + "' " +
                        "AND Password ='" + password.Trim() + "'";

            DataSet dataSet = db.executeQueryDataSet(stringSQL, CommandType.Text);
            DataTable dataTable = dataSet.Tables[0];
            int count = Convert.ToInt32(dataTable.Rows[0][0]);

            return count > 0;
        }
    }
}