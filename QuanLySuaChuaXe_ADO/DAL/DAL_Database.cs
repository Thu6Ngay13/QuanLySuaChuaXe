using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    class DAL_Database
    {
        private string stringconnection = 
            "Data Source =  localhost;" 
            + "Initial Catalog = QuanLySuaChuaXe;"
            + "Integrated Security=True;";

        private SqlConnection connection = null;
        private SqlCommand command = null;

        public DAL_Database()
        {
            connection = new SqlConnection(stringconnection);
            command = connection.CreateCommand();
        }

        public DataSet executeQueryDataSet(
            string stringSQL,
            CommandType commandtype)
        {
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();

            command.CommandText = stringSQL;
            command.CommandType = commandtype;

            SqlDataAdapter dataapdapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            dataapdapter.Fill(dataset);

            connection.Close(); 
            return dataset;
        }

        public bool executeNonQuery(
            string stringSQL,
            CommandType commandtype)
        {
            bool success = false;
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();

            command.CommandText = stringSQL;
            command.CommandType = commandtype;

            try
            {
                command.ExecuteNonQuery();
                success = true;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }

            return success;
        }
    }
}
