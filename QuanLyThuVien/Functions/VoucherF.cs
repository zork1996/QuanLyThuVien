using QuanLyThuVien.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Functions
{
    class VoucherF
    {
        private LibraryManagementEntities db = new LibraryManagementEntities();
        public IQueryable<Voucher> Vouchers
        {
            get { return db.Vouchers; }
        }
        public bool Exists(int id)
        {
            Voucher dbEntry = db.Vouchers.Where(x => x.ID == id).FirstOrDefault();
            return dbEntry != null;
        }
    }
}
