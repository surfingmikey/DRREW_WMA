using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;




namespace BusinessLayer
{
    public class Purchase_Order
    {
        [Key]
        // database details for Purchase order 
        //Generic Foregien Keys
        public int Purchase_Order_ID { get; set; }
        public int Note_ID { get; set; }

            // --------------------------------------------------------------------------------------------------
            //
            //                      details of the purchase order  class.
            //
            // --------------------------------------------------------------------------------------------------
        
        
       // public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; } // 
                  
        public int UserID { get; set; }
         // Generic columns
        // [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        //public DateTime Creation_Date { get; set; }	//	CHAR(6)
        // public string Creation_User { get; set; }	//	CHAR(10)
        public string Status { get; set; }	//CHAR(1)
        public string ERP_Status { get; set; }	//	CHAR(1)

        //ERP specific data
        [Display(Name = "Po No")]
        public string ERP_Po_No { get; set; }	//	CHAR(6)
        [Display(Name = "Type")]
        public string Po_Type { get; set; }	//	CHAR(1)
        [Display(Name = "Supplier")]
        public string Supplier_No { get; set; }	//	CHAR(6)
        [Display(Name = "District")]
        public string Dstrct_Code { get; set; }	//	CHAR(4)
        public string Freight_Code { get; set; }	//	CHAR(2)
        public string Deliv_Location { get; set; }	//	CHAR(4)
        public string Last_Rcpt_No { get; set; }	//	CHAR(4)
        public string Whouse_Id { get; set; }	//	CHAR(4)

        // Dates
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Order_Date { get; set; }	//	CHAR(8)
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Completed_Date { get; set; }	//	CHAR(8)



        //public virtual ICollection<PurchaseOrderItemModel> PurchaseOrderItem { get; set; }
    }
}
