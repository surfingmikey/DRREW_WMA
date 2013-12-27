using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BusinessLayer
{
  public  class Consignment_Note_BusinessLayer
    {

      public IEnumerable<Consignment_Note> Consignment_Note_With_ManifestID(int id)

        {
         
           {
                string connectionString = ConfigurationManager.ConnectionStrings["WMA"].ConnectionString;

                List<Consignment_Note> ConsignmentsNoteALL = new List<Consignment_Note>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spConsignmentNoteManifestID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@ManifestID";
                    parameter.SqlDbType = SqlDbType.NVarChar;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = id;

                    // Add the parameter to the Parameters collection. 
                    cmd.Parameters.Add(parameter);
                    
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        // the names of the DB field must be the same CASE, small mistacks will cause this procedure to fail.

                        Consignment_Note CNote = new Consignment_Note();
                        CNote.Manifest_ID = Convert.ToInt32(rdr["Manifest_ID"]);
                        CNote.Consignee = Convert.ToString(rdr["Consignee"]);
                        CNote.Note_ID = Convert.ToInt32(rdr["Note_ID"]);
                        CNote.Note_Number = Convert.ToString(rdr["Note_Number"]);
                        CNote.Packaging_Cubic_Meters = Convert.ToInt32(rdr["Packaging_Cubic_Meters"]);
                        CNote.Packaging_Description = Convert.ToString(rdr["Packaging_Description"]);
                        CNote.Packaging_Number_Of_Items = Convert.ToInt32(rdr["Packaging_Number_Of_Items"]);
                        CNote.Packaging_Weight = Convert.ToInt32(rdr["Packaging_Weight"]);
                        CNote.Sender = Convert.ToString(rdr["Sender"]);

                      

                        ConsignmentsNoteALL.Add(CNote);
                    }
                }

                return ConsignmentsNoteALL;

            }
        }

      
    }
}
