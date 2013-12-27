using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace BusinessLayer
{
 


        public class Purchase_Order_Item
        {
            // database details
            [Key]
               public int Purchase_Order_Item_ID { get; set; }
            // back to the purchase order.
              public int Purchase_Order_ID { get; set; }

            // --------------------------------------------------------------------------------------------------
            //
            //                      details of the purchase order ITEMS  class.
            //
            // --------------------------------------------------------------------------------------------------

            //TODO: this will be another relationship after we have completed the fisrst version.

                public int Stock_Code_ID { get; set; }
           
            // who changed the record
            public int UserID { get; set; }
        
            //   public virtual PurchaseOrder PurchaseOrder { get; set; } // This is new
            // Generic columns

            //public string Creation_User { get; set; }	//	CHAR(10)
            public string Status { get; set; }	//CHAR(1)
            public string ERP_Status { get; set; }	//	CHAR(1)
            //[DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
            //public DateTime Creation_Date { get; set; }	//	CHAR(6)

            //ERP specific data
            public string ERP_Po_No { get; set; }	//CHAR(6)
            public string ERP_Po_Item_No { get; set; }	//CHAR(3)
           
            public string Dstrct_Code { get; set; }	//CHAR(4)
            public string Po_Item_Type { get; set; }	//CHAR(1)
            public string Receipt_Status { get; set; }	//CHAR(1)
            public string Supp_Lead_Time { get; set; }	//CHAR(4)        
            public string Preq_Stk_Code { get; set; }	//CHAR(9)
            public string Unit_Of_Purch { get; set; }	//CHAR(4)
            public string Warehouse_Id { get; set; }	//CHAR(4)
            public string Delivery_Location { get; set; }	//CHAR(4)
            public string Shipped_Time { get; set; }	//CHAR(6)
            //Qtys
            public decimal Orig_Qty_I { get; set; }	//NUMBER(11,2)
            public decimal Curr_Qty_I { get; set; }	//NUMBER(11,2)
            public decimal Curr_Qty_P { get; set; }	//NUMBER(11,2)
            public decimal Retn_Qty_P { get; set; }	//NUMBER(11,2)

            //Dates
            [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
            public DateTime Due_Site_Date { get; set; }	//CHAR(8)
            [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
            public DateTime Curr_Due_Date { get; set; }	//CHAR(8)
            [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
            public DateTime Orig_Due_Date { get; set; }	//CHAR(8)
            [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
            public DateTime Supp_Desp_Date { get; set; }	//CHAR(8)
            [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
            public DateTime Shipped_Date { get; set; }	//CHAR(8)


        }

    
}
