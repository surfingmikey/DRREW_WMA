using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Configuration;




namespace BusinessLayer
{
  public  class Consignment_Note
    {
      

        
        // Database ID
        [Key]
        public int Note_ID { get; set; }
        
        // this links the manifest consignment note items
        public int Manifest_ID { get; set; }
        
        // --------------------------------------------------------------------------------------------------
        //
        //                      details of the consignment note class.
        //
        // --------------------------------------------------------------------------------------------------
      
        // this comes from the suppier and could be a string later on not sure right now
      
        public string Note_Number { get; set; }

        // describing what type of packaging eg pallet
        public string Packaging_Description { get; set; }

       // items in the consignment
        public int Packaging_Number_Of_Items { get; set; }
        
                // weight ion KG 
      [StringLength(1)]
        public int Packaging_Weight { get; set; }

        // demensions of the parcel
        public int Packaging_Cubic_Meters { get; set; }
        
        // the person whom sent it, or supplier
        public string Sender { get; set; }

        //this may be who is unpacking the order
        //TODO: this will link to the user table linked to the User ID, 
        public string Consignee { get; set; }







    }
}
