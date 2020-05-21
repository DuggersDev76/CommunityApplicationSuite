namespace ChrisPOC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHEALTH1.USERS")]
    public partial class USER
    {
        [Key]
        [StringLength(30)]
        public string UUID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(1)]
        public string SHUTDOWN { get; set; }

        [StringLength(1)]
        public string SHUTDOWN_COMPLETE { get; set; }

        public DateTime? LAST_LOGON_ATTEMPT { get; set; }

        public DateTime? FIRST_ACCESS { get; set; }

        [Required]
        [StringLength(1)]
        public string ACTIVE { get; set; }

        [StringLength(100)]
        public string SESSION_ID { get; set; }

        [StringLength(1)]
        public string STATUS { get; set; }

        [StringLength(40)]
        public string LOCAL_REPORTS { get; set; }

        [Required]
        [StringLength(2)]
        public string SECTOR { get; set; }

        [StringLength(1)]
        public string RECORD_STATUS { get; set; }

        public DateTime? MAX_DOB_CHILD_EDIT { get; set; }

        [StringLength(8)]
        public string FK_HCP_CODE { get; set; }

        [StringLength(2)]
        public string FK_STAFF_TYPE { get; set; }

        [StringLength(8)]
        public string FK_LOCATION_CODE { get; set; }

        public byte? FK_LOCATION_TYPE { get; set; }

        [StringLength(1)]
        public string ACL { get; set; }

        [StringLength(1)]
        public string SSO { get; set; }

        public DateTime? ACTIVE_FROM { get; set; }

        public DateTime? ACTIVE_TO { get; set; }

        public int AUDIT_ROW_ID { get; set; }

        public DateTime? PASSWORD_LAST_AMENDED_DATE { get; set; }

        [StringLength(13)]
        public string PASSWORD_LAST_AMENDED_BY { get; set; }
    }
}
