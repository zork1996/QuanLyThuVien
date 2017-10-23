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

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            InitializeTabControl();
        }

    }

}
