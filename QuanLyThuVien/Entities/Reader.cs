namespace QuanLyThuVien.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reader")]
    public partial class Reader
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(3)]
        public string Gender { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }
    }
}
