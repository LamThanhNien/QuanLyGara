using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace Quanly.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            set { instance = value; }
        }
        private DataProvider() { }
        private static string connectionSTR = "Data Source=DELL;Initial Catalog=QL_GARA;Integrated Security=True;Encrypt=False";

        public DataTable ExecuteQuery(string query, object[] prameter = null)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        AddParameters(command, query, prameter);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(data);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] prameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    AddParameters(command, query, prameter);
                    data = command.ExecuteNonQuery();
                }
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object result = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        AddParameters(command, query, parameter);
                        result = command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            return result; //trả về số hoặc 1 chuỗi
        }

        private void AddParameters(SqlCommand command, string query, object[] parameter)
        {
            if (parameter == null) return;
            string[] listPara = query.Split(' ');
            int i = 0;
            foreach (string s in listPara)
            {
                if (s.Contains('@') && i < parameter.Length)
                {
                    command.Parameters.AddWithValue(s, parameter[i] ?? DBNull.Value);
                    i++;
                }
            }
        }
    }
}
