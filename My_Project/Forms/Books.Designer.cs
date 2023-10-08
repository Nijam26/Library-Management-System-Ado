namespace My_Project
{
    partial class Books
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.cboBoxSearch = new System.Windows.Forms.ComboBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.cboBoxCategories = new System.Windows.Forms.ComboBox();
            this.bookTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookShopDBDataSet = new My_Project.BookShopDBDataSet();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuentity = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuentity = new System.Windows.Forms.TextBox();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.bIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblBkList = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAuthar = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtAuthar = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.bookTblTableAdapter = new My_Project.BookShopDBDataSetTableAdapters.BookTblTableAdapter();
            this.bookShopDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShopDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.cboBoxSearch);
            this.panel2.Controls.Add(this.btnRef);
            this.panel2.Controls.Add(this.cboBoxCategories);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblQuentity);
            this.panel2.Controls.Add(this.lblCategories);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtQuentity);
            this.panel2.Controls.Add(this.BookDGV);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.lblBkList);
            this.panel2.Controls.Add(this.lblExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lblAuthar);
            this.panel2.Controls.Add(this.lblBookTitle);
            this.panel2.Controls.Add(this.txtAuthar);
            this.panel2.Controls.Add(this.txtBookTitle);
            this.panel2.Controls.Add(this.picBoxLogo);
            this.panel2.Location = new System.Drawing.Point(171, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 479);
            this.panel2.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.LimeGreen;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(494, 242);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(111, 30);
            this.btnReport.TabIndex = 27;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cboBoxSearch
            // 
            this.cboBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxSearch.FormattingEnabled = true;
            this.cboBoxSearch.Items.AddRange(new object[] {
            "C#",
            "NT",
            "GAVE",
            "WDPF",
            "Fiction",
            "Non-Fiction"});
            this.cboBoxSearch.Location = new System.Drawing.Point(177, 244);
            this.cboBoxSearch.Name = "cboBoxSearch";
            this.cboBoxSearch.Size = new System.Drawing.Size(173, 29);
            this.cboBoxSearch.TabIndex = 26;
            this.cboBoxSearch.Tag = "";
            this.cboBoxSearch.Text = "Filter By Categories";
            this.cboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.cboBoxSearch_SelectedIndexChanged);
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRef.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.ForeColor = System.Drawing.Color.White;
            this.btnRef.Location = new System.Drawing.Point(370, 243);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(83, 29);
            this.btnRef.TabIndex = 25;
            this.btnRef.Text = "Refresh";
            this.btnRef.UseVisualStyleBackColor = false;
            this.btnRef.Click += new System.EventHandler(this.butRef_Click);
            // 
            // cboBoxCategories
            // 
            this.cboBoxCategories.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookTblBindingSource, "BCat", true));
            this.cboBoxCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxCategories.FormattingEnabled = true;
            this.cboBoxCategories.Items.AddRange(new object[] {
            "C#",
            "NT",
            "GAVE",
            "WDPF",
            "Fiction",
            "Non-Fiction"});
            this.cboBoxCategories.Location = new System.Drawing.Point(282, 98);
            this.cboBoxCategories.Name = "cboBoxCategories";
            this.cboBoxCategories.Size = new System.Drawing.Size(172, 29);
            this.cboBoxCategories.TabIndex = 24;
            this.cboBoxCategories.Text = "Select Categories";
            // 
            // bookTblBindingSource
            // 
            this.bookTblBindingSource.DataMember = "BookTbl";
            this.bookTblBindingSource.DataSource = this.bookShopDBDataSet;
            // 
            // bookShopDBDataSet
            // 
            this.bookShopDBDataSet.DataSetName = "BookShopDBDataSet";
            this.bookShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPrice.Location = new System.Drawing.Point(548, 74);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 19);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Price";
            // 
            // lblQuentity
            // 
            this.lblQuentity.AutoSize = true;
            this.lblQuentity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuentity.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblQuentity.Location = new System.Drawing.Point(455, 74);
            this.lblQuentity.Name = "lblQuentity";
            this.lblQuentity.Size = new System.Drawing.Size(73, 19);
            this.lblQuentity.TabIndex = 22;
            this.lblQuentity.Text = "Quentity";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblCategories.Location = new System.Drawing.Point(278, 76);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(92, 19);
            this.lblCategories.TabIndex = 21;
            this.lblCategories.Text = "Categories";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(551, 98);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(63, 27);
            this.txtPrice.TabIndex = 20;
            // 
            // txtQuentity
            // 
            this.txtQuentity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuentity.Location = new System.Drawing.Point(460, 98);
            this.txtQuentity.Name = "txtQuentity";
            this.txtQuentity.Size = new System.Drawing.Size(84, 27);
            this.txtQuentity.TabIndex = 19;
            // 
            // BookDGV
            // 
            this.BookDGV.AutoGenerateColumns = false;
            this.BookDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIdDataGridViewTextBoxColumn,
            this.bTitleDataGridViewTextBoxColumn,
            this.bAuthorDataGridViewTextBoxColumn,
            this.bCatDataGridViewTextBoxColumn,
            this.bQtyDataGridViewTextBoxColumn,
            this.bPriceDataGridViewTextBoxColumn});
            this.BookDGV.DataSource = this.bookTblBindingSource;
            this.BookDGV.GridColor = System.Drawing.Color.Black;
            this.BookDGV.Location = new System.Drawing.Point(5, 281);
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.RowHeadersWidth = 30;
            this.BookDGV.Size = new System.Drawing.Size(620, 182);
            this.BookDGV.TabIndex = 18;
            this.BookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellContentClick);
            // 
            // bIdDataGridViewTextBoxColumn
            // 
            this.bIdDataGridViewTextBoxColumn.DataPropertyName = "BId";
            this.bIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.bIdDataGridViewTextBoxColumn.Name = "bIdDataGridViewTextBoxColumn";
            this.bIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // bTitleDataGridViewTextBoxColumn
            // 
            this.bTitleDataGridViewTextBoxColumn.DataPropertyName = "BTitle";
            this.bTitleDataGridViewTextBoxColumn.HeaderText = "Book Title";
            this.bTitleDataGridViewTextBoxColumn.Name = "bTitleDataGridViewTextBoxColumn";
            // 
            // bAuthorDataGridViewTextBoxColumn
            // 
            this.bAuthorDataGridViewTextBoxColumn.DataPropertyName = "BAuthor";
            this.bAuthorDataGridViewTextBoxColumn.HeaderText = "Book Author";
            this.bAuthorDataGridViewTextBoxColumn.Name = "bAuthorDataGridViewTextBoxColumn";
            // 
            // bCatDataGridViewTextBoxColumn
            // 
            this.bCatDataGridViewTextBoxColumn.DataPropertyName = "BCat";
            this.bCatDataGridViewTextBoxColumn.HeaderText = "Categories";
            this.bCatDataGridViewTextBoxColumn.Name = "bCatDataGridViewTextBoxColumn";
            this.bCatDataGridViewTextBoxColumn.Width = 90;
            // 
            // bQtyDataGridViewTextBoxColumn
            // 
            this.bQtyDataGridViewTextBoxColumn.DataPropertyName = "BQty";
            this.bQtyDataGridViewTextBoxColumn.HeaderText = "Quentity";
            this.bQtyDataGridViewTextBoxColumn.Name = "bQtyDataGridViewTextBoxColumn";
            this.bQtyDataGridViewTextBoxColumn.Width = 90;
            // 
            // bPriceDataGridViewTextBoxColumn
            // 
            this.bPriceDataGridViewTextBoxColumn.DataPropertyName = "BPrice";
            this.bPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.bPriceDataGridViewTextBoxColumn.Name = "bPriceDataGridViewTextBoxColumn";
            this.bPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LimeGreen;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(408, 152);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 30);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(297, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(188, 152);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 30);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblBkList
            // 
            this.lblBkList.AutoSize = true;
            this.lblBkList.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBkList.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblBkList.Location = new System.Drawing.Point(274, 207);
            this.lblBkList.Name = "lblBkList";
            this.lblBkList.Size = new System.Drawing.Size(88, 23);
            this.lblBkList.TabIndex = 14;
            this.lblBkList.Text = "Book List";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Red;
            this.lblExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(606, 4);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(20, 19);
            this.lblExit.TabIndex = 13;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(78, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAuthar
            // 
            this.lblAuthar.AutoSize = true;
            this.lblAuthar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAuthar.Location = new System.Drawing.Point(163, 74);
            this.lblAuthar.Name = "lblAuthar";
            this.lblAuthar.Size = new System.Drawing.Size(61, 19);
            this.lblAuthar.TabIndex = 7;
            this.lblAuthar.Text = "Authar";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblBookTitle.Location = new System.Drawing.Point(8, 74);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(80, 19);
            this.lblBookTitle.TabIndex = 6;
            this.lblBookTitle.Text = "BookTittle";
            // 
            // txtAuthar
            // 
            this.txtAuthar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthar.Location = new System.Drawing.Point(167, 100);
            this.txtAuthar.Name = "txtAuthar";
            this.txtAuthar.Size = new System.Drawing.Size(109, 27);
            this.txtAuthar.TabIndex = 5;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(7, 99);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(154, 27);
            this.txtBookTitle.TabIndex = 4;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(267, 4);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(95, 56);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 3;
            this.picBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnBooks);
            this.panel1.Location = new System.Drawing.Point(5, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 479);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 434);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 42);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 236);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(165, 42);
            this.btnDashboard.TabIndex = 22;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 188);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(165, 42);
            this.btnUsers.TabIndex = 21;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBooks.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Location = new System.Drawing.Point(0, 140);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(165, 42);
            this.btnBooks.TabIndex = 20;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            // 
            // bookTblTableAdapter
            // 
            this.bookTblTableAdapter.ClearBeforeFill = true;
            // 
            // bookShopDBDataSetBindingSource
            // 
            this.bookShopDBDataSetBindingSource.DataSource = this.bookShopDBDataSet;
            this.bookShopDBDataSetBindingSource.Position = 0;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShopDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAuthar;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtAuthar;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBkList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView BookDGV;
        private System.Windows.Forms.ComboBox cboBoxCategories;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuentity;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuentity;
        private System.Windows.Forms.ComboBox cboBoxSearch;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnBooks;
        private BookShopDBDataSet bookShopDBDataSet;
        private System.Windows.Forms.BindingSource bookTblBindingSource;
        private BookShopDBDataSetTableAdapters.BookTblTableAdapter bookTblTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookShopDBDataSetBindingSource;
        private System.Windows.Forms.Button btnReport;
    }
}