using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBook = new System.Windows.Forms.TabPage();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.lblDevider = new System.Windows.Forms.Label();
            this.cbBookSearchBy = new System.Windows.Forms.ComboBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBookSearchValue = new System.Windows.Forms.TextBox();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookSearchValue = new System.Windows.Forms.Label();
            this.lblBookSearchBy = new System.Windows.Forms.Label();
            this.lblBookPublisher = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblBookQuantity = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.tabReader = new System.Windows.Forms.TabPage();
            this.radReaderFemale = new System.Windows.Forms.RadioButton();
            this.radReaderMale = new System.Windows.Forms.RadioButton();
            this.btnReaderDelete = new System.Windows.Forms.Button();
            this.btnReaderUpdate = new System.Windows.Forms.Button();
            this.btnReaderAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReaderSearchBy = new System.Windows.Forms.ComboBox();
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.txtReaderAddress = new System.Windows.Forms.TextBox();
            this.lblReaderAddress = new System.Windows.Forms.Label();
            this.txtReaderSearchValue = new System.Windows.Forms.TextBox();
            this.txtReaderPhone = new System.Windows.Forms.TextBox();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.lblReaderSearchValue = new System.Windows.Forms.Label();
            this.lblReaderSearchBy = new System.Windows.Forms.Label();
            this.lblReaderPhone = new System.Windows.Forms.Label();
            this.txtReaderId = new System.Windows.Forms.TextBox();
            this.lblReaderGender = new System.Windows.Forms.Label();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.lblReaderId = new System.Windows.Forms.Label();
            this.tabVoucher = new System.Windows.Forms.TabPage();
            this.dateVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.btnVoucherDelete = new System.Windows.Forms.Button();
            this.btnVoucherAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVoucherSearchBy = new System.Windows.Forms.ComboBox();
            this.dgvVoucher = new System.Windows.Forms.DataGridView();
            this.txtVoucherQuantity = new System.Windows.Forms.TextBox();
            this.lblVoucherQuantity = new System.Windows.Forms.Label();
            this.txtVoucherSearchValue = new System.Windows.Forms.TextBox();
            this.txtVoucherReaderId = new System.Windows.Forms.TextBox();
            this.txtVoucherBookId = new System.Windows.Forms.TextBox();
            this.lblTimPhieu = new System.Windows.Forms.Label();
            this.lblVoucherSearchBy = new System.Windows.Forms.Label();
            this.lblVoucherDate = new System.Windows.Forms.Label();
            this.txtVoucherId = new System.Windows.Forms.TextBox();
            this.lblVoucherReaderId = new System.Windows.Forms.Label();
            this.lblVoucherBookId = new System.Windows.Forms.Label();
            this.lblVoucherId = new System.Windows.Forms.Label();
            this.colBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublishHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReaderAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReaderPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReaderGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityLend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.tabReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            this.tabVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBook);
            this.tabControl.Controls.Add(this.tabReader);
            this.tabControl.Controls.Add(this.tabVoucher);
            this.tabControl.Location = new System.Drawing.Point(29, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(705, 510);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabBook
            // 
            this.tabBook.Controls.Add(this.btnBookDelete);
            this.tabBook.Controls.Add(this.btnBookUpdate);
            this.tabBook.Controls.Add(this.btnBookAdd);
            this.tabBook.Controls.Add(this.lblDevider);
            this.tabBook.Controls.Add(this.cbBookSearchBy);
            this.tabBook.Controls.Add(this.dgvBook);
            this.tabBook.Controls.Add(this.txtBookTitle);
            this.tabBook.Controls.Add(this.lblBookTitle);
            this.tabBook.Controls.Add(this.txtBookSearchValue);
            this.tabBook.Controls.Add(this.txtBookPublisher);
            this.tabBook.Controls.Add(this.txtBookQuantity);
            this.tabBook.Controls.Add(this.txtBookAuthor);
            this.tabBook.Controls.Add(this.lblBookSearchValue);
            this.tabBook.Controls.Add(this.lblBookSearchBy);
            this.tabBook.Controls.Add(this.lblBookPublisher);
            this.tabBook.Controls.Add(this.txtBookId);
            this.tabBook.Controls.Add(this.lblBookQuantity);
            this.tabBook.Controls.Add(this.lblBookAuthor);
            this.tabBook.Controls.Add(this.lblBookId);
            this.tabBook.Location = new System.Drawing.Point(4, 22);
            this.tabBook.Name = "tabBook";
            this.tabBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabBook.Size = new System.Drawing.Size(697, 484);
            this.tabBook.TabIndex = 0;
            this.tabBook.Text = "Quản Lý Sách";
            this.tabBook.UseVisualStyleBackColor = true;
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(547, 105);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(69, 21);
            this.btnBookDelete.TabIndex = 6;
            this.btnBookDelete.Text = "Xóa";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(456, 104);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(69, 21);
            this.btnBookUpdate.TabIndex = 6;
            this.btnBookUpdate.Text = "Sửa";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(364, 104);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(69, 21);
            this.btnBookAdd.TabIndex = 6;
            this.btnBookAdd.Text = "Thêm";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // lblDevider
            // 
            this.lblDevider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDevider.Location = new System.Drawing.Point(20, 150);
            this.lblDevider.Name = "lblDevider";
            this.lblDevider.Size = new System.Drawing.Size(656, 2);
            this.lblDevider.TabIndex = 5;
            // 
            // cbBookSearchBy
            // 
            this.cbBookSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBookSearchBy.FormattingEnabled = true;
            this.cbBookSearchBy.Items.AddRange(new object[] {
            "Mã Sách",
            "Tiêu Đề",
            "Tác Giả",
            "Nhà Xuất Bản",
            "Số Lượng"});
            this.cbBookSearchBy.Location = new System.Drawing.Point(109, 175);
            this.cbBookSearchBy.Name = "cbBookSearchBy";
            this.cbBookSearchBy.Size = new System.Drawing.Size(175, 21);
            this.cbBookSearchBy.TabIndex = 3;
            this.cbBookSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbBookSearchBy_SelectedIndexChanged);
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookID,
            this.colTitle,
            this.colAuthor,
            this.colPublishHouse,
            this.colQuantity});
            this.dgvBook.Location = new System.Drawing.Point(6, 216);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.Size = new System.Drawing.Size(685, 262);
            this.dgvBook.TabIndex = 2;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(441, 24);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(175, 20);
            this.txtBookTitle.TabIndex = 1;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(362, 27);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(45, 13);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Tiêu Đề";
            // 
            // txtBookSearchValue
            // 
            this.txtBookSearchValue.Location = new System.Drawing.Point(441, 175);
            this.txtBookSearchValue.Name = "txtBookSearchValue";
            this.txtBookSearchValue.Size = new System.Drawing.Size(175, 20);
            this.txtBookSearchValue.TabIndex = 1;
            this.txtBookSearchValue.TextChanged += new System.EventHandler(this.txtBookSearchValue_TextChanged);
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Location = new System.Drawing.Point(441, 64);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(175, 20);
            this.txtBookPublisher.TabIndex = 1;
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Location = new System.Drawing.Point(109, 105);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(175, 20);
            this.txtBookQuantity.TabIndex = 1;
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(109, 64);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(175, 20);
            this.txtBookAuthor.TabIndex = 1;
            // 
            // lblBookSearchValue
            // 
            this.lblBookSearchValue.AutoSize = true;
            this.lblBookSearchValue.Location = new System.Drawing.Point(342, 177);
            this.lblBookSearchValue.Name = "lblBookSearchValue";
            this.lblBookSearchValue.Size = new System.Drawing.Size(50, 13);
            this.lblBookSearchValue.TabIndex = 0;
            this.lblBookSearchValue.Text = "Tìm Kiếm";
            // 
            // lblBookSearchBy
            // 
            this.lblBookSearchBy.AutoSize = true;
            this.lblBookSearchBy.Location = new System.Drawing.Point(20, 177);
            this.lblBookSearchBy.Name = "lblBookSearchBy";
            this.lblBookSearchBy.Size = new System.Drawing.Size(78, 13);
            this.lblBookSearchBy.TabIndex = 0;
            this.lblBookSearchBy.Text = "Tìm Kiếm Theo";
            // 
            // lblBookPublisher
            // 
            this.lblBookPublisher.AutoSize = true;
            this.lblBookPublisher.Location = new System.Drawing.Point(362, 67);
            this.lblBookPublisher.Name = "lblBookPublisher";
            this.lblBookPublisher.Size = new System.Drawing.Size(74, 13);
            this.lblBookPublisher.TabIndex = 0;
            this.lblBookPublisher.Text = "Nhà Xuất Bản";
            // 
            // txtBookId
            // 
            this.txtBookId.Enabled = false;
            this.txtBookId.Location = new System.Drawing.Point(109, 24);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(175, 20);
            this.txtBookId.TabIndex = 1;
            // 
            // lblBookQuantity
            // 
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.Location = new System.Drawing.Point(45, 108);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(53, 13);
            this.lblBookQuantity.TabIndex = 0;
            this.lblBookQuantity.Text = "Số Lượng";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(45, 67);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(45, 13);
            this.lblBookAuthor.TabIndex = 0;
            this.lblBookAuthor.Text = "Tác Giả";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(45, 27);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(50, 13);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.Text = "Mã Sách";
            // 
            // tabReader
            // 
            this.tabReader.Controls.Add(this.radReaderFemale);
            this.tabReader.Controls.Add(this.radReaderMale);
            this.tabReader.Controls.Add(this.btnReaderDelete);
            this.tabReader.Controls.Add(this.btnReaderUpdate);
            this.tabReader.Controls.Add(this.btnReaderAdd);
            this.tabReader.Controls.Add(this.label1);
            this.tabReader.Controls.Add(this.cbReaderSearchBy);
            this.tabReader.Controls.Add(this.dgvReader);
            this.tabReader.Controls.Add(this.txtReaderAddress);
            this.tabReader.Controls.Add(this.lblReaderAddress);
            this.tabReader.Controls.Add(this.txtReaderSearchValue);
            this.tabReader.Controls.Add(this.txtReaderPhone);
            this.tabReader.Controls.Add(this.txtReaderName);
            this.tabReader.Controls.Add(this.lblReaderSearchValue);
            this.tabReader.Controls.Add(this.lblReaderSearchBy);
            this.tabReader.Controls.Add(this.lblReaderPhone);
            this.tabReader.Controls.Add(this.txtReaderId);
            this.tabReader.Controls.Add(this.lblReaderGender);
            this.tabReader.Controls.Add(this.lblReaderName);
            this.tabReader.Controls.Add(this.lblReaderId);
            this.tabReader.Location = new System.Drawing.Point(4, 22);
            this.tabReader.Name = "tabReader";
            this.tabReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabReader.Size = new System.Drawing.Size(697, 484);
            this.tabReader.TabIndex = 1;
            this.tabReader.Text = "Quản Lý Người Đọc";
            this.tabReader.UseVisualStyleBackColor = true;
            // 
            // radReaderFemale
            // 
            this.radReaderFemale.AutoSize = true;
            this.radReaderFemale.Location = new System.Drawing.Point(199, 104);
            this.radReaderFemale.Name = "radReaderFemale";
            this.radReaderFemale.Size = new System.Drawing.Size(39, 17);
            this.radReaderFemale.TabIndex = 26;
            this.radReaderFemale.TabStop = true;
            this.radReaderFemale.Text = "Nữ";
            this.radReaderFemale.UseVisualStyleBackColor = true;
            // 
            // radReaderMale
            // 
            this.radReaderMale.AutoSize = true;
            this.radReaderMale.Checked = true;
            this.radReaderMale.Location = new System.Drawing.Point(109, 104);
            this.radReaderMale.Name = "radReaderMale";
            this.radReaderMale.Size = new System.Drawing.Size(47, 17);
            this.radReaderMale.TabIndex = 26;
            this.radReaderMale.TabStop = true;
            this.radReaderMale.Text = "Nam";
            this.radReaderMale.UseVisualStyleBackColor = true;
            // 
            // btnReaderDelete
            // 
            this.btnReaderDelete.Location = new System.Drawing.Point(547, 105);
            this.btnReaderDelete.Name = "btnReaderDelete";
            this.btnReaderDelete.Size = new System.Drawing.Size(69, 21);
            this.btnReaderDelete.TabIndex = 25;
            this.btnReaderDelete.Text = "Xóa";
            this.btnReaderDelete.UseVisualStyleBackColor = true;
            this.btnReaderDelete.Click += new System.EventHandler(this.btnReaderDelete_Click);
            // 
            // btnReaderUpdate
            // 
            this.btnReaderUpdate.Location = new System.Drawing.Point(456, 104);
            this.btnReaderUpdate.Name = "btnReaderUpdate";
            this.btnReaderUpdate.Size = new System.Drawing.Size(69, 21);
            this.btnReaderUpdate.TabIndex = 24;
            this.btnReaderUpdate.Text = "Sửa";
            this.btnReaderUpdate.UseVisualStyleBackColor = true;
            this.btnReaderUpdate.Click += new System.EventHandler(this.btnReaderUpdate_Click);
            // 
            // btnReaderAdd
            // 
            this.btnReaderAdd.Location = new System.Drawing.Point(364, 104);
            this.btnReaderAdd.Name = "btnReaderAdd";
            this.btnReaderAdd.Size = new System.Drawing.Size(69, 21);
            this.btnReaderAdd.TabIndex = 23;
            this.btnReaderAdd.Text = "Thêm";
            this.btnReaderAdd.UseVisualStyleBackColor = true;
            this.btnReaderAdd.Click += new System.EventHandler(this.btnReaderAdd_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(20, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 2);
            this.label1.TabIndex = 22;
            // 
            // cbReaderSearchBy
            // 
            this.cbReaderSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReaderSearchBy.FormattingEnabled = true;
            this.cbReaderSearchBy.Items.AddRange(new object[] {
            "ID",
            "Tên",
            "Địa Chỉ",
            "Số Điện Thoại",
            "Giới Tính"});
            this.cbReaderSearchBy.Location = new System.Drawing.Point(109, 175);
            this.cbReaderSearchBy.Name = "cbReaderSearchBy";
            this.cbReaderSearchBy.Size = new System.Drawing.Size(175, 21);
            this.cbReaderSearchBy.TabIndex = 21;
            this.cbReaderSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbReaderSearchBy_SelectedIndexChanged);
            // 
            // dgvReader
            // 
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReaderID,
            this.colReaderName,
            this.colReaderAddress,
            this.colReaderPhone,
            this.colReaderGender});
            this.dgvReader.Location = new System.Drawing.Point(6, 216);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.Size = new System.Drawing.Size(685, 262);
            this.dgvReader.TabIndex = 20;
            this.dgvReader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReader_CellClick);
            // 
            // txtReaderAddress
            // 
            this.txtReaderAddress.Location = new System.Drawing.Point(441, 24);
            this.txtReaderAddress.Name = "txtReaderAddress";
            this.txtReaderAddress.Size = new System.Drawing.Size(175, 20);
            this.txtReaderAddress.TabIndex = 18;
            // 
            // lblReaderAddress
            // 
            this.lblReaderAddress.AutoSize = true;
            this.lblReaderAddress.Location = new System.Drawing.Point(362, 27);
            this.lblReaderAddress.Name = "lblReaderAddress";
            this.lblReaderAddress.Size = new System.Drawing.Size(41, 13);
            this.lblReaderAddress.TabIndex = 12;
            this.lblReaderAddress.Text = "Địa Chỉ";
            // 
            // txtReaderSearchValue
            // 
            this.txtReaderSearchValue.Location = new System.Drawing.Point(441, 175);
            this.txtReaderSearchValue.Name = "txtReaderSearchValue";
            this.txtReaderSearchValue.Size = new System.Drawing.Size(175, 20);
            this.txtReaderSearchValue.TabIndex = 19;
            this.txtReaderSearchValue.TextChanged += new System.EventHandler(this.txtReaderSearchValue_TextChanged);
            // 
            // txtReaderPhone
            // 
            this.txtReaderPhone.Location = new System.Drawing.Point(441, 64);
            this.txtReaderPhone.Name = "txtReaderPhone";
            this.txtReaderPhone.Size = new System.Drawing.Size(175, 20);
            this.txtReaderPhone.TabIndex = 17;
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(109, 64);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(175, 20);
            this.txtReaderName.TabIndex = 15;
            // 
            // lblReaderSearchValue
            // 
            this.lblReaderSearchValue.AutoSize = true;
            this.lblReaderSearchValue.Location = new System.Drawing.Point(342, 177);
            this.lblReaderSearchValue.Name = "lblReaderSearchValue";
            this.lblReaderSearchValue.Size = new System.Drawing.Size(50, 13);
            this.lblReaderSearchValue.TabIndex = 11;
            this.lblReaderSearchValue.Text = "Tìm Kiếm";
            // 
            // lblReaderSearchBy
            // 
            this.lblReaderSearchBy.AutoSize = true;
            this.lblReaderSearchBy.Location = new System.Drawing.Point(20, 177);
            this.lblReaderSearchBy.Name = "lblReaderSearchBy";
            this.lblReaderSearchBy.Size = new System.Drawing.Size(78, 13);
            this.lblReaderSearchBy.TabIndex = 10;
            this.lblReaderSearchBy.Text = "Tìm Kiếm Theo";
            // 
            // lblReaderPhone
            // 
            this.lblReaderPhone.AutoSize = true;
            this.lblReaderPhone.Location = new System.Drawing.Point(362, 67);
            this.lblReaderPhone.Name = "lblReaderPhone";
            this.lblReaderPhone.Size = new System.Drawing.Size(75, 13);
            this.lblReaderPhone.TabIndex = 9;
            this.lblReaderPhone.Text = "Số Điện Thoại";
            // 
            // txtReaderId
            // 
            this.txtReaderId.Enabled = false;
            this.txtReaderId.Location = new System.Drawing.Point(109, 24);
            this.txtReaderId.Name = "txtReaderId";
            this.txtReaderId.ReadOnly = true;
            this.txtReaderId.Size = new System.Drawing.Size(175, 20);
            this.txtReaderId.TabIndex = 14;
            // 
            // lblReaderGender
            // 
            this.lblReaderGender.AutoSize = true;
            this.lblReaderGender.Location = new System.Drawing.Point(45, 108);
            this.lblReaderGender.Name = "lblReaderGender";
            this.lblReaderGender.Size = new System.Drawing.Size(51, 13);
            this.lblReaderGender.TabIndex = 8;
            this.lblReaderGender.Text = "Giới Tính";
            // 
            // lblReaderName
            // 
            this.lblReaderName.AutoSize = true;
            this.lblReaderName.Location = new System.Drawing.Point(45, 67);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(26, 13);
            this.lblReaderName.TabIndex = 13;
            this.lblReaderName.Text = "Tên";
            // 
            // lblReaderId
            // 
            this.lblReaderId.AutoSize = true;
            this.lblReaderId.Location = new System.Drawing.Point(45, 27);
            this.lblReaderId.Name = "lblReaderId";
            this.lblReaderId.Size = new System.Drawing.Size(18, 13);
            this.lblReaderId.TabIndex = 7;
            this.lblReaderId.Text = "ID";
            // 
            // tabVoucher
            // 
            this.tabVoucher.Controls.Add(this.dateVoucherDate);
            this.tabVoucher.Controls.Add(this.btnVoucherDelete);
            this.tabVoucher.Controls.Add(this.btnVoucherAdd);
            this.tabVoucher.Controls.Add(this.label2);
            this.tabVoucher.Controls.Add(this.cbVoucherSearchBy);
            this.tabVoucher.Controls.Add(this.dgvVoucher);
            this.tabVoucher.Controls.Add(this.txtVoucherQuantity);
            this.tabVoucher.Controls.Add(this.lblVoucherQuantity);
            this.tabVoucher.Controls.Add(this.txtVoucherSearchValue);
            this.tabVoucher.Controls.Add(this.txtVoucherReaderId);
            this.tabVoucher.Controls.Add(this.txtVoucherBookId);
            this.tabVoucher.Controls.Add(this.lblTimPhieu);
            this.tabVoucher.Controls.Add(this.lblVoucherSearchBy);
            this.tabVoucher.Controls.Add(this.lblVoucherDate);
            this.tabVoucher.Controls.Add(this.txtVoucherId);
            this.tabVoucher.Controls.Add(this.lblVoucherReaderId);
            this.tabVoucher.Controls.Add(this.lblVoucherBookId);
            this.tabVoucher.Controls.Add(this.lblVoucherId);
            this.tabVoucher.Location = new System.Drawing.Point(4, 22);
            this.tabVoucher.Name = "tabVoucher";
            this.tabVoucher.Padding = new System.Windows.Forms.Padding(3);
            this.tabVoucher.Size = new System.Drawing.Size(697, 484);
            this.tabVoucher.TabIndex = 2;
            this.tabVoucher.Text = "Quản Lý Phiếu Mượn";
            this.tabVoucher.UseVisualStyleBackColor = true;
            // 
            // dateVoucherDate
            // 
            this.dateVoucherDate.CustomFormat = "dd/MM/yyyy";
            this.dateVoucherDate.Enabled = false;
            this.dateVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVoucherDate.Location = new System.Drawing.Point(443, 64);
            this.dateVoucherDate.Name = "dateVoucherDate";
            this.dateVoucherDate.Size = new System.Drawing.Size(173, 20);
            this.dateVoucherDate.TabIndex = 26;
            // 
            // btnVoucherDelete
            // 
            this.btnVoucherDelete.Location = new System.Drawing.Point(547, 105);
            this.btnVoucherDelete.Name = "btnVoucherDelete";
            this.btnVoucherDelete.Size = new System.Drawing.Size(69, 21);
            this.btnVoucherDelete.TabIndex = 25;
            this.btnVoucherDelete.Text = "Xóa";
            this.btnVoucherDelete.UseVisualStyleBackColor = true;
            this.btnVoucherDelete.Click += new System.EventHandler(this.btnVoucherDelete_Click);
            // 
            // btnVoucherAdd
            // 
            this.btnVoucherAdd.Location = new System.Drawing.Point(441, 104);
            this.btnVoucherAdd.Name = "btnVoucherAdd";
            this.btnVoucherAdd.Size = new System.Drawing.Size(69, 21);
            this.btnVoucherAdd.TabIndex = 23;
            this.btnVoucherAdd.Text = "Thêm";
            this.btnVoucherAdd.UseVisualStyleBackColor = true;
            this.btnVoucherAdd.Click += new System.EventHandler(this.btnVoucherAdd_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(20, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(656, 2);
            this.label2.TabIndex = 22;
            // 
            // cbVoucherSearchBy
            // 
            this.cbVoucherSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoucherSearchBy.FormattingEnabled = true;
            this.cbVoucherSearchBy.Items.AddRange(new object[] {
            "Mã Phiếu",
            "Tiêu Đề",
            "Người Mượn",
            "Số Lượng",
            "Ngày Mượn"});
            this.cbVoucherSearchBy.Location = new System.Drawing.Point(109, 175);
            this.cbVoucherSearchBy.Name = "cbVoucherSearchBy";
            this.cbVoucherSearchBy.Size = new System.Drawing.Size(175, 21);
            this.cbVoucherSearchBy.TabIndex = 21;
            this.cbVoucherSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbVoucherSearchBy_SelectedIndexChanged);
            // 
            // dgvVoucher
            // 
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVoucherID,
            this.colBookTitle,
            this.colReader,
            this.colQuantityLend,
            this.colDate});
            this.dgvVoucher.Location = new System.Drawing.Point(6, 216);
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.Size = new System.Drawing.Size(685, 262);
            this.dgvVoucher.TabIndex = 20;
            this.dgvVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucher_CellClick);
            // 
            // txtVoucherQuantity
            // 
            this.txtVoucherQuantity.Location = new System.Drawing.Point(441, 24);
            this.txtVoucherQuantity.Name = "txtVoucherQuantity";
            this.txtVoucherQuantity.Size = new System.Drawing.Size(175, 20);
            this.txtVoucherQuantity.TabIndex = 18;
            // 
            // lblVoucherQuantity
            // 
            this.lblVoucherQuantity.AutoSize = true;
            this.lblVoucherQuantity.Location = new System.Drawing.Point(362, 27);
            this.lblVoucherQuantity.Name = "lblVoucherQuantity";
            this.lblVoucherQuantity.Size = new System.Drawing.Size(53, 13);
            this.lblVoucherQuantity.TabIndex = 12;
            this.lblVoucherQuantity.Text = "Số Lượng";
            // 
            // txtVoucherSearchValue
            // 
            this.txtVoucherSearchValue.Location = new System.Drawing.Point(441, 175);
            this.txtVoucherSearchValue.Name = "txtVoucherSearchValue";
            this.txtVoucherSearchValue.Size = new System.Drawing.Size(175, 20);
            this.txtVoucherSearchValue.TabIndex = 19;
            this.txtVoucherSearchValue.TextChanged += new System.EventHandler(this.txtVoucherSearchValue_TextChanged);
            // 
            // txtVoucherReaderId
            // 
            this.txtVoucherReaderId.Location = new System.Drawing.Point(109, 105);
            this.txtVoucherReaderId.Name = "txtVoucherReaderId";
            this.txtVoucherReaderId.Size = new System.Drawing.Size(175, 20);
            this.txtVoucherReaderId.TabIndex = 16;
            // 
            // txtVoucherBookId
            // 
            this.txtVoucherBookId.Location = new System.Drawing.Point(109, 64);
            this.txtVoucherBookId.Name = "txtVoucherBookId";
            this.txtVoucherBookId.Size = new System.Drawing.Size(175, 20);
            this.txtVoucherBookId.TabIndex = 15;
            // 
            // lblTimPhieu
            // 
            this.lblTimPhieu.AutoSize = true;
            this.lblTimPhieu.Location = new System.Drawing.Point(342, 177);
            this.lblTimPhieu.Name = "lblTimPhieu";
            this.lblTimPhieu.Size = new System.Drawing.Size(50, 13);
            this.lblTimPhieu.TabIndex = 11;
            this.lblTimPhieu.Text = "Tìm Kiếm";
            // 
            // lblVoucherSearchBy
            // 
            this.lblVoucherSearchBy.AutoSize = true;
            this.lblVoucherSearchBy.Location = new System.Drawing.Point(20, 177);
            this.lblVoucherSearchBy.Name = "lblVoucherSearchBy";
            this.lblVoucherSearchBy.Size = new System.Drawing.Size(78, 13);
            this.lblVoucherSearchBy.TabIndex = 10;
            this.lblVoucherSearchBy.Text = "Tìm Kiếm Theo";
            // 
            // lblVoucherDate
            // 
            this.lblVoucherDate.AutoSize = true;
            this.lblVoucherDate.Location = new System.Drawing.Point(362, 67);
            this.lblVoucherDate.Name = "lblVoucherDate";
            this.lblVoucherDate.Size = new System.Drawing.Size(62, 13);
            this.lblVoucherDate.TabIndex = 9;
            this.lblVoucherDate.Text = "Ngày Mượn";
            // 
            // txtVoucherId
            // 
            this.txtVoucherId.Enabled = false;
            this.txtVoucherId.Location = new System.Drawing.Point(109, 24);
            this.txtVoucherId.Name = "txtVoucherId";
            this.txtVoucherId.ReadOnly = true;
            this.txtVoucherId.Size = new System.Drawing.Size(175, 20);
            this.txtVoucherId.TabIndex = 14;
            // 
            // lblVoucherReaderId
            // 
            this.lblVoucherReaderId.AutoSize = true;
            this.lblVoucherReaderId.Location = new System.Drawing.Point(45, 108);
            this.lblVoucherReaderId.Name = "lblVoucherReaderId";
            this.lblVoucherReaderId.Size = new System.Drawing.Size(64, 13);
            this.lblVoucherReaderId.TabIndex = 8;
            this.lblVoucherReaderId.Text = "Mã Độc Giả";
            // 
            // lblVoucherBookId
            // 
            this.lblVoucherBookId.AutoSize = true;
            this.lblVoucherBookId.Location = new System.Drawing.Point(45, 67);
            this.lblVoucherBookId.Name = "lblVoucherBookId";
            this.lblVoucherBookId.Size = new System.Drawing.Size(50, 13);
            this.lblVoucherBookId.TabIndex = 13;
            this.lblVoucherBookId.Text = "Mã Sách";
            // 
            // lblVoucherId
            // 
            this.lblVoucherId.AutoSize = true;
            this.lblVoucherId.Location = new System.Drawing.Point(45, 27);
            this.lblVoucherId.Name = "lblVoucherId";
            this.lblVoucherId.Size = new System.Drawing.Size(52, 13);
            this.lblVoucherId.TabIndex = 7;
            this.lblVoucherId.Text = "Mã Phiếu";
            // 
            // colBookID
            // 
            this.colBookID.DataPropertyName = "ID";
            this.colBookID.HeaderText = "Mã Sách";
            this.colBookID.Name = "colBookID";
            this.colBookID.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "Tiêu Đề";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 150;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "Author";
            this.colAuthor.HeaderText = "Tác Giả";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 150;
            // 
            // colPublishHouse
            // 
            this.colPublishHouse.DataPropertyName = "Publisher";
            this.colPublishHouse.HeaderText = "Nhà Xuất Bản";
            this.colPublishHouse.Name = "colPublishHouse";
            this.colPublishHouse.ReadOnly = true;
            this.colPublishHouse.Width = 150;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Số Lượng";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colReaderID
            // 
            this.colReaderID.DataPropertyName = "ID";
            this.colReaderID.HeaderText = "ID";
            this.colReaderID.Name = "colReaderID";
            this.colReaderID.ReadOnly = true;
            // 
            // colReaderName
            // 
            this.colReaderName.DataPropertyName = "Name";
            this.colReaderName.HeaderText = "Tên";
            this.colReaderName.Name = "colReaderName";
            this.colReaderName.ReadOnly = true;
            this.colReaderName.Width = 150;
            // 
            // colReaderAddress
            // 
            this.colReaderAddress.DataPropertyName = "Address";
            this.colReaderAddress.HeaderText = "Địa Chỉ";
            this.colReaderAddress.Name = "colReaderAddress";
            this.colReaderAddress.ReadOnly = true;
            this.colReaderAddress.Width = 190;
            // 
            // colReaderPhone
            // 
            this.colReaderPhone.DataPropertyName = "Phone";
            this.colReaderPhone.HeaderText = "Số Điện Thoại";
            this.colReaderPhone.Name = "colReaderPhone";
            this.colReaderPhone.ReadOnly = true;
            this.colReaderPhone.Width = 110;
            // 
            // colReaderGender
            // 
            this.colReaderGender.DataPropertyName = "Gender";
            this.colReaderGender.HeaderText = "Giới Tính";
            this.colReaderGender.Name = "colReaderGender";
            this.colReaderGender.ReadOnly = true;
            // 
            // colVoucherID
            // 
            this.colVoucherID.DataPropertyName = "ID";
            this.colVoucherID.HeaderText = "Mã Phiếu";
            this.colVoucherID.Name = "colVoucherID";
            this.colVoucherID.ReadOnly = true;
            // 
            // colBookTitle
            // 
            this.colBookTitle.DataPropertyName = "BookTitle";
            this.colBookTitle.HeaderText = "Tiêu Đề";
            this.colBookTitle.Name = "colBookTitle";
            this.colBookTitle.ReadOnly = true;
            this.colBookTitle.Width = 170;
            // 
            // colReader
            // 
            this.colReader.DataPropertyName = "ReaderName";
            this.colReader.HeaderText = "Người Mượn";
            this.colReader.Name = "colReader";
            this.colReader.ReadOnly = true;
            this.colReader.Width = 170;
            // 
            // colQuantityLend
            // 
            this.colQuantityLend.DataPropertyName = "Quantity";
            this.colQuantityLend.HeaderText = "Số Lượng";
            this.colQuantityLend.Name = "colQuantityLend";
            this.colQuantityLend.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.colDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDate.HeaderText = "Ngày Mượn";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 541);
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.Text = "LIBRARY MANAGEMENT";
            this.tabControl.ResumeLayout(false);
            this.tabBook.ResumeLayout(false);
            this.tabBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.tabReader.ResumeLayout(false);
            this.tabReader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            this.tabVoucher.ResumeLayout(false);
            this.tabVoucher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBook;
        private System.Windows.Forms.TabPage tabReader;
        private System.Windows.Forms.TabPage tabVoucher;
        private System.Windows.Forms.Label lblDevider;
        private System.Windows.Forms.ComboBox cbBookSearchBy;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookSearchValue;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label lblBookSearchValue;
        private System.Windows.Forms.Label lblBookSearchBy;
        private System.Windows.Forms.Label lblBookPublisher;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookQuantity;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Button btnReaderDelete;
        private System.Windows.Forms.Button btnReaderUpdate;
        private System.Windows.Forms.Button btnReaderAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbReaderSearchBy;
        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.TextBox txtReaderAddress;
        private System.Windows.Forms.Label lblReaderAddress;
        private System.Windows.Forms.TextBox txtReaderSearchValue;
        private System.Windows.Forms.TextBox txtReaderPhone;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label lblReaderSearchValue;
        private System.Windows.Forms.Label lblReaderSearchBy;
        private System.Windows.Forms.Label lblReaderPhone;
        private System.Windows.Forms.TextBox txtReaderId;
        private System.Windows.Forms.Label lblReaderGender;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.Label lblReaderId;
        private System.Windows.Forms.RadioButton radReaderFemale;
        private System.Windows.Forms.RadioButton radReaderMale;
        private System.Windows.Forms.DateTimePicker dateVoucherDate;
        private System.Windows.Forms.Button btnVoucherDelete;
        private System.Windows.Forms.Button btnVoucherAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVoucherSearchBy;
        private System.Windows.Forms.DataGridView dgvVoucher;
        private System.Windows.Forms.TextBox txtVoucherQuantity;
        private System.Windows.Forms.Label lblVoucherQuantity;
        private System.Windows.Forms.TextBox txtVoucherSearchValue;
        private System.Windows.Forms.TextBox txtVoucherReaderId;
        private System.Windows.Forms.TextBox txtVoucherBookId;
        private System.Windows.Forms.Label lblTimPhieu;
        private System.Windows.Forms.Label lblVoucherSearchBy;
        private System.Windows.Forms.Label lblVoucherDate;
        private System.Windows.Forms.TextBox txtVoucherId;
        private System.Windows.Forms.Label lblVoucherReaderId;
        private System.Windows.Forms.Label lblVoucherBookId;
        private System.Windows.Forms.Label lblVoucherId;
        private DataGridViewTextBoxColumn colBookID;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colPublishHouse;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colReaderID;
        private DataGridViewTextBoxColumn colReaderName;
        private DataGridViewTextBoxColumn colReaderAddress;
        private DataGridViewTextBoxColumn colReaderPhone;
        private DataGridViewTextBoxColumn colReaderGender;
        private DataGridViewTextBoxColumn colVoucherID;
        private DataGridViewTextBoxColumn colBookTitle;
        private DataGridViewTextBoxColumn colReader;
        private DataGridViewTextBoxColumn colQuantityLend;
        private DataGridViewTextBoxColumn colDate;
    }
}