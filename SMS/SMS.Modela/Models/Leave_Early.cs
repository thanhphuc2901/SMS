namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Leave_Early
    {
        public int ID { get; set; }

        [StringLength(50, ErrorMessage = "Số ký tự tối đa là 50")]
        [Required(ErrorMessage ="Bạn phải nhập mã nhân viên")]
        public string UserName { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(10)]
        public string Team { get; set; }

        public int Shift { get; set; }

        [StringLength(500, ErrorMessage = "Số ký tự tối đa là 500")]
        [Required(ErrorMessage = "Bạn phải điền lý do")]
        public string Reason { get; set; }

        public bool Purpose { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập thời gian")]
        public DateTime EstimatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(50)]
        public string ApprovedBy { get; set; }

        public int? ApprovedStatus { get; set; }

        [StringLength(250)]
        public string ApproverRemark { get; set; }

        public DateTime? ApprovedDate { get; set; }

        [StringLength(50)]
        public string Guard { get; set; }

        public int? GuardStatus { get; set; }

        [StringLength(250)]
        public string GuardRemark { get; set; }

        public DateTime? GuardDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}
