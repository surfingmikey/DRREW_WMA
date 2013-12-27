using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace BusinessLayer
{
    public class Manifest
    {
       
        // database details 
        // this is the highest level of the relationship.
        [Key]
        public Int32 ID { get; set; }
             // --------------------------------------------------------------------------------------------------
       //
       //                      details of the manifest  class.
       //
       // --------------------------------------------------------------------------------------------------
      

       // this comes from the suppier and could be a string later on not sure right now
        public string Manifest_Number { get; set; }
        
        // description of the manifest, eg wash plant parts. 
        public string Manifest_Description { get; set; }

        // Eta of the arrivali of the manifest
        public DateTime ETA_Date { get; set; }

        //weight os the Manifest in KG but this needs to be confirmed.
        public int Weight { get; set; }

        //Cubic meters/
        public int Cubic_Meters { get; set; }

        //trailers, the trailer number 
        public string Trailer_Details { get; set; }

        public string BLAA { get; set; }


        //Warehouse details 
        //TODO: this will be linked to the warehouse table. and related but for now just a string. 
        // will have to check naming convention
        public int Warehouse_ID{ get; set; }



        public List<Consignment_Note> ConsignmetNote{ get; set; }




       



        
    }
}
