﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhanSu.Data_Layer
{
    class DataAccess
    {
        static string _con = "Data Source=DESKTOP-EADVFVM;Initial Catalog=QLThuVien;Integrated Security=True";
        static SqlConnection con = new SqlConnection(_con);
        public static string ConnectionString
        {
            set
            {
                _con = value;
                con = new SqlConnection(_con);
            }
        }
        public static DataTable Query(string str, params SqlParameter[] sp)
        {
            if (con == null) return null;
            con.Open();
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            if (str.Contains(" "))
            {
                da = new SqlDataAdapter(str, con);
            }
            else
            {
                SqlCommand sc = new SqlCommand(str, con);
                sc.CommandType = CommandType.StoredProcedure;
                if (sp.Length > 0)
                {
                    foreach (SqlParameter p in sp)
                        sc.Parameters.Add(p);
                }
                da = new SqlDataAdapter(sc);
            }
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public static void NonQuery(string str, params SqlParameter[] sp)
        {
            if (con == null) return;
            con.Open();
            SqlCommand sc = new SqlCommand(str, con);
            if (str.Contains(" "))
            {
                sc.CommandType = CommandType.Text;
            }
            else
            {
                sc.CommandType = CommandType.StoredProcedure;
                if (sp.Length > 0)
                {
                    foreach (SqlParameter p in sp)
                        sc.Parameters.Add(p);
                }
            }
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
