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
        public bool Insert(Voucher model)
        {
            Book bookEntry = db.Books.Where(x => x.ID == model.BookID).FirstOrDefault();
            bookEntry.Quantity = (int)bookEntry.Quantity - (int)model.Quantity;
            db.Vouchers.Add(model);
            db.SaveChanges();
            return true;
        }
        public bool Delete(int id)
        {
            Voucher dbEntry = db.Vouchers.Where(x => x.ID == id).FirstOrDefault();
            Book bookEntry = db.Books.Where(x => x.ID == dbEntry.BookID).FirstOrDefault();
            bookEntry.Quantity = bookEntry.Quantity + (int)dbEntry.Quantity;
            db.Vouchers.Remove(dbEntry);
            db.SaveChanges();
            return true;
        }
    }
}
