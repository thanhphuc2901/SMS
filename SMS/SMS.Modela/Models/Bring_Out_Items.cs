namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bring_Out_Items
    {
        public int ID { get; set; }

        public int? CatID { get; set; }

        [StringLength(250)]
        public string Item { get; set; }

        [StringLength(250)]
        public string Serial { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public int? AssetType { get; set; }

        public bool? IsReturn { get; set; }

        public DateTime? ReturnDate { get; set; }

        [StringLength(50)]
        public string ApprovedBy { get; set; }

        public int? ApprovedStatus { get; set; }

        [StringLength(250)]
        public string ApproverRemark { get; set; }

        public DateTime? ApprovedDate { get; set; }

        [StringLength(50)]
        public string GuardOut { get; set; }

        public int? GuardStatusOut { get; set; }

        [StringLength(250)]
        public string GuardRemarkOut { get; set; }

        public DateTime? GuardDateOut { get; set; }

        [StringLength(50)]
        public string GuardReturn { get; set; }

        public int? GuardStatusReturn { get; set; }

        [StringLength(250)]
        public string GuardRemarkReturn { get; set; }

        public DateTime? GuardDateReturn { get; set; }

        [StringLength(50)]
        public string SMT { get; set; }

        public int? SMT_Status { get; set; }

        [StringLength(50)]
        public string SMT_Remark { get; set; }

        public DateTime? SMT_Date { get; set; }

        [StringLength(50)]
        public string ITT { get; set; }

        public int? ITT_Status { get; set; }

        [StringLength(50)]
        public string ITT_Remark { get; set; }

        public DateTime? ITT_Date { get; set; }

        [StringLength(50)]
        public string FST { get; set; }

        public int? FST_Status { get; set; }

        [StringLength(50)]
        public string FST_Remark { get; set; }

        public DateTime? FST_Date { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public virtual Bring_Out Bring_Out { get; set; }
    }
}
