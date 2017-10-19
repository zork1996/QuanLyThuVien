using QuanLyThuVien.Entities;
//using QuanLyThuVien.Functions;
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
                //LoadReaderData();
            }

            if (tabControl.SelectedTab == tabVoucher)
            {
                cbVoucherSearchBy.SelectedIndex = 0;
                //LoadVoucherData();
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            InitializeTabControl();
        }

    }

}
