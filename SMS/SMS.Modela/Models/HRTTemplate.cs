namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HRTTemplate")]
    public partial class HRTTemplate
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string EmpCode { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string JobTitleName { get; set; }

        [StringLength(50)]
        public string Team { get; set; }

        [StringLength(50)]
        public string Cellphone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
