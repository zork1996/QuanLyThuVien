namespace QuanLyThuVien.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [Key]
        [StringLength(32)]
        public string UserName { get; set; }

        [StringLength(32)]
        public string Password { get; set; }
    }
}
