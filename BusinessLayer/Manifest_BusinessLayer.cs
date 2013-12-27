


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BusinessLayer
{
    public class Manifest_BusinessLayer
    {

        public IEnumerable<Manifest> ManifestItem
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["WMA"].ConnectionString;

                List<Manifest> ManifestItems = new List<Manifest>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spManifestItems", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Manifest s = new Manifest();
                        s.ID = Convert.ToInt32(rdr["Manifest_ID"]);
                        s.Manifest_Number = rdr["Manifest_Number"].ToString();
             



                        ManifestItems.Add(s);
                    }
                }

                return ManifestItems;

            }
        }

        public IEnumerable<Manifest> ManifestItemAddNew
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["WMA"].ConnectionString;

                List<Manifest> ManifestItems = new List<Manifest>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spManifestItems", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Manifest s = new Manifest();
                        s.ID = Convert.ToInt32(rdr["Manifest_ID"]);
                        s.Manifest_Number = rdr["Manifest_Number"].ToString();
                        s.BLAA = rdr["rellyimportant"].ToString();




                        ManifestItems.Add(s);
                    }
                }

                return ManifestItems;

            }
        }

        public void ManifestDeleteItem(Manifest m)

        {

                      
            {
                string connectionString = ConfigurationManager.ConnectionStrings["WMA"].ConnectionString;

                List<Manifest> ManifestItems = new List<Manifest>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteManifestRecord", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@RowID";
                    parameter.SqlDbType = SqlDbType.NVarChar;
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = "1";

                    // Add the parameter to the Parameters collection. 
                    cmd.Parameters.Add(parameter);



                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Manifest s = new Manifest();
                        s.ID = Convert.ToInt32(rdr["Manifest_ID"]);
                        s.Manifest_Number = rdr["Manifest_Number"].ToString();
                        s.BLAA = rdr["rellyimportant"].ToString();




                        ManifestItems.Add(s);
                    }
                }

           

            }
        }







    }
}