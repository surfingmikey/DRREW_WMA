using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class PurchaseOrder_BusinessLayer
    {
        public IEnumerable<Purchase_Order> PurchaseOrder_With_ConsignmentNoteID(int id)
       

            {
                string connectionString = ConfigurationManager.ConnectionStrings["WMA"].ConnectionString;

                List<Purchase_Order> PurchaseOrderALL = new List<Purchase_Order>();

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

                        Purchase_Order POrder = new Purchase_Order();
                        POrder.Purchase_Order_ID = Convert.ToInt32(rdr["PurchaseOrder_id"]);
                              POrder.Supplier_No=   Convert.ToString(rdr["Supplier_No"]);
                                  POrder.ERP_Po_No =  rdr["ERP_PO_Number"].ToString();
 
                     


                        PurchaseOrderALL.Add(POrder);
                    }
                }

                return PurchaseOrderALL;

            }
        

    }
}
