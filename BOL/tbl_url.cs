namespace BOL
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_url
    {
        [Key]
        public Guid UrlId { get; set; }

        [StringLength(50)]
        public string UrlTitle { get; set; }

        [StringLength(50)]
        public string Url { get; set; }

        [StringLength(50)]
        public string UrlDesc { get; set; }

        public Guid? CategoryId { get; set; }

        public Guid? UserId { get; set; }

        public bool? IsApproved { get; set; }

        public virtual tbl_category tbl_category { get; set; }

        public virtual tbl_user tbl_user { get; set; }
    }
}
