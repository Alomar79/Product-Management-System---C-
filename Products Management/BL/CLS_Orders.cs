using System;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.BL
{
    internal class CLS_Orders
    {
        private DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable last_orderID()
        {
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_last_orderID", null);
            dal.Close();
            return dt;
        }

        public DataTable Get_last_order()
        {
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_get_last_order", null);
            dal.Close();
            return dt;
        }
        public void Add_Order(int id_order, DateTime date_order, int customer_id, string description_order, string salesman)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;

            param[1] = new SqlParameter("@date_order", SqlDbType.DateTime);
            param[1].Value = date_order;

            param[2] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[2].Value = customer_id;

            param[3] = new SqlParameter("@description_order", SqlDbType.VarChar, 250);
            param[3].Value = description_order;

            param[4] = new SqlParameter("@salesman", SqlDbType.VarChar, 75);
            param[4].Value = salesman;

            dal.Open();
            dal.ExecuteCommand("sp_Add_Order", param);
            dal.Close();
        }

        public void Add_Orders_Details(string id_product, int id_order, int qte, string price, double discount, string amount, string total_amount)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar,30);
            param[0].Value = id_product;

            param[1] = new SqlParameter("@id_order", SqlDbType.Int);
            param[1].Value = id_order;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@discount", SqlDbType.Float);
            param[4].Value = discount;

            param[5] = new SqlParameter("@amount", SqlDbType.VarChar, 50);
            param[5].Value = amount;

            param[6] = new SqlParameter("@total_amount", SqlDbType.VarChar,50);
            param[6].Value = total_amount;

            dal.Open();
            dal.ExecuteCommand("sp_Add_Orders_Details", param);
            dal.Close();
        }

        public DataTable VerifyQty(string id_product, int qte_entered)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 30);
            param[0].Value = id_product;

            param[1] = new SqlParameter("@qte_entered", SqlDbType.Int);
            param[1].Value = qte_entered;


            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_verifyQty", param);
            dal.Close();
            return dt;
        }

        public DataTable Get_Order_Details(int id_order)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_get_order_details", param);
            dal.Close();
            return dt;
        }

        public DataTable Search_Orders(string criteria)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criteria", SqlDbType.VarChar,50);
            param[0].Value = criteria;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_searchOrders", param);
            dal.Close();
            return dt;
        }
    }
}
