using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFlower.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int TransactionID { get; set; }

        [Display(Name ="CustomerID")]
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Inventory Inventories { get; set; }
    }
}