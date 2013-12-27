using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BusinessLayer
{
  public   class Purchase_Order_Item_BusinessLayer
   
    {
        public IEnumerable<Purchase_Order_Item> Purchase_Order_Item_With_PurchaseOrderID(int id)
       

            {
                string connectionString = ConfigurationManager.ConnectionStrings["WMA"].ConnectionString;

                List<Purchase_Order_Item> PurchaseOrderItemsALL = new List<Purchase_Order_Item>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spPurchaseOrder_Select", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@ConsignmentID";
                    parameter.SqlDbType = SqlDbType.NVarChar;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = id; //taking the Single value from the  input paramater

                    // Add the parameter to the Parameters collection. 
                    cmd.Parameters.Add(parameter);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        // the names of the DB field must be the same CASE, small mistacks will cause this procedure to fail.

                        Purchase_Order_Item POItem = new Purchase_Order_Item();
                        POItem.Purchase_Order_ID = Convert.ToInt32(rdr["PurchaseOrder_id"]);
                  //      POItem.ERP_Po_Item_No =Convert.ToString(rdr["ERP_Po_Item_No"]);
                        POItem.ERP_Po_No = Convert.ToString(rdr["ERP_PO_Number"]);
 
                     


                        PurchaseOrderItemsALL.Add(POItem);
                    }
                }

                return PurchaseOrderItemsALL;

            }
        


       public IEnumerable<Purchase_Order_Item> Purchase_Order_Item_With_ConsignmentID(int id)
       

            {
                string connectionString = ConfigurationManager.ConnectionStrings["WMA"].ConnectionString;

                List<Purchase_Order_Item> PurchaseOrderItemsALL = new List<Purchase_Order_Item>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spPurchase_Order_items_passing_ConsignmentID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@ConsignmentNote_ID";
                    parameter.SqlDbType = SqlDbType.NVarChar;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = id; //taking the Single value from the  input paramater

                    // Add the parameter to the Parameters collection. 
                    cmd.Parameters.Add(parameter);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        // the names of the DB field must be the same CASE, small mistacks will cause this procedure to fail.

                        Purchase_Order_Item POItem = new Purchase_Order_Item();
                        POItem.Purchase_Order_ID = Convert.ToInt32(rdr["PurchaseOrder_id"]);
                  //      POItem.ERP_Po_Item_No =Convert.ToString(rdr["ERP_Po_Item_No"]);
                        POItem.ERP_Po_No = Convert.ToString(rdr["ERP_PO_Number"]);
 
                     


                        PurchaseOrderItemsALL.Add(POItem);
                    }
                }

                return PurchaseOrderItemsALL;

            }
        
    }




      
    
}
