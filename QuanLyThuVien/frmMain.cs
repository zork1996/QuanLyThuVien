using QuanLyThuVien.Entities;
using QuanLyThuVien.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitializeTabControl();
        }

        private void InitializeTabControl()
        {
            if (tabControl.SelectedTab == tabBook)
            {
                cbBookSearchBy.SelectedIndex = 0;
                //LoadBookData();
            }

            if (tabControl.SelectedTab == tabReader)
            {
                cbReaderSearchBy.SelectedIndex = 0;
                LoadReaderData();
            }

            if (tabControl.SelectedTab == tabVoucher)
            {
                cbVoucherSearchBy.SelectedIndex = 0;
                //LoadVoucherData();
            }
        }


        #region Book Manage

        private void LoadBookData()
        {
            dgvBook.DataSource = (new BookF()).Books.ToList();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            string title = txtBookTitle.Text;
            string author = txtBookAuthor.Text;
            string publisher = txtBookPublisher.Text;
            int quantity = Int32.Parse(txtBookQuantity.Text);

            #region Check Book Information

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter book's title", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Please enter book's author", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(publisher))
            {
                MessageBox.Show("Please enter book's publisher", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity < 0)
            {
                MessageBox.Show("Quantity is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #endregion

            Book model = new Book();

            model.Title = title;
            model.Author = author;
            model.Publisher = publisher;
            model.Quantity = quantity;

            if ((new BookF()).Insert(model))
            {
                MessageBox.Show("Added successfully", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Added failed", "", MessageBoxButtons.OK);
            }

            LoadBookData();

        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {


        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBookId.Text);

            if ((new BookF()).Exists(id) == false)
            {
                MessageBox.Show("Book is not exists", "", MessageBoxButtons.OK);
                return;
            }

            if ((new BookF()).Delete(id) == true)
            {
                MessageBox.Show("Delete successfully", "", MessageBoxButtons.OK);
            }

            LoadBookData();

        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookId.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
            txtBookTitle.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            txtBookAuthor.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            txtBookPublisher.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
            txtBookQuantity.Text = dgvBook.CurrentRow.Cells[4].Value.ToString();
        }

        private void SearchBook(string type, string value)
        {
            if (type == "ID")
                dgvBook.DataSource = (new BookF()).Books.Where(x => x.ID.ToString().Contains(value)).ToList();

            if (type == "Title")
                dgvBook.DataSource = (new BookF()).Books.Where(x => x.Title.Contains(value)).ToList();

            if (type == "Author")
                dgvBook.DataSource = (new BookF()).Books.Where(x => x.Author.Contains(value)).ToList();

            if (type == "Publisher")
                dgvBook.DataSource = (new BookF()).Books.Where(x => x.Publisher.Contains(value)).ToList();

            if (type == "Quantity")
                dgvBook.DataSource = (new BookF()).Books.Where(x => x.Quantity.ToString().Contains(value)).ToList();
        }

        private void txtBookSearchValue_TextChanged(object sender, EventArgs e)
        {
            SearchBook(cbBookSearchBy.SelectedItem.ToString(), txtBookSearchValue.Text);
        }

        private void cbBookSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBook(cbBookSearchBy.SelectedItem.ToString(), txtBookSearchValue.Text);
        }

        #endregion



        #region Reader Manage

        private void LoadReaderData()
        {
            dgvReader.DataSource = (new ReaderF()).Readers.ToList();
        }

        private void btnReaderAdd_Click(object sender, EventArgs e)
        {
            string name = txtReaderName.Text;
            string address = txtReaderAddress.Text;
            string phone = txtReaderPhone.Text;
            string gender = radReaderMale.Checked ? "Nam" : "Nữ";

            #region Check Reader Information

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter reader's name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter reader's address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter reader's phone", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #endregion

            Reader model = new Reader();

            model.Name = name;
            model.Address = address;
            model.Gender = gender;
            model.Phone = phone;

            if ((new ReaderF()).Insert(model))
            {
                MessageBox.Show("Added successfully", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Added failed", "", MessageBoxButtons.OK);
            }

            LoadReaderData();

        }

        private void btnReaderUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtReaderId.Text);
            string name = txtReaderName.Text;
            string address = txtReaderAddress.Text;
            string phone = txtReaderPhone.Text;
            string gender = radReaderMale.Checked ? "Nam" : "Nữ";

            #region Check Reader Information

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter reader's name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter reader's address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter reader's phone", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #endregion

            if ((new ReaderF()).Exists(id) == false)
            {
                MessageBox.Show("Reader is not exists", "", MessageBoxButtons.OK);
                return;
            }

            Reader model = new Reader();

            model.Name = name;
            model.Address = address;
            model.Gender = gender;
            model.Phone = phone;

            if ((new ReaderF()).Update(id, model))
            {
                MessageBox.Show("Update successfully", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Update failed", "", MessageBoxButtons.OK);
            }

            LoadReaderData();

        }

        private void btnReaderDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtReaderId.Text);

            if ((new ReaderF()).Exists(id) == false)
            {
                MessageBox.Show("Reader is not exists", "", MessageBoxButtons.OK);
                return;
            }

            if ((new ReaderF()).Delete(id) == true)
            {
                MessageBox.Show("Delete successfully", "", MessageBoxButtons.OK);
            }

            LoadReaderData();
        }

        private void dgvReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtReaderId.Text = dgvReader.CurrentRow.Cells[0].Value.ToString();
            txtReaderName.Text = dgvReader.CurrentRow.Cells[1].Value.ToString();
            txtReaderAddress.Text = dgvReader.CurrentRow.Cells[3].Value.ToString();
            txtReaderPhone.Text = dgvReader.CurrentRow.Cells[4].Value.ToString();

            if (dgvReader.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                radReaderMale.Checked = true;
                radReaderFemale.Checked = false;
            }
            else
            {
                radReaderMale.Checked = false;
                radReaderFemale.Checked = true;
            }
        }

        private void SearchReader(string type, string value)
        {
            if (type == "ID")
                dgvReader.DataSource = (new ReaderF()).Readers.Where(x => x.ID.ToString().Contains(value)).ToList();

            if (type == "Name")
                dgvReader.DataSource = (new ReaderF()).Readers.Where(x => x.Name.Contains(value)).ToList();

            if (type == "Address")
                dgvReader.DataSource = (new ReaderF()).Readers.Where(x => x.Address.Contains(value)).ToList();

            if (type == "Phone")
                dgvReader.DataSource = (new ReaderF()).Readers.Where(x => x.Phone.Contains(value)).ToList();

            if (type == "Gender")
                dgvReader.DataSource = (new ReaderF()).Readers.Where(x => x.Gender.Contains(value)).ToList();
        }

        private void cbReaderSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchReader(cbReaderSearchBy.SelectedItem.ToString(), txtReaderSearchValue.Text);
        }

        private void txtReaderSearchValue_TextChanged(object sender, EventArgs e)
        {
            SearchReader(cbReaderSearchBy.SelectedItem.ToString(), txtReaderSearchValue.Text);
        }

        #endregion

        #region Voucher Manage

        private void LoadVoucherData()
        {
            LibraryManagementEntities db = new LibraryManagementEntities();
            dgvVoucher.DataSource = (from v in db.Vouchers
                                     join b in db.Books
                                     on v.BookID equals b.ID
                                     join r in db.Readers
                                     on v.ReaderID equals r.ID
                                     select new { v.ID, BookTitle = b.Title, ReaderName = r.Name, v.Quantity, v.Date }).ToList();
        }

        private void btnVoucherAdd_Click(object sender, EventArgs e)
        {
            int bookId = Int32.Parse(txtVoucherBookId.Text);
            int readerId = Int32.Parse(txtVoucherReaderId.Text);
            int quantity = Int32.Parse(txtVoucherQuantity.Text);
            DateTime date = dateVoucherDate.Value;

            #region Check Voucher Information

            if ((new BookF()).Exists(bookId) == false)
            {
                MessageBox.Show("Book is not exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((new ReaderF()).Exists(readerId) == false)
            {
                MessageBox.Show("Reader is not exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity <= 0 || quantity > (new BookF()).Books.Where(x => x.ID == bookId).FirstOrDefault().Quantity)
            {
                MessageBox.Show("Not valid quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Voucher model = new Voucher();

            model.BookID = bookId;
            model.ReaderID = readerId;
            model.Quantity = quantity;
            model.Date = date;

            if ((new VoucherF()).Insert(model))
            {
                MessageBox.Show("Added successfully", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Added failed", "", MessageBoxButtons.OK);
            }

            LoadVoucherData();

            #endregion

        }

        private void btnVoucherDelete_Click(object sender, EventArgs e)
        {
            int voucherId = Int32.Parse(txtVoucherId.Text);

            if ((new VoucherF()).Exists(voucherId) == false)
            {
                MessageBox.Show("Voucher is not exists", "", MessageBoxButtons.OK);
                return;
            }

            if ((new VoucherF()).Delete(voucherId) == true)
            {
                MessageBox.Show("Delete successfully", "", MessageBoxButtons.OK);
            }

            LoadVoucherData();
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int voucherId = Int32.Parse(dgvVoucher.CurrentRow.Cells[0].Value.ToString());

            Voucher voucherEntry = (new VoucherF()).Vouchers.Where(x => x.ID == voucherId).FirstOrDefault();
            Book bookEntry = (new BookF()).Books.Where(x => x.ID == voucherEntry.BookID).FirstOrDefault();
            Reader readerEntry = (new ReaderF()).Readers.Where(x => x.ID == voucherEntry.ReaderID).FirstOrDefault();

            txtVoucherId.Text = voucherId.ToString();
            txtVoucherBookId.Text = bookEntry.ID.ToString();
            txtVoucherReaderId.Text = readerEntry.ID.ToString();
            txtVoucherQuantity.Text = voucherEntry.Quantity.ToString();
            dateVoucherDate.Value = (DateTime)voucherEntry.Date;
        }

        private void SearchVoucher(string type, string value)
        {
            LibraryManagementEntities db = new LibraryManagementEntities();

            if (type == "Voucher ID")
                dgvVoucher.DataSource = (from v in db.Vouchers
                                         join b in db.Books
                                         on v.BookID equals b.ID
                                         join r in db.Readers
                                         on v.ReaderID equals r.ID
                                         where v.ID.ToString().Contains(value)
                                         select new { v.ID, BookTitle = b.Title, ReaderName = r.Name, v.Quantity, v.Date }).ToList();

            if (type == "Book Title")
                dgvVoucher.DataSource = (from v in db.Vouchers
                                         join b in db.Books
                                         on v.BookID equals b.ID
                                         join r in db.Readers
                                         on v.ReaderID equals r.ID
                                         where b.Title.Contains(value)
                                         select new { v.ID, BookTitle = b.Title, ReaderName = r.Name, v.Quantity, v.Date }).ToList();

            if (type == "Reader")
                dgvVoucher.DataSource = (from v in db.Vouchers
                                         join b in db.Books
                                         on v.BookID equals b.ID
                                         join r in db.Readers
                                         on v.ReaderID equals r.ID
                                         where r.Name.Contains(value)
                                         select new { v.ID, BookTitle = b.Title, ReaderName = r.Name, v.Quantity, v.Date }).ToList();

            if (type == "Quantity")
                dgvVoucher.DataSource = (from v in db.Vouchers
                                         join b in db.Books
                                         on v.BookID equals b.ID
                                         join r in db.Readers
                                         on v.ReaderID equals r.ID
                                         where v.Quantity.ToString().Contains(value)
                                         select new { v.ID, BookTitle = b.Title, ReaderName = r.Name, v.Quantity, v.Date }).ToList();

            if (type == "Date")
                dgvVoucher.DataSource = (from v in db.Vouchers
                                         join b in db.Books
                                         on v.BookID equals b.ID
                                         join r in db.Readers
                                         on v.ReaderID equals r.ID
                                         where v.Date.ToString().Contains(value)
                                         select new { v.ID, BookTitle = b.Title, ReaderName = r.Name, v.Quantity, v.Date }).ToList();
        }

        private void cbVoucherSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchVoucher(cbVoucherSearchBy.SelectedItem.ToString(), txtVoucherSearchValue.Text);
        }

        private void txtVoucherSearchValue_TextChanged(object sender, EventArgs e)
        {
            SearchVoucher(cbVoucherSearchBy.SelectedItem.ToString(), txtVoucherSearchValue.Text);
        }

        #endregion


        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            InitializeTabControl();
        }

    }

}
