using QuanLyThuVien.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Functions
{
    class LoginF
    {
        private LibraryManagementEntities db = new LibraryManagementEntities();
        public IQueryable<Login> Logins
        {
            get { return db.Logins; }
        }
        public bool Check(string username, string password)
        {
            Login dbEntry = db.Logins.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
            return dbEntry != null;
        }
    }
}
