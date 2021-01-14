using System.Data;

namespace Products_Management.BL
{
    internal class CLS_Customers
    {
        private DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable get_all_customers()
        {
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_get_all_customers", null);
            dal.Close();
            return dt;
        }
    }
}
