namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Go_Out
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(10)]
        public string Team { get; set; }

        public int? Shift { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        public bool? Purpose { get; set; }

        public DateTime? EstimatedDateOut { get; set; }

        public DateTime? EstimatedDateReturn { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

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

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}
