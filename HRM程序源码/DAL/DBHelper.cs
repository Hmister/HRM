using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//导入SQLserver操作相关命名空间
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class DBHelper
    {
        /// <summary>
        /// 数据库操作类
        /// </summary>
            //数据库连接字符串（数据库地址、数据库名、数据库用户名、数据库密码）
            private static string ConnString = "Data Source=.;Initial Catalog=HRM;Integrated Security=True";

            //数据库连接对象
            private static SqlConnection conn;


            /// <summary>
            /// 数据库连接初始化方法
            /// </summary>
            private static void InitConn()
            {
                if (conn == null)
                {
                    conn = new SqlConnection(ConnString);
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open();
                }
            }


            /// <summary>
            /// 数据库连接关闭方法
            /// </summary>
            private static void ConnClose()
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }


            /// <summary>
            /// 数据库执行增、删、改操作，传入SQL语句，返回受影响行数(int类型)
            /// </summary>
            public static int GetLine(string sql)
            {
                InitConn();

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    return cmd.ExecuteNonQuery();
                }

                finally
                {
                    ConnClose();
                }
            }


            /// <summary>
            /// 数据库执行总数查询操作，传入SQL语句，返回结果集中的第一行第一列(Object类型)
            /// </summary>
            public static object GetScalar(string sql)
            {
                InitConn();

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    return cmd.ExecuteScalar();
                }

                finally
                {
                    ConnClose();
                }
            }


            /// <summary>
            /// 数据库执行查询操作，传入SQL语句，返回结果集(DataTable类型)
            /// </summary>
            public static DataTable GetDT(string sql)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(sql, ConnString);
                dap.Fill(dt);
                return dt;
            }
        }
}
