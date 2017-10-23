using QuanLyThuVien.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Functions
{
    class ReaderF
    {
        private LibraryManagementEntities db = new LibraryManagementEntities();
        public IQueryable<Reader> Readers
        {
            get { return db.Readers; }
        }
        public bool Exists(int id)
        {
            return db.Readers.ToList().Exists(x => x.ID == id);
        }
        public bool Insert(Reader model)
        {
            db.Readers.Add(model);
            db.SaveChanges();
            return true;
        }
        public bool Update(int id, Reader model)
        {
            Reader dbEntry = db.Readers.Where(x => x.ID == id).FirstOrDefault();

            dbEntry.Name = model.Name;
            dbEntry.Gender = model.Gender;
            dbEntry.Address = model.Address;
            dbEntry.Phone = model.Phone;
            db.SaveChanges();

            return true;
        }
        public bool Delete(int id)
        {
            db.Vouchers.RemoveRange(db.Vouchers.Where(x => x.ReaderID == id));
            Reader dbEntry = db.Readers.Where(x => x.ID == id).FirstOrDefault();
            db.Readers.Remove(dbEntry);
            db.SaveChanges();

            return true;
        } 
    }
}
