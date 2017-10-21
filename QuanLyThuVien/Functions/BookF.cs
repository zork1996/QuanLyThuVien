using QuanLyThuVien.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Functions
{
    class BookF
    {
        private LibraryManagementEntities db = new LibraryManagementEntities();
        public IQueryable<Book> Books
        {
            get { return db.Books; }
        }
        public bool Exists(int id)
        {
            return db.Books.ToList().Exists(x => x.ID == id);
        }
        public bool Insert(Book model)
        {
            db.Books.Add(model);
            db.SaveChanges();
            return true;
        }
        public bool Update(int id, Book model)
        {
            Book dbEntry = db.Books.Where(x => x.ID == id).FirstOrDefault();

            dbEntry.Title = model.Title;
            dbEntry.Author = model.Author;
            dbEntry.Publisher = model.Publisher;
            dbEntry.Quantity = model.Quantity;
            db.SaveChanges();

            return true;
        }
        public bool Delete(int id)
        {
            db.Vouchers.RemoveRange(db.Vouchers.Where(x => x.BookID == id));
            Book dbEntry = db.Books.Where(x => x.ID == id).FirstOrDefault();
            db.Books.Remove(dbEntry);
            db.SaveChanges();

            return true;
        } 
    }
}
