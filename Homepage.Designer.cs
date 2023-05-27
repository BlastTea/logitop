namespace Logitop
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridLaptop = new DataGridView();
            laptop_name = new DataGridViewTextBoxColumn();
            laptop_price = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            buttonSaveLaptop = new Button();
            tabControlHome = new TabControl();
            tabLaptop = new TabPage();
            textBoxLaptopStock = new TextBox();
            labelLaptopStock = new Label();
            textBoxLaptopPrice = new TextBox();
            labelLaptopPrice = new Label();
            labelLaptopName = new Label();
            textBoxLaptopName = new TextBox();
            buttonClear = new Button();
            buttonDelete = new Button();
            tabTransaksi = new TabPage();
            dataGridLaptopTransaction = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            add_to_transaction = new DataGridViewButtonColumn();
            buttonTransactionPay = new Button();
            textBoxTransactionChange = new TextBox();
            textBoxTransactionPay = new TextBox();
            labelTransactionChange = new Label();
            labelPayTransaction = new Label();
            labelTotalTransaction = new Label();
            textBoxTransactionTotal = new TextBox();
            dataGridShoppingCart = new DataGridView();
            laptop_name_transaction = new DataGridViewTextBoxColumn();
            laptop_price_transaction = new DataGridViewTextBoxColumn();
            laptop_amount_transaction = new DataGridViewTextBoxColumn();
            remove_item_transaction = new DataGridViewButtonColumn();
            tabLaporan = new TabPage();
            textBoxReportChange = new TextBox();
            labelReportChange = new Label();
            textBoxReportPay = new TextBox();
            labelReportPay = new Label();
            textBoxReportTotal = new TextBox();
            labelReportTotal = new Label();
            dataGridViewReportDetailTransaction = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridReportTransaction = new DataGridView();
            id_report_transaction = new DataGridViewTextBoxColumn();
            date_report_transaction = new DataGridViewTextBoxColumn();
            tabWeatherApi = new TabPage();
            labelVisibilityValue = new Label();
            labelVisibility = new Label();
            labelGroundPressureValue = new Label();
            labelSeaPressureValue = new Label();
            labelGroundPressure = new Label();
            labelSeaPressure = new Label();
            labelMainPressure = new Label();
            labelHumidityValue = new Label();
            labelHumidity = new Label();
            comboBoxUnit = new ComboBox();
            labelMainPressureValue = new Label();
            labelPressure = new Label();
            labelMaxTemperatureValue = new Label();
            labelMaxTemperature = new Label();
            labelMinimalTemperatureValue = new Label();
            labelMinimalTemperature = new Label();
            labelMainTemperatureValue = new Label();
            labelMainTemperature = new Label();
            labelTemperature = new Label();
            labelWeatherValue = new Label();
            labelWeather = new Label();
            labelLongitudeValue = new Label();
            labelLongitude = new Label();
            labelLatitudeValue = new Label();
            labelLatitude = new Label();
            labelCoordinate = new Label();
            labelResult = new Label();
            buttonSearchWeather = new Button();
            textBoxSearchWeather = new TextBox();
            labelCityName = new Label();
            tabPengaturan = new TabPage();
            labelWind = new Label();
            labelWindSpeed = new Label();
            labelWindSpeedValue = new Label();
            labelWindDegree = new Label();
            labelWindDegreeValue = new Label();
            labelWindGust = new Label();
            labelWindGustValue = new Label();
            labelCloudiness = new Label();
            labelCloudinessValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridLaptop).BeginInit();
            tabControlHome.SuspendLayout();
            tabLaptop.SuspendLayout();
            tabTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLaptopTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridShoppingCart).BeginInit();
            tabLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportDetailTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridReportTransaction).BeginInit();
            tabWeatherApi.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridLaptop
            // 
            dataGridLaptop.AllowUserToAddRows = false;
            dataGridLaptop.AllowUserToDeleteRows = false;
            dataGridLaptop.AllowUserToResizeRows = false;
            dataGridLaptop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLaptop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLaptop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLaptop.Columns.AddRange(new DataGridViewColumn[] { laptop_name, laptop_price, stock });
            dataGridLaptop.Location = new Point(3, 3);
            dataGridLaptop.MultiSelect = false;
            dataGridLaptop.Name = "dataGridLaptop";
            dataGridLaptop.ReadOnly = true;
            dataGridLaptop.RowHeadersVisible = false;
            dataGridLaptop.RowHeadersWidth = 51;
            dataGridLaptop.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridLaptop.RowTemplate.Height = 29;
            dataGridLaptop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridLaptop.Size = new Size(801, 534);
            dataGridLaptop.TabIndex = 0;
            dataGridLaptop.CellDoubleClick += OnDataGridLaptopCellDoubleClick;
            // 
            // laptop_name
            // 
            laptop_name.HeaderText = "Nama Laptop";
            laptop_name.MinimumWidth = 6;
            laptop_name.Name = "laptop_name";
            laptop_name.ReadOnly = true;
            laptop_name.Resizable = DataGridViewTriState.True;
            laptop_name.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // laptop_price
            // 
            laptop_price.HeaderText = "Harga Laptop";
            laptop_price.MinimumWidth = 6;
            laptop_price.Name = "laptop_price";
            laptop_price.ReadOnly = true;
            laptop_price.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // stock
            // 
            stock.HeaderText = "Stok";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonSaveLaptop
            // 
            buttonSaveLaptop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveLaptop.Location = new Point(1022, 503);
            buttonSaveLaptop.Name = "buttonSaveLaptop";
            buttonSaveLaptop.Size = new Size(100, 29);
            buttonSaveLaptop.TabIndex = 1;
            buttonSaveLaptop.Text = "Simpan";
            buttonSaveLaptop.UseVisualStyleBackColor = true;
            buttonSaveLaptop.Click += OnButtonSaveLaptopClick;
            // 
            // tabControlHome
            // 
            tabControlHome.Controls.Add(tabLaptop);
            tabControlHome.Controls.Add(tabTransaksi);
            tabControlHome.Controls.Add(tabLaporan);
            tabControlHome.Controls.Add(tabWeatherApi);
            tabControlHome.Controls.Add(tabPengaturan);
            tabControlHome.Dock = DockStyle.Fill;
            tabControlHome.Location = new Point(0, 0);
            tabControlHome.Name = "tabControlHome";
            tabControlHome.SelectedIndex = 0;
            tabControlHome.Size = new Size(1138, 573);
            tabControlHome.TabIndex = 2;
            // 
            // tabLaptop
            // 
            tabLaptop.Controls.Add(textBoxLaptopStock);
            tabLaptop.Controls.Add(labelLaptopStock);
            tabLaptop.Controls.Add(textBoxLaptopPrice);
            tabLaptop.Controls.Add(labelLaptopPrice);
            tabLaptop.Controls.Add(labelLaptopName);
            tabLaptop.Controls.Add(textBoxLaptopName);
            tabLaptop.Controls.Add(buttonClear);
            tabLaptop.Controls.Add(buttonDelete);
            tabLaptop.Controls.Add(buttonSaveLaptop);
            tabLaptop.Controls.Add(dataGridLaptop);
            tabLaptop.Location = new Point(4, 29);
            tabLaptop.Name = "tabLaptop";
            tabLaptop.Padding = new Padding(3);
            tabLaptop.Size = new Size(1130, 540);
            tabLaptop.TabIndex = 0;
            tabLaptop.Text = "Laptop";
            tabLaptop.UseVisualStyleBackColor = true;
            // 
            // textBoxLaptopStock
            // 
            textBoxLaptopStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxLaptopStock.Location = new Point(810, 132);
            textBoxLaptopStock.Name = "textBoxLaptopStock";
            textBoxLaptopStock.Size = new Size(312, 27);
            textBoxLaptopStock.TabIndex = 9;
            textBoxLaptopStock.Text = "0";
            textBoxLaptopStock.KeyPress += OnTextBoxLaptopStockKeyPressed;
            // 
            // labelLaptopStock
            // 
            labelLaptopStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLaptopStock.AutoSize = true;
            labelLaptopStock.Location = new Point(810, 109);
            labelLaptopStock.Name = "labelLaptopStock";
            labelLaptopStock.Size = new Size(38, 20);
            labelLaptopStock.TabIndex = 8;
            labelLaptopStock.Text = "Stok";
            // 
            // textBoxLaptopPrice
            // 
            textBoxLaptopPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxLaptopPrice.Location = new Point(810, 79);
            textBoxLaptopPrice.Name = "textBoxLaptopPrice";
            textBoxLaptopPrice.Size = new Size(312, 27);
            textBoxLaptopPrice.TabIndex = 7;
            textBoxLaptopPrice.KeyPress += OnTextBoxLaptopPriceKeyPressed;
            // 
            // labelLaptopPrice
            // 
            labelLaptopPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLaptopPrice.AutoSize = true;
            labelLaptopPrice.Location = new Point(810, 56);
            labelLaptopPrice.Name = "labelLaptopPrice";
            labelLaptopPrice.Size = new Size(101, 20);
            labelLaptopPrice.TabIndex = 6;
            labelLaptopPrice.Text = "Harga Laptop";
            // 
            // labelLaptopName
            // 
            labelLaptopName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLaptopName.AutoSize = true;
            labelLaptopName.Location = new Point(810, 3);
            labelLaptopName.Name = "labelLaptopName";
            labelLaptopName.Size = new Size(100, 20);
            labelLaptopName.TabIndex = 5;
            labelLaptopName.Text = "Nama Laptop";
            // 
            // textBoxLaptopName
            // 
            textBoxLaptopName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxLaptopName.Location = new Point(810, 26);
            textBoxLaptopName.Name = "textBoxLaptopName";
            textBoxLaptopName.Size = new Size(312, 27);
            textBoxLaptopName.TabIndex = 4;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClear.Location = new Point(810, 503);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(100, 29);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Bersihkan";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += OnButtonClearLaptopClick;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.Location = new Point(916, 503);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Hapus";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += OnButtonDeleteLaptopClick;
            // 
            // tabTransaksi
            // 
            tabTransaksi.Controls.Add(dataGridLaptopTransaction);
            tabTransaksi.Controls.Add(buttonTransactionPay);
            tabTransaksi.Controls.Add(textBoxTransactionChange);
            tabTransaksi.Controls.Add(textBoxTransactionPay);
            tabTransaksi.Controls.Add(labelTransactionChange);
            tabTransaksi.Controls.Add(labelPayTransaction);
            tabTransaksi.Controls.Add(labelTotalTransaction);
            tabTransaksi.Controls.Add(textBoxTransactionTotal);
            tabTransaksi.Controls.Add(dataGridShoppingCart);
            tabTransaksi.Location = new Point(4, 29);
            tabTransaksi.Name = "tabTransaksi";
            tabTransaksi.Padding = new Padding(3);
            tabTransaksi.Size = new Size(1130, 540);
            tabTransaksi.TabIndex = 1;
            tabTransaksi.Text = "Transaksi";
            tabTransaksi.UseVisualStyleBackColor = true;
            // 
            // dataGridLaptopTransaction
            // 
            dataGridLaptopTransaction.AllowUserToAddRows = false;
            dataGridLaptopTransaction.AllowUserToDeleteRows = false;
            dataGridLaptopTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLaptopTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLaptopTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLaptopTransaction.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, add_to_transaction });
            dataGridLaptopTransaction.Location = new Point(3, 3);
            dataGridLaptopTransaction.MultiSelect = false;
            dataGridLaptopTransaction.Name = "dataGridLaptopTransaction";
            dataGridLaptopTransaction.ReadOnly = true;
            dataGridLaptopTransaction.RowHeadersVisible = false;
            dataGridLaptopTransaction.RowHeadersWidth = 51;
            dataGridLaptopTransaction.RowTemplate.Height = 29;
            dataGridLaptopTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridLaptopTransaction.Size = new Size(679, 534);
            dataGridLaptopTransaction.TabIndex = 9;
            dataGridLaptopTransaction.CellContentClick += OnDataGridLaptopTransactionCellContentClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nama Laptop";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Harga Laptop";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Stok";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // add_to_transaction
            // 
            add_to_transaction.HeaderText = "Aksi";
            add_to_transaction.MinimumWidth = 6;
            add_to_transaction.Name = "add_to_transaction";
            add_to_transaction.ReadOnly = true;
            add_to_transaction.Text = "Tambah";
            add_to_transaction.ToolTipText = "Tambah Laptop ke keranjang";
            // 
            // buttonTransactionPay
            // 
            buttonTransactionPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonTransactionPay.AutoSize = true;
            buttonTransactionPay.Location = new Point(688, 502);
            buttonTransactionPay.Name = "buttonTransactionPay";
            buttonTransactionPay.Size = new Size(434, 30);
            buttonTransactionPay.TabIndex = 8;
            buttonTransactionPay.Text = "Bayar";
            buttonTransactionPay.UseVisualStyleBackColor = true;
            buttonTransactionPay.Click += OnButtonTransactionPayClick;
            // 
            // textBoxTransactionChange
            // 
            textBoxTransactionChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTransactionChange.Location = new Point(688, 470);
            textBoxTransactionChange.Name = "textBoxTransactionChange";
            textBoxTransactionChange.ReadOnly = true;
            textBoxTransactionChange.Size = new Size(434, 27);
            textBoxTransactionChange.TabIndex = 7;
            // 
            // textBoxTransactionPay
            // 
            textBoxTransactionPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTransactionPay.Location = new Point(688, 417);
            textBoxTransactionPay.Name = "textBoxTransactionPay";
            textBoxTransactionPay.Size = new Size(434, 27);
            textBoxTransactionPay.TabIndex = 6;
            textBoxTransactionPay.TextChanged += OnTextBoxTransactionPayTextChanged;
            textBoxTransactionPay.KeyPress += OnTextBoxTransactionPayKeyPressed;
            // 
            // labelTransactionChange
            // 
            labelTransactionChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTransactionChange.AutoSize = true;
            labelTransactionChange.Location = new Point(688, 447);
            labelTransactionChange.Name = "labelTransactionChange";
            labelTransactionChange.Size = new Size(64, 20);
            labelTransactionChange.TabIndex = 5;
            labelTransactionChange.Text = "Kembali";
            // 
            // labelPayTransaction
            // 
            labelPayTransaction.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPayTransaction.AutoSize = true;
            labelPayTransaction.Location = new Point(688, 394);
            labelPayTransaction.Name = "labelPayTransaction";
            labelPayTransaction.Size = new Size(46, 20);
            labelPayTransaction.TabIndex = 4;
            labelPayTransaction.Text = "Bayar";
            // 
            // labelTotalTransaction
            // 
            labelTotalTransaction.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotalTransaction.AutoSize = true;
            labelTotalTransaction.Location = new Point(688, 341);
            labelTotalTransaction.Name = "labelTotalTransaction";
            labelTotalTransaction.Size = new Size(42, 20);
            labelTotalTransaction.TabIndex = 3;
            labelTotalTransaction.Text = "Total";
            // 
            // textBoxTransactionTotal
            // 
            textBoxTransactionTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTransactionTotal.Location = new Point(688, 364);
            textBoxTransactionTotal.Name = "textBoxTransactionTotal";
            textBoxTransactionTotal.ReadOnly = true;
            textBoxTransactionTotal.Size = new Size(434, 27);
            textBoxTransactionTotal.TabIndex = 2;
            // 
            // dataGridShoppingCart
            // 
            dataGridShoppingCart.AllowUserToAddRows = false;
            dataGridShoppingCart.AllowUserToDeleteRows = false;
            dataGridShoppingCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridShoppingCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridShoppingCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridShoppingCart.Columns.AddRange(new DataGridViewColumn[] { laptop_name_transaction, laptop_price_transaction, laptop_amount_transaction, remove_item_transaction });
            dataGridShoppingCart.Location = new Point(688, 4);
            dataGridShoppingCart.MultiSelect = false;
            dataGridShoppingCart.Name = "dataGridShoppingCart";
            dataGridShoppingCart.ReadOnly = true;
            dataGridShoppingCart.RowHeadersVisible = false;
            dataGridShoppingCart.RowHeadersWidth = 51;
            dataGridShoppingCart.RowTemplate.Height = 29;
            dataGridShoppingCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridShoppingCart.Size = new Size(438, 334);
            dataGridShoppingCart.TabIndex = 1;
            dataGridShoppingCart.CellContentClick += OnDataGridShoppingCardCellContentClick;
            // 
            // laptop_name_transaction
            // 
            laptop_name_transaction.HeaderText = "Nama Laptop";
            laptop_name_transaction.MinimumWidth = 6;
            laptop_name_transaction.Name = "laptop_name_transaction";
            laptop_name_transaction.ReadOnly = true;
            laptop_name_transaction.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // laptop_price_transaction
            // 
            laptop_price_transaction.HeaderText = "Harga Laptop";
            laptop_price_transaction.MinimumWidth = 6;
            laptop_price_transaction.Name = "laptop_price_transaction";
            laptop_price_transaction.ReadOnly = true;
            laptop_price_transaction.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // laptop_amount_transaction
            // 
            laptop_amount_transaction.HeaderText = "Jumlah";
            laptop_amount_transaction.MinimumWidth = 6;
            laptop_amount_transaction.Name = "laptop_amount_transaction";
            laptop_amount_transaction.ReadOnly = true;
            laptop_amount_transaction.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // remove_item_transaction
            // 
            remove_item_transaction.HeaderText = "Aksi";
            remove_item_transaction.MinimumWidth = 6;
            remove_item_transaction.Name = "remove_item_transaction";
            remove_item_transaction.ReadOnly = true;
            remove_item_transaction.Resizable = DataGridViewTriState.True;
            remove_item_transaction.Text = "Hapus";
            remove_item_transaction.ToolTipText = "Hapus Barang dari Transaksi";
            // 
            // tabLaporan
            // 
            tabLaporan.Controls.Add(textBoxReportChange);
            tabLaporan.Controls.Add(labelReportChange);
            tabLaporan.Controls.Add(textBoxReportPay);
            tabLaporan.Controls.Add(labelReportPay);
            tabLaporan.Controls.Add(textBoxReportTotal);
            tabLaporan.Controls.Add(labelReportTotal);
            tabLaporan.Controls.Add(dataGridViewReportDetailTransaction);
            tabLaporan.Controls.Add(dataGridReportTransaction);
            tabLaporan.Location = new Point(4, 29);
            tabLaporan.Name = "tabLaporan";
            tabLaporan.Size = new Size(1130, 540);
            tabLaporan.TabIndex = 2;
            tabLaporan.Text = "Laporan";
            tabLaporan.UseVisualStyleBackColor = true;
            // 
            // textBoxReportChange
            // 
            textBoxReportChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxReportChange.Location = new Point(688, 470);
            textBoxReportChange.Name = "textBoxReportChange";
            textBoxReportChange.ReadOnly = true;
            textBoxReportChange.Size = new Size(434, 27);
            textBoxReportChange.TabIndex = 17;
            // 
            // labelReportChange
            // 
            labelReportChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelReportChange.AutoSize = true;
            labelReportChange.Location = new Point(688, 447);
            labelReportChange.Name = "labelReportChange";
            labelReportChange.Size = new Size(64, 20);
            labelReportChange.TabIndex = 16;
            labelReportChange.Text = "Kembali";
            // 
            // textBoxReportPay
            // 
            textBoxReportPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxReportPay.Location = new Point(688, 417);
            textBoxReportPay.Name = "textBoxReportPay";
            textBoxReportPay.ReadOnly = true;
            textBoxReportPay.Size = new Size(434, 27);
            textBoxReportPay.TabIndex = 15;
            // 
            // labelReportPay
            // 
            labelReportPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelReportPay.AutoSize = true;
            labelReportPay.Location = new Point(688, 394);
            labelReportPay.Name = "labelReportPay";
            labelReportPay.Size = new Size(46, 20);
            labelReportPay.TabIndex = 14;
            labelReportPay.Text = "Bayar";
            // 
            // textBoxReportTotal
            // 
            textBoxReportTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxReportTotal.Location = new Point(688, 364);
            textBoxReportTotal.Name = "textBoxReportTotal";
            textBoxReportTotal.ReadOnly = true;
            textBoxReportTotal.Size = new Size(434, 27);
            textBoxReportTotal.TabIndex = 13;
            // 
            // labelReportTotal
            // 
            labelReportTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelReportTotal.AutoSize = true;
            labelReportTotal.Location = new Point(688, 341);
            labelReportTotal.Name = "labelReportTotal";
            labelReportTotal.Size = new Size(42, 20);
            labelReportTotal.TabIndex = 12;
            labelReportTotal.Text = "Total";
            // 
            // dataGridViewReportDetailTransaction
            // 
            dataGridViewReportDetailTransaction.AllowUserToAddRows = false;
            dataGridViewReportDetailTransaction.AllowUserToDeleteRows = false;
            dataGridViewReportDetailTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewReportDetailTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReportDetailTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReportDetailTransaction.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridViewReportDetailTransaction.Location = new Point(688, 4);
            dataGridViewReportDetailTransaction.MultiSelect = false;
            dataGridViewReportDetailTransaction.Name = "dataGridViewReportDetailTransaction";
            dataGridViewReportDetailTransaction.ReadOnly = true;
            dataGridViewReportDetailTransaction.RowHeadersVisible = false;
            dataGridViewReportDetailTransaction.RowHeadersWidth = 51;
            dataGridViewReportDetailTransaction.RowTemplate.Height = 29;
            dataGridViewReportDetailTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReportDetailTransaction.Size = new Size(438, 334);
            dataGridViewReportDetailTransaction.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Nama Laptop";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Harga Laptop";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Jumlah";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridReportTransaction
            // 
            dataGridReportTransaction.AllowUserToAddRows = false;
            dataGridReportTransaction.AllowUserToDeleteRows = false;
            dataGridReportTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridReportTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReportTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReportTransaction.Columns.AddRange(new DataGridViewColumn[] { id_report_transaction, date_report_transaction });
            dataGridReportTransaction.Location = new Point(3, 3);
            dataGridReportTransaction.MultiSelect = false;
            dataGridReportTransaction.Name = "dataGridReportTransaction";
            dataGridReportTransaction.ReadOnly = true;
            dataGridReportTransaction.RowHeadersVisible = false;
            dataGridReportTransaction.RowHeadersWidth = 51;
            dataGridReportTransaction.RowTemplate.Height = 29;
            dataGridReportTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridReportTransaction.Size = new Size(679, 534);
            dataGridReportTransaction.TabIndex = 10;
            dataGridReportTransaction.SelectionChanged += OnDataGridReportTransactionSelectionChanged;
            // 
            // id_report_transaction
            // 
            id_report_transaction.HeaderText = "Id Transaksi";
            id_report_transaction.MinimumWidth = 6;
            id_report_transaction.Name = "id_report_transaction";
            id_report_transaction.ReadOnly = true;
            id_report_transaction.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // date_report_transaction
            // 
            date_report_transaction.HeaderText = "Tanggal";
            date_report_transaction.MinimumWidth = 6;
            date_report_transaction.Name = "date_report_transaction";
            date_report_transaction.ReadOnly = true;
            date_report_transaction.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // tabWeatherApi
            // 
            tabWeatherApi.Controls.Add(labelCloudinessValue);
            tabWeatherApi.Controls.Add(labelCloudiness);
            tabWeatherApi.Controls.Add(labelWindGustValue);
            tabWeatherApi.Controls.Add(labelWindGust);
            tabWeatherApi.Controls.Add(labelWindDegreeValue);
            tabWeatherApi.Controls.Add(labelWindDegree);
            tabWeatherApi.Controls.Add(labelWindSpeedValue);
            tabWeatherApi.Controls.Add(labelWindSpeed);
            tabWeatherApi.Controls.Add(labelWind);
            tabWeatherApi.Controls.Add(labelVisibilityValue);
            tabWeatherApi.Controls.Add(labelVisibility);
            tabWeatherApi.Controls.Add(labelGroundPressureValue);
            tabWeatherApi.Controls.Add(labelSeaPressureValue);
            tabWeatherApi.Controls.Add(labelGroundPressure);
            tabWeatherApi.Controls.Add(labelSeaPressure);
            tabWeatherApi.Controls.Add(labelMainPressure);
            tabWeatherApi.Controls.Add(labelHumidityValue);
            tabWeatherApi.Controls.Add(labelHumidity);
            tabWeatherApi.Controls.Add(comboBoxUnit);
            tabWeatherApi.Controls.Add(labelMainPressureValue);
            tabWeatherApi.Controls.Add(labelPressure);
            tabWeatherApi.Controls.Add(labelMaxTemperatureValue);
            tabWeatherApi.Controls.Add(labelMaxTemperature);
            tabWeatherApi.Controls.Add(labelMinimalTemperatureValue);
            tabWeatherApi.Controls.Add(labelMinimalTemperature);
            tabWeatherApi.Controls.Add(labelMainTemperatureValue);
            tabWeatherApi.Controls.Add(labelMainTemperature);
            tabWeatherApi.Controls.Add(labelTemperature);
            tabWeatherApi.Controls.Add(labelWeatherValue);
            tabWeatherApi.Controls.Add(labelWeather);
            tabWeatherApi.Controls.Add(labelLongitudeValue);
            tabWeatherApi.Controls.Add(labelLongitude);
            tabWeatherApi.Controls.Add(labelLatitudeValue);
            tabWeatherApi.Controls.Add(labelLatitude);
            tabWeatherApi.Controls.Add(labelCoordinate);
            tabWeatherApi.Controls.Add(labelResult);
            tabWeatherApi.Controls.Add(buttonSearchWeather);
            tabWeatherApi.Controls.Add(textBoxSearchWeather);
            tabWeatherApi.Controls.Add(labelCityName);
            tabWeatherApi.Location = new Point(4, 29);
            tabWeatherApi.Name = "tabWeatherApi";
            tabWeatherApi.Size = new Size(1130, 540);
            tabWeatherApi.TabIndex = 3;
            tabWeatherApi.Text = "Weather API?";
            tabWeatherApi.UseVisualStyleBackColor = true;
            // 
            // labelVisibilityValue
            // 
            labelVisibilityValue.AutoSize = true;
            labelVisibilityValue.Location = new Point(156, 333);
            labelVisibilityValue.Name = "labelVisibilityValue";
            labelVisibilityValue.Size = new Size(33, 20);
            labelVisibilityValue.TabIndex = 29;
            labelVisibilityValue.Text = "null";
            // 
            // labelVisibility
            // 
            labelVisibility.AutoSize = true;
            labelVisibility.Location = new Point(24, 333);
            labelVisibility.Name = "labelVisibility";
            labelVisibility.Size = new Size(126, 20);
            labelVisibility.TabIndex = 28;
            labelVisibility.Text = "Jarak Penglihatan:";
            // 
            // labelGroundPressureValue
            // 
            labelGroundPressureValue.AutoSize = true;
            labelGroundPressureValue.Location = new Point(153, 293);
            labelGroundPressureValue.Name = "labelGroundPressureValue";
            labelGroundPressureValue.Size = new Size(33, 20);
            labelGroundPressureValue.TabIndex = 27;
            labelGroundPressureValue.Text = "null";
            // 
            // labelSeaPressureValue
            // 
            labelSeaPressureValue.AutoSize = true;
            labelSeaPressureValue.Location = new Point(167, 273);
            labelSeaPressureValue.Name = "labelSeaPressureValue";
            labelSeaPressureValue.Size = new Size(33, 20);
            labelSeaPressureValue.TabIndex = 26;
            labelSeaPressureValue.Text = "null";
            // 
            // labelGroundPressure
            // 
            labelGroundPressure.AutoSize = true;
            labelGroundPressure.Location = new Point(40, 293);
            labelGroundPressure.Name = "labelGroundPressure";
            labelGroundPressure.Size = new Size(107, 20);
            labelGroundPressure.TabIndex = 25;
            labelGroundPressure.Text = "Tekanan Darat:";
            // 
            // labelSeaPressure
            // 
            labelSeaPressure.AutoSize = true;
            labelSeaPressure.Location = new Point(40, 273);
            labelSeaPressure.Name = "labelSeaPressure";
            labelSeaPressure.Size = new Size(121, 20);
            labelSeaPressure.TabIndex = 24;
            labelSeaPressure.Text = "Tekanan Air Laut:";
            // 
            // labelMainPressure
            // 
            labelMainPressure.AutoSize = true;
            labelMainPressure.Location = new Point(40, 253);
            labelMainPressure.Name = "labelMainPressure";
            labelMainPressure.Size = new Size(114, 20);
            labelMainPressure.TabIndex = 23;
            labelMainPressure.Text = "Tekanan Utama:";
            // 
            // labelHumidityValue
            // 
            labelHumidityValue.AutoSize = true;
            labelHumidityValue.Location = new Point(126, 313);
            labelHumidityValue.Name = "labelHumidityValue";
            labelHumidityValue.Size = new Size(33, 20);
            labelHumidityValue.TabIndex = 22;
            labelHumidityValue.Text = "null";
            // 
            // labelHumidity
            // 
            labelHumidity.AutoSize = true;
            labelHumidity.Location = new Point(24, 313);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(96, 20);
            labelHumidity.TabIndex = 21;
            labelHumidity.Text = "Kelembaban:";
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.DisplayMember = "Celcius";
            comboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Items.AddRange(new object[] { "Kelvin", "Celcius", "Fahrenheit" });
            comboBoxUnit.Location = new Point(213, 23);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(151, 28);
            comboBoxUnit.TabIndex = 20;
            // 
            // labelMainPressureValue
            // 
            labelMainPressureValue.AutoSize = true;
            labelMainPressureValue.Location = new Point(160, 253);
            labelMainPressureValue.Name = "labelMainPressureValue";
            labelMainPressureValue.Size = new Size(33, 20);
            labelMainPressureValue.TabIndex = 19;
            labelMainPressureValue.Text = "null";
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.Location = new Point(24, 233);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new Size(66, 20);
            labelPressure.TabIndex = 18;
            labelPressure.Text = "Tekanan:";
            // 
            // labelMaxTemperatureValue
            // 
            labelMaxTemperatureValue.AutoSize = true;
            labelMaxTemperatureValue.Location = new Point(157, 213);
            labelMaxTemperatureValue.Name = "labelMaxTemperatureValue";
            labelMaxTemperatureValue.Size = new Size(33, 20);
            labelMaxTemperatureValue.TabIndex = 17;
            labelMaxTemperatureValue.Text = "null";
            // 
            // labelMaxTemperature
            // 
            labelMaxTemperature.AutoSize = true;
            labelMaxTemperature.Location = new Point(40, 213);
            labelMaxTemperature.Name = "labelMaxTemperature";
            labelMaxTemperature.Size = new Size(111, 20);
            labelMaxTemperature.TabIndex = 16;
            labelMaxTemperature.Text = "Suhu Maksimal:";
            // 
            // labelMinimalTemperatureValue
            // 
            labelMinimalTemperatureValue.AutoSize = true;
            labelMinimalTemperatureValue.Location = new Point(148, 193);
            labelMinimalTemperatureValue.Name = "labelMinimalTemperatureValue";
            labelMinimalTemperatureValue.Size = new Size(33, 20);
            labelMinimalTemperatureValue.TabIndex = 15;
            labelMinimalTemperatureValue.Text = "null";
            // 
            // labelMinimalTemperature
            // 
            labelMinimalTemperature.AutoSize = true;
            labelMinimalTemperature.Location = new Point(40, 193);
            labelMinimalTemperature.Name = "labelMinimalTemperature";
            labelMinimalTemperature.Size = new Size(102, 20);
            labelMinimalTemperature.TabIndex = 14;
            labelMinimalTemperature.Text = "Suhu Minimal:";
            // 
            // labelMainTemperatureValue
            // 
            labelMainTemperatureValue.AutoSize = true;
            labelMainTemperatureValue.Location = new Point(138, 173);
            labelMainTemperatureValue.Name = "labelMainTemperatureValue";
            labelMainTemperatureValue.Size = new Size(33, 20);
            labelMainTemperatureValue.TabIndex = 13;
            labelMainTemperatureValue.Text = "null";
            // 
            // labelMainTemperature
            // 
            labelMainTemperature.AutoSize = true;
            labelMainTemperature.Location = new Point(40, 173);
            labelMainTemperature.Name = "labelMainTemperature";
            labelMainTemperature.Size = new Size(92, 20);
            labelMainTemperature.TabIndex = 12;
            labelMainTemperature.Text = "Suhu Utama:";
            // 
            // labelTemperature
            // 
            labelTemperature.AutoSize = true;
            labelTemperature.Location = new Point(24, 153);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new Size(44, 20);
            labelTemperature.TabIndex = 11;
            labelTemperature.Text = "Suhu:";
            // 
            // labelWeatherValue
            // 
            labelWeatherValue.AutoSize = true;
            labelWeatherValue.Location = new Point(82, 133);
            labelWeatherValue.Name = "labelWeatherValue";
            labelWeatherValue.Size = new Size(33, 20);
            labelWeatherValue.TabIndex = 10;
            labelWeatherValue.Text = "null";
            // 
            // labelWeather
            // 
            labelWeather.AutoSize = true;
            labelWeather.Location = new Point(24, 133);
            labelWeather.Name = "labelWeather";
            labelWeather.Size = new Size(52, 20);
            labelWeather.TabIndex = 9;
            labelWeather.Text = "Cuaca:";
            // 
            // labelLongitudeValue
            // 
            labelLongitudeValue.AutoSize = true;
            labelLongitudeValue.Location = new Point(125, 113);
            labelLongitudeValue.Name = "labelLongitudeValue";
            labelLongitudeValue.Size = new Size(33, 20);
            labelLongitudeValue.TabIndex = 8;
            labelLongitudeValue.Text = "null";
            // 
            // labelLongitude
            // 
            labelLongitude.AutoSize = true;
            labelLongitude.Location = new Point(40, 113);
            labelLongitude.Name = "labelLongitude";
            labelLongitude.Size = new Size(79, 20);
            labelLongitude.TabIndex = 7;
            labelLongitude.Text = "Longitude:";
            // 
            // labelLatitudeValue
            // 
            labelLatitudeValue.AutoSize = true;
            labelLatitudeValue.Location = new Point(109, 93);
            labelLatitudeValue.Name = "labelLatitudeValue";
            labelLatitudeValue.Size = new Size(33, 20);
            labelLatitudeValue.TabIndex = 6;
            labelLatitudeValue.Text = "null";
            // 
            // labelLatitude
            // 
            labelLatitude.AutoSize = true;
            labelLatitude.Location = new Point(40, 93);
            labelLatitude.Name = "labelLatitude";
            labelLatitude.Size = new Size(66, 20);
            labelLatitude.TabIndex = 5;
            labelLatitude.Text = "Latitude:";
            // 
            // labelCoordinate
            // 
            labelCoordinate.AutoSize = true;
            labelCoordinate.Location = new Point(24, 73);
            labelCoordinate.Name = "labelCoordinate";
            labelCoordinate.Size = new Size(78, 20);
            labelCoordinate.TabIndex = 4;
            labelCoordinate.Text = "Koordinat:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(8, 53);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(45, 20);
            labelResult.TabIndex = 3;
            labelResult.Text = "Hasil:";
            // 
            // buttonSearchWeather
            // 
            buttonSearchWeather.Location = new Point(370, 23);
            buttonSearchWeather.Name = "buttonSearchWeather";
            buttonSearchWeather.Size = new Size(94, 29);
            buttonSearchWeather.TabIndex = 2;
            buttonSearchWeather.Text = "Cari";
            buttonSearchWeather.UseVisualStyleBackColor = true;
            buttonSearchWeather.Click += OnButtonSearchWeatherClick;
            // 
            // textBoxSearchWeather
            // 
            textBoxSearchWeather.Location = new Point(8, 23);
            textBoxSearchWeather.Name = "textBoxSearchWeather";
            textBoxSearchWeather.Size = new Size(199, 27);
            textBoxSearchWeather.TabIndex = 1;
            textBoxSearchWeather.Text = "jember";
            // 
            // labelCityName
            // 
            labelCityName.AutoSize = true;
            labelCityName.Location = new Point(3, 0);
            labelCityName.Name = "labelCityName";
            labelCityName.Size = new Size(84, 20);
            labelCityName.TabIndex = 0;
            labelCityName.Text = "Nama Kota";
            // 
            // tabPengaturan
            // 
            tabPengaturan.Location = new Point(4, 29);
            tabPengaturan.Name = "tabPengaturan";
            tabPengaturan.Size = new Size(1130, 540);
            tabPengaturan.TabIndex = 4;
            tabPengaturan.Text = "Pengaturan";
            tabPengaturan.UseVisualStyleBackColor = true;
            // 
            // labelWind
            // 
            labelWind.AutoSize = true;
            labelWind.Location = new Point(24, 353);
            labelWind.Name = "labelWind";
            labelWind.Size = new Size(51, 20);
            labelWind.TabIndex = 30;
            labelWind.Text = "Angin:";
            // 
            // labelWindSpeed
            // 
            labelWindSpeed.AutoSize = true;
            labelWindSpeed.Location = new Point(40, 373);
            labelWindSpeed.Name = "labelWindSpeed";
            labelWindSpeed.Size = new Size(125, 20);
            labelWindSpeed.TabIndex = 31;
            labelWindSpeed.Text = "Kecepatan Angin:";
            // 
            // labelWindSpeedValue
            // 
            labelWindSpeedValue.AutoSize = true;
            labelWindSpeedValue.Location = new Point(171, 373);
            labelWindSpeedValue.Name = "labelWindSpeedValue";
            labelWindSpeedValue.Size = new Size(33, 20);
            labelWindSpeedValue.TabIndex = 32;
            labelWindSpeedValue.Text = "null";
            // 
            // labelWindDegree
            // 
            labelWindDegree.AutoSize = true;
            labelWindDegree.Location = new Point(40, 393);
            labelWindDegree.Name = "labelWindDegree";
            labelWindDegree.Size = new Size(86, 20);
            labelWindDegree.TabIndex = 33;
            labelWindDegree.Text = "Arah Angin:";
            // 
            // labelWindDegreeValue
            // 
            labelWindDegreeValue.AutoSize = true;
            labelWindDegreeValue.Location = new Point(132, 393);
            labelWindDegreeValue.Name = "labelWindDegreeValue";
            labelWindDegreeValue.Size = new Size(33, 20);
            labelWindDegreeValue.TabIndex = 34;
            labelWindDegreeValue.Text = "null";
            // 
            // labelWindGust
            // 
            labelWindGust.AutoSize = true;
            labelWindGust.Location = new Point(40, 413);
            labelWindGust.Name = "labelWindGust";
            labelWindGust.Size = new Size(100, 20);
            labelWindGust.TabIndex = 35;
            labelWindGust.Text = "Tiupan Angin:";
            // 
            // labelWindGustValue
            // 
            labelWindGustValue.AutoSize = true;
            labelWindGustValue.Location = new Point(146, 413);
            labelWindGustValue.Name = "labelWindGustValue";
            labelWindGustValue.Size = new Size(33, 20);
            labelWindGustValue.TabIndex = 36;
            labelWindGustValue.Text = "null";
            // 
            // labelCloudiness
            // 
            labelCloudiness.AutoSize = true;
            labelCloudiness.Location = new Point(24, 433);
            labelCloudiness.Name = "labelCloudiness";
            labelCloudiness.Size = new Size(75, 20);
            labelCloudiness.TabIndex = 37;
            labelCloudiness.Text = "Mendung:";
            // 
            // labelCloudinessValue
            // 
            labelCloudinessValue.AutoSize = true;
            labelCloudinessValue.Location = new Point(105, 433);
            labelCloudinessValue.Name = "labelCloudinessValue";
            labelCloudinessValue.Size = new Size(33, 20);
            labelCloudinessValue.TabIndex = 38;
            labelCloudinessValue.Text = "null";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1138, 573);
            Controls.Add(tabControlHome);
            Name = "Homepage";
            Text = "Logitop";
            ((System.ComponentModel.ISupportInitialize)dataGridLaptop).EndInit();
            tabControlHome.ResumeLayout(false);
            tabLaptop.ResumeLayout(false);
            tabLaptop.PerformLayout();
            tabTransaksi.ResumeLayout(false);
            tabTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLaptopTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridShoppingCart).EndInit();
            tabLaporan.ResumeLayout(false);
            tabLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReportDetailTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridReportTransaction).EndInit();
            tabWeatherApi.ResumeLayout(false);
            tabWeatherApi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridLaptop;
        private Button buttonSaveLaptop;
        private TabControl tabControlHome;
        private TabPage tabLaptop;
        private TabPage tabTransaksi;
        private Button buttonClear;
        private Button buttonDelete;
        private TextBox textBoxLaptopName;
        private Label labelLaptopName;
        private TextBox textBoxLaptopPrice;
        private Label labelLaptopPrice;
        private Label labelLaptopStock;
        private TextBox textBoxLaptopStock;
        private TabPage tabLaporan;
        private TabPage tabWeatherApi;
        private TabPage tabPengaturan;
        private DataGridView dataGridShoppingCart;
        private Button buttonTransactionPay;
        private TextBox textBoxTransactionChange;
        private TextBox textBoxTransactionPay;
        private Label labelTransactionChange;
        private Label labelPayTransaction;
        private Label labelTotalTransaction;
        private TextBox textBoxTransactionTotal;
        private DataGridView dataGridLaptopTransaction;
        private DataGridViewTextBoxColumn laptop_name;
        private DataGridViewTextBoxColumn laptop_price;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn add_to_transaction;
        private DataGridViewTextBoxColumn laptop_name_transaction;
        private DataGridViewTextBoxColumn laptop_price_transaction;
        private DataGridViewTextBoxColumn laptop_amount_transaction;
        private DataGridViewButtonColumn remove_item_transaction;
        private DataGridView dataGridViewReportDetailTransaction;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridView dataGridReportTransaction;
        private DataGridViewTextBoxColumn id_report_transaction;
        private DataGridViewTextBoxColumn date_report_transaction;
        private TextBox textBoxReportChange;
        private Label labelReportChange;
        private TextBox textBoxReportPay;
        private Label labelReportPay;
        private TextBox textBoxReportTotal;
        private Label labelReportTotal;
        private Label labelCityName;
        private Button buttonSearchWeather;
        private TextBox textBoxSearchWeather;
        private Label labelResult;
        private Label labelCoordinate;
        private Label labelLatitude;
        private Label labelLatitudeValue;
        private Label labelLongitude;
        private Label labelLongitudeValue;
        private Label labelWeather;
        private Label labelWeatherValue;
        private Label labelTemperature;
        private Label labelMainTemperature;
        private Label labelMainTemperatureValue;
        private Label labelMinimalTemperature;
        private Label labelMinimalTemperatureValue;
        private Label labelMaxTemperature;
        private Label labelMaxTemperatureValue;
        private Label labelPressure;
        private Label labelMainPressureValue;
        private ComboBox comboBoxUnit;
        private Label labelHumidity;
        private Label labelHumidityValue;
        private Label labelMainPressure;
        private Label labelGroundPressure;
        private Label labelSeaPressure;
        private Label labelSeaPressureValue;
        private Label labelGroundPressureValue;
        private Label labelVisibility;
        private Label labelVisibilityValue;
        private Label labelWind;
        private Label labelWindSpeed;
        private Label labelWindSpeedValue;
        private Label labelWindDegree;
        private Label labelWindDegreeValue;
        private Label labelWindGust;
        private Label labelWindGustValue;
        private Label labelCloudiness;
        private Label labelCloudinessValue;
    }
}