using System.Data;
using System.Data.SqlClient;

namespace Products_Management.BL
{
    internal class CLS_Products
    {
        private DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable get_all_categories()
        {           
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_get_all_categories", null);
            dal.Close();
            return dt;
        }

        public DataTable get_Curr_Product(string id_product)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 30);
            param[0].Value = id_product;
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_rpt_Curr_Product", null);
            dal.Close();
            return dt;
        }
        public void Add_Product(string id_product, string label_product, int qte_in_stock, string price,byte[]  image_product,int id_cat)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 30);
            param[0].Value = id_product;

            param[1] = new SqlParameter("@label", SqlDbType.VarChar, 30);
            param[1].Value = label_product;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte_in_stock;

            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = image_product;
            
            param[5] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[5].Value = id_cat;
            dal.Open();
            dal.ExecuteCommand("sp_add_product", param);
            dal.Close();
        }
        public void Delete_Product(string id_product)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 30);
            param[0].Value = id_product;

            
            dal.Open();
            dal.ExecuteCommand("sp_deleteProduct", param);
            dal.Close();
        }
        public DataTable VerifyProductID(string id)
        {
            //DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_verifyProductID", param);
            dal.Close();
            return dt;
        }
        public DataTable get_all_products()
        {
            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_get_all_products", null);
            dal.Close();
            return dt;
        }
        public DataTable SearchProduct(string sr)
        {
            //DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sr", SqlDbType.VarChar, 50);
            param[0].Value = sr;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_SearchProduct", param);
            dal.Close();
            return dt;
        }
        public DataTable get_imgProduct(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 30);
            param[0].Value = id;

            //dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_get_imageProduct", param);
            dal.Close();
            return dt;
        }
        public void Update_Product(string id_product, string label, int qte, string price, byte[] img, int id_cat)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 30);
            param[0].Value = id_product;

            param[1] = new SqlParameter("@label", SqlDbType.VarChar, 30);
            param[1].Value = label;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[5].Value = id_cat;


            dal.Open();
            dal.ExecuteCommand("sp_updateProduct", param);
            dal.Close();
        }
    }
}
