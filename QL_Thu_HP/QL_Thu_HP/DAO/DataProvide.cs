using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QL_Thu_HP.DAO
{
    class DataProvide
    {
        private static DataProvide instance; // Ctrl + R + E

        public static DataProvide Instance
        {
            get { if (instance == null) { instance = new DataProvide(); } return DataProvide.instance; }
            private set { DataProvide.instance = value; }
        }

        private DataProvide(){}

        // Khoi tao chuoi ket noi de biet duoc la ket noi den dau
        private string connectionSTR = "Data Source=DESKTOP-N98UA7T;Initial Catalog=QL_Thu_HP;Integrated Security=True";


        // Xy ly truy van
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            // Du lieu duoc truy van se đỗ vao DataTable
            DataTable data = new DataTable();

            // Khoi tao 1 ket noi tu ung dung den CSDL
            // using de giai phong bo nho khi co loi xay ra
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                // Thuc thi cau truy van
                SqlCommand command = new SqlCommand(query, connection);

                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach(string item in listPara)
                    {
                        if(item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                // Bien trung gian lay du lieu
                SqlDataAdapter adater = new SqlDataAdapter(command);

                // Do du lieu lay ra vao data
                adater.Fill(data);

                connection.Close();
            }

            return data;
        }

        // Tra ve so luong dong thanh cong
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            // Du lieu duoc truy van se đỗ vao DataTable
            int data = 0; 

            // Khoi tao 1 ket noi tu ung dung den CSDL
            // using de giai phong bo nho khi co loi xay ra
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                // Thuc thi cau truy van
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }

            return data;
        }

        // So luong dong tra ra
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            // Du lieu duoc truy van se đỗ vao DataTable
            object data = 0;

            // Khoi tao 1 ket noi tu ung dung den CSDL
            // using de giai phong bo nho khi co loi xay ra
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                // Thuc thi cau truy van
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }

            return data;
        }
    }
}
