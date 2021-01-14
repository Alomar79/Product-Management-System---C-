using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

using System;

namespace Products_Management.DAL
{
    class DataAccessLayer
    {
         SqlConnection cn, cn_restore;
        //static string statment = @"Server=.\SQLEXPRESS; Database=Product_DB; Integrated Security=true ";
        //static string statment_restore = @"Server=.\SQLEXPRESS; Database=master; Integrated Security=true ";
        
        
         
        //static string statment = @"Server= " + Properties.Settings.Default.Server + "  database="+ Properties.Settings.Default.Database + "; Integrated Security=true ";

        
        public DataAccessLayer()
        {
            string mode = Properties.Settings.Default.Mode;
            if (mode == "SQL")
            {
                cn = new SqlConnection(@"Server= " + Properties.Settings.Default.Server + "; database=" + Properties.Settings.Default.Database + "; Integrated Security=false; User ID="+ Properties.Settings.Default.ID+"; Password="+ Properties.Settings.Default.Password);
            }
            else
            {
                cn = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
            }
            
            
        }
        public void Open()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }
        public void Close()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public DataTable SelectData(string stored_Procedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_Procedure;
            cmd.Connection = cn;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            try
            {
                DA.Fill(dt);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "رسالة الخطأ");
            }

            return dt;
        }
        public void ExecuteCommand(string stored_Procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_Procedure;
            cmd.Connection = cn;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);                
            }
             cmd.ExecuteNonQuery();
        }
        public void MakeBackup(string path)
        {
            
            string filename = path + "\\Product_DB-" + DateTime.Now.ToShortDateString().Replace('/', '-').Replace(" ", "-")
                    + "-" + DateTime.Now.ToLongTimeString().Replace(':', '.').Replace(" ", "-");
            string strQuery = "Backup Database Product_DB to Disk='" + filename + ".bak'";
            SqlCommand cmd = new SqlCommand(strQuery, cn);

            cmd.ExecuteNonQuery();
            
           
        }
        public void RestoreBackup(string path)
        {
            try
            {
                string statment_restore = @"Server=.\SQLEXPRESS; Database=master; Integrated Security=true ";
                cn_restore = new SqlConnection(statment_restore);
                string strQuery = "ALTER Database Product_DB SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Product_DB From Disk='" + path + "'WITH REPLACE";
                SqlCommand cmd = new SqlCommand(strQuery, cn_restore);
                cn_restore.Open();
                cmd.ExecuteNonQuery();
                cn_restore.Close();
            }
            catch
            {
                return;
            }
        }
    }
}
