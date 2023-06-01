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
            columnLaptopLaptopName = new DataGridViewTextBoxColumn();
            columnLaptopLaptopPrice = new DataGridViewTextBoxColumn();
            columnLaptopLaptopStock = new DataGridViewTextBoxColumn();
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
            columnTransactionLaptopName = new DataGridViewTextBoxColumn();
            columnTransactionLaptopPrice = new DataGridViewTextBoxColumn();
            columnTransactionLaptopStock = new DataGridViewTextBoxColumn();
            columnTransactionAction = new DataGridViewButtonColumn();
            buttonTransactionPay = new Button();
            textBoxTransactionChange = new TextBox();
            textBoxTransactionPay = new TextBox();
            labelTransactionChange = new Label();
            labelPayTransaction = new Label();
            labelTotalTransaction = new Label();
            textBoxTransactionTotal = new TextBox();
            dataGridShoppingCart = new DataGridView();
            columnShoppingCartLaptopName = new DataGridViewTextBoxColumn();
            columnShoppingCartLaptopPrice = new DataGridViewTextBoxColumn();
            columnShoppingCartLaptopAmount = new DataGridViewTextBoxColumn();
            columnShoppingCartAction = new DataGridViewButtonColumn();
            tabLaporan = new TabPage();
            textBoxReportChange = new TextBox();
            labelReportChange = new Label();
            textBoxReportPay = new TextBox();
            labelReportPay = new Label();
            textBoxReportTotal = new TextBox();
            labelReportTotal = new Label();
            dataGridViewReportDetailTransaction = new DataGridView();
            columnReportItemTransactionLaptopName = new DataGridViewTextBoxColumn();
            columnReportItemTransactionLaptopPrice = new DataGridViewTextBoxColumn();
            columnReportItemTransactionLaptopAmount = new DataGridViewTextBoxColumn();
            dataGridReportTransaction = new DataGridView();
            columnReportIdTransaction = new DataGridViewTextBoxColumn();
            columnReportDateTransaction = new DataGridViewTextBoxColumn();
            tabWeatherApi = new TabPage();
            labelCloudinessValue = new Label();
            labelCloudiness = new Label();
            labelWindGustValue = new Label();
            labelWindGust = new Label();
            labelWindDegreeValue = new Label();
            labelWindDegree = new Label();
            labelWindSpeedValue = new Label();
            labelWindSpeed = new Label();
            labelWind = new Label();
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
            comboBoxPaperSize = new ComboBox();
            labelPaperSize = new Label();
            comboBoxPrinter = new ComboBox();
            labelPrinter = new Label();
            buttonTestPrint = new Button();
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
            tabPengaturan.SuspendLayout();
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
            dataGridLaptop.Columns.AddRange(new DataGridViewColumn[] { columnLaptopLaptopName, columnLaptopLaptopPrice, columnLaptopLaptopStock });
            dataGridLaptop.Location = new Point(4, 4);
            dataGridLaptop.Margin = new Padding(4);
            dataGridLaptop.MultiSelect = false;
            dataGridLaptop.Name = "dataGridLaptop";
            dataGridLaptop.ReadOnly = true;
            dataGridLaptop.RowHeadersVisible = false;
            dataGridLaptop.RowHeadersWidth = 51;
            dataGridLaptop.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridLaptop.RowTemplate.Height = 29;
            dataGridLaptop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridLaptop.Size = new Size(1001, 668);
            dataGridLaptop.TabIndex = 0;
            dataGridLaptop.CellDoubleClick += OnDataGridLaptopCellDoubleClick;
            // 
            // columnLaptopLaptopName
            // 
            columnLaptopLaptopName.HeaderText = "Nama Laptop";
            columnLaptopLaptopName.MinimumWidth = 6;
            columnLaptopLaptopName.Name = "columnLaptopLaptopName";
            columnLaptopLaptopName.ReadOnly = true;
            columnLaptopLaptopName.Resizable = DataGridViewTriState.True;
            columnLaptopLaptopName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnLaptopLaptopPrice
            // 
            columnLaptopLaptopPrice.HeaderText = "Harga Laptop";
            columnLaptopLaptopPrice.MinimumWidth = 6;
            columnLaptopLaptopPrice.Name = "columnLaptopLaptopPrice";
            columnLaptopLaptopPrice.ReadOnly = true;
            columnLaptopLaptopPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnLaptopLaptopStock
            // 
            columnLaptopLaptopStock.HeaderText = "Stok";
            columnLaptopLaptopStock.MinimumWidth = 6;
            columnLaptopLaptopStock.Name = "columnLaptopLaptopStock";
            columnLaptopLaptopStock.ReadOnly = true;
            columnLaptopLaptopStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonSaveLaptop
            // 
            buttonSaveLaptop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveLaptop.Location = new Point(1278, 629);
            buttonSaveLaptop.Margin = new Padding(4);
            buttonSaveLaptop.Name = "buttonSaveLaptop";
            buttonSaveLaptop.Size = new Size(125, 36);
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
            tabControlHome.Margin = new Padding(4);
            tabControlHome.Name = "tabControlHome";
            tabControlHome.SelectedIndex = 0;
            tabControlHome.Size = new Size(1422, 716);
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
            tabLaptop.Location = new Point(4, 34);
            tabLaptop.Margin = new Padding(4);
            tabLaptop.Name = "tabLaptop";
            tabLaptop.Padding = new Padding(4);
            tabLaptop.Size = new Size(1414, 678);
            tabLaptop.TabIndex = 0;
            tabLaptop.Text = "Laptop";
            tabLaptop.UseVisualStyleBackColor = true;
            // 
            // textBoxLaptopStock
            // 
            textBoxLaptopStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxLaptopStock.Location = new Point(1012, 165);
            textBoxLaptopStock.Margin = new Padding(4);
            textBoxLaptopStock.Name = "textBoxLaptopStock";
            textBoxLaptopStock.Size = new Size(389, 31);
            textBoxLaptopStock.TabIndex = 9;
            textBoxLaptopStock.Text = "0";
            textBoxLaptopStock.KeyPress += OnTextBoxLaptopStockKeyPressed;
            // 
            // labelLaptopStock
            // 
            labelLaptopStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLaptopStock.AutoSize = true;
            labelLaptopStock.Location = new Point(1012, 136);
            labelLaptopStock.Margin = new Padding(4, 0, 4, 0);
            labelLaptopStock.Name = "labelLaptopStock";
            labelLaptopStock.Size = new Size(47, 25);
            labelLaptopStock.TabIndex = 8;
            labelLaptopStock.Text = "Stok";
            // 
            // textBoxLaptopPrice
            // 
            textBoxLaptopPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxLaptopPrice.Location = new Point(1012, 99);
            textBoxLaptopPrice.Margin = new Padding(4);
            textBoxLaptopPrice.Name = "textBoxLaptopPrice";
            textBoxLaptopPrice.Size = new Size(389, 31);
            textBoxLaptopPrice.TabIndex = 7;
            textBoxLaptopPrice.KeyPress += OnTextBoxLaptopPriceKeyPressed;
            // 
            // labelLaptopPrice
            // 
            labelLaptopPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLaptopPrice.AutoSize = true;
            labelLaptopPrice.Location = new Point(1012, 70);
            labelLaptopPrice.Margin = new Padding(4, 0, 4, 0);
            labelLaptopPrice.Name = "labelLaptopPrice";
            labelLaptopPrice.Size = new Size(121, 25);
            labelLaptopPrice.TabIndex = 6;
            labelLaptopPrice.Text = "Harga Laptop";
            // 
            // labelLaptopName
            // 
            labelLaptopName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLaptopName.AutoSize = true;
            labelLaptopName.Location = new Point(1012, 4);
            labelLaptopName.Margin = new Padding(4, 0, 4, 0);
            labelLaptopName.Name = "labelLaptopName";
            labelLaptopName.Size = new Size(120, 25);
            labelLaptopName.TabIndex = 5;
            labelLaptopName.Text = "Nama Laptop";
            // 
            // textBoxLaptopName
            // 
            textBoxLaptopName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxLaptopName.Location = new Point(1012, 32);
            textBoxLaptopName.Margin = new Padding(4);
            textBoxLaptopName.Name = "textBoxLaptopName";
            textBoxLaptopName.Size = new Size(389, 31);
            textBoxLaptopName.TabIndex = 4;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClear.Location = new Point(1012, 629);
            buttonClear.Margin = new Padding(4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(125, 36);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Bersihkan";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += OnButtonClearLaptopClick;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(1145, 629);
            buttonDelete.Margin = new Padding(4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(125, 36);
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
            tabTransaksi.Location = new Point(4, 34);
            tabTransaksi.Margin = new Padding(4);
            tabTransaksi.Name = "tabTransaksi";
            tabTransaksi.Padding = new Padding(4);
            tabTransaksi.Size = new Size(1414, 678);
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
            dataGridLaptopTransaction.Columns.AddRange(new DataGridViewColumn[] { columnTransactionLaptopName, columnTransactionLaptopPrice, columnTransactionLaptopStock, columnTransactionAction });
            dataGridLaptopTransaction.Location = new Point(4, 4);
            dataGridLaptopTransaction.Margin = new Padding(4);
            dataGridLaptopTransaction.MultiSelect = false;
            dataGridLaptopTransaction.Name = "dataGridLaptopTransaction";
            dataGridLaptopTransaction.ReadOnly = true;
            dataGridLaptopTransaction.RowHeadersVisible = false;
            dataGridLaptopTransaction.RowHeadersWidth = 51;
            dataGridLaptopTransaction.RowTemplate.Height = 29;
            dataGridLaptopTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridLaptopTransaction.Size = new Size(849, 668);
            dataGridLaptopTransaction.TabIndex = 9;
            dataGridLaptopTransaction.CellContentClick += OnDataGridLaptopTransactionCellContentClick;
            // 
            // columnTransactionLaptopName
            // 
            columnTransactionLaptopName.HeaderText = "Nama Laptop";
            columnTransactionLaptopName.MinimumWidth = 6;
            columnTransactionLaptopName.Name = "columnTransactionLaptopName";
            columnTransactionLaptopName.ReadOnly = true;
            columnTransactionLaptopName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnTransactionLaptopPrice
            // 
            columnTransactionLaptopPrice.HeaderText = "Harga Laptop";
            columnTransactionLaptopPrice.MinimumWidth = 6;
            columnTransactionLaptopPrice.Name = "columnTransactionLaptopPrice";
            columnTransactionLaptopPrice.ReadOnly = true;
            columnTransactionLaptopPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnTransactionLaptopStock
            // 
            columnTransactionLaptopStock.HeaderText = "Stok";
            columnTransactionLaptopStock.MinimumWidth = 6;
            columnTransactionLaptopStock.Name = "columnTransactionLaptopStock";
            columnTransactionLaptopStock.ReadOnly = true;
            columnTransactionLaptopStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnTransactionAction
            // 
            columnTransactionAction.HeaderText = "Aksi";
            columnTransactionAction.MinimumWidth = 6;
            columnTransactionAction.Name = "columnTransactionAction";
            columnTransactionAction.ReadOnly = true;
            columnTransactionAction.Text = "Tambah";
            columnTransactionAction.ToolTipText = "Tambah Laptop ke keranjang";
            // 
            // buttonTransactionPay
            // 
            buttonTransactionPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonTransactionPay.AutoSize = true;
            buttonTransactionPay.Location = new Point(860, 621);
            buttonTransactionPay.Margin = new Padding(4);
            buttonTransactionPay.Name = "buttonTransactionPay";
            buttonTransactionPay.Size = new Size(542, 44);
            buttonTransactionPay.TabIndex = 8;
            buttonTransactionPay.Text = "Bayar";
            buttonTransactionPay.UseVisualStyleBackColor = true;
            buttonTransactionPay.Click += OnButtonTransactionPayClick;
            // 
            // textBoxTransactionChange
            // 
            textBoxTransactionChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTransactionChange.Location = new Point(860, 588);
            textBoxTransactionChange.Margin = new Padding(4);
            textBoxTransactionChange.Name = "textBoxTransactionChange";
            textBoxTransactionChange.ReadOnly = true;
            textBoxTransactionChange.Size = new Size(542, 31);
            textBoxTransactionChange.TabIndex = 7;
            // 
            // textBoxTransactionPay
            // 
            textBoxTransactionPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTransactionPay.Location = new Point(860, 521);
            textBoxTransactionPay.Margin = new Padding(4);
            textBoxTransactionPay.Name = "textBoxTransactionPay";
            textBoxTransactionPay.Size = new Size(542, 31);
            textBoxTransactionPay.TabIndex = 6;
            textBoxTransactionPay.TextChanged += OnTextBoxTransactionPayTextChanged;
            textBoxTransactionPay.KeyPress += OnTextBoxTransactionPayKeyPressed;
            // 
            // labelTransactionChange
            // 
            labelTransactionChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTransactionChange.AutoSize = true;
            labelTransactionChange.Location = new Point(860, 559);
            labelTransactionChange.Margin = new Padding(4, 0, 4, 0);
            labelTransactionChange.Name = "labelTransactionChange";
            labelTransactionChange.Size = new Size(75, 25);
            labelTransactionChange.TabIndex = 5;
            labelTransactionChange.Text = "Kembali";
            // 
            // labelPayTransaction
            // 
            labelPayTransaction.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelPayTransaction.AutoSize = true;
            labelPayTransaction.Location = new Point(860, 492);
            labelPayTransaction.Margin = new Padding(4, 0, 4, 0);
            labelPayTransaction.Name = "labelPayTransaction";
            labelPayTransaction.Size = new Size(55, 25);
            labelPayTransaction.TabIndex = 4;
            labelPayTransaction.Text = "Bayar";
            // 
            // labelTotalTransaction
            // 
            labelTotalTransaction.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotalTransaction.AutoSize = true;
            labelTotalTransaction.Location = new Point(860, 426);
            labelTotalTransaction.Margin = new Padding(4, 0, 4, 0);
            labelTotalTransaction.Name = "labelTotalTransaction";
            labelTotalTransaction.Size = new Size(49, 25);
            labelTotalTransaction.TabIndex = 3;
            labelTotalTransaction.Text = "Total";
            // 
            // textBoxTransactionTotal
            // 
            textBoxTransactionTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTransactionTotal.Location = new Point(860, 455);
            textBoxTransactionTotal.Margin = new Padding(4);
            textBoxTransactionTotal.Name = "textBoxTransactionTotal";
            textBoxTransactionTotal.ReadOnly = true;
            textBoxTransactionTotal.Size = new Size(542, 31);
            textBoxTransactionTotal.TabIndex = 2;
            // 
            // dataGridShoppingCart
            // 
            dataGridShoppingCart.AllowUserToAddRows = false;
            dataGridShoppingCart.AllowUserToDeleteRows = false;
            dataGridShoppingCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridShoppingCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridShoppingCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridShoppingCart.Columns.AddRange(new DataGridViewColumn[] { columnShoppingCartLaptopName, columnShoppingCartLaptopPrice, columnShoppingCartLaptopAmount, columnShoppingCartAction });
            dataGridShoppingCart.Location = new Point(860, 5);
            dataGridShoppingCart.Margin = new Padding(4);
            dataGridShoppingCart.MultiSelect = false;
            dataGridShoppingCart.Name = "dataGridShoppingCart";
            dataGridShoppingCart.ReadOnly = true;
            dataGridShoppingCart.RowHeadersVisible = false;
            dataGridShoppingCart.RowHeadersWidth = 51;
            dataGridShoppingCart.RowTemplate.Height = 29;
            dataGridShoppingCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridShoppingCart.Size = new Size(548, 418);
            dataGridShoppingCart.TabIndex = 1;
            dataGridShoppingCart.CellContentClick += OnDataGridShoppingCardCellContentClick;
            // 
            // columnShoppingCartLaptopName
            // 
            columnShoppingCartLaptopName.HeaderText = "Nama Laptop";
            columnShoppingCartLaptopName.MinimumWidth = 6;
            columnShoppingCartLaptopName.Name = "columnShoppingCartLaptopName";
            columnShoppingCartLaptopName.ReadOnly = true;
            columnShoppingCartLaptopName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnShoppingCartLaptopPrice
            // 
            columnShoppingCartLaptopPrice.HeaderText = "Harga Laptop";
            columnShoppingCartLaptopPrice.MinimumWidth = 6;
            columnShoppingCartLaptopPrice.Name = "columnShoppingCartLaptopPrice";
            columnShoppingCartLaptopPrice.ReadOnly = true;
            columnShoppingCartLaptopPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnShoppingCartLaptopAmount
            // 
            columnShoppingCartLaptopAmount.HeaderText = "Jumlah";
            columnShoppingCartLaptopAmount.MinimumWidth = 6;
            columnShoppingCartLaptopAmount.Name = "columnShoppingCartLaptopAmount";
            columnShoppingCartLaptopAmount.ReadOnly = true;
            columnShoppingCartLaptopAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnShoppingCartAction
            // 
            columnShoppingCartAction.HeaderText = "Aksi";
            columnShoppingCartAction.MinimumWidth = 6;
            columnShoppingCartAction.Name = "columnShoppingCartAction";
            columnShoppingCartAction.ReadOnly = true;
            columnShoppingCartAction.Resizable = DataGridViewTriState.True;
            columnShoppingCartAction.Text = "Hapus";
            columnShoppingCartAction.ToolTipText = "Hapus Barang dari Transaksi";
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
            tabLaporan.Location = new Point(4, 34);
            tabLaporan.Margin = new Padding(4);
            tabLaporan.Name = "tabLaporan";
            tabLaporan.Size = new Size(1414, 678);
            tabLaporan.TabIndex = 2;
            tabLaporan.Text = "Laporan";
            tabLaporan.UseVisualStyleBackColor = true;
            // 
            // textBoxReportChange
            // 
            textBoxReportChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxReportChange.Location = new Point(860, 588);
            textBoxReportChange.Margin = new Padding(4);
            textBoxReportChange.Name = "textBoxReportChange";
            textBoxReportChange.ReadOnly = true;
            textBoxReportChange.Size = new Size(542, 31);
            textBoxReportChange.TabIndex = 17;
            // 
            // labelReportChange
            // 
            labelReportChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelReportChange.AutoSize = true;
            labelReportChange.Location = new Point(860, 559);
            labelReportChange.Margin = new Padding(4, 0, 4, 0);
            labelReportChange.Name = "labelReportChange";
            labelReportChange.Size = new Size(75, 25);
            labelReportChange.TabIndex = 16;
            labelReportChange.Text = "Kembali";
            // 
            // textBoxReportPay
            // 
            textBoxReportPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxReportPay.Location = new Point(860, 521);
            textBoxReportPay.Margin = new Padding(4);
            textBoxReportPay.Name = "textBoxReportPay";
            textBoxReportPay.ReadOnly = true;
            textBoxReportPay.Size = new Size(542, 31);
            textBoxReportPay.TabIndex = 15;
            // 
            // labelReportPay
            // 
            labelReportPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelReportPay.AutoSize = true;
            labelReportPay.Location = new Point(860, 492);
            labelReportPay.Margin = new Padding(4, 0, 4, 0);
            labelReportPay.Name = "labelReportPay";
            labelReportPay.Size = new Size(55, 25);
            labelReportPay.TabIndex = 14;
            labelReportPay.Text = "Bayar";
            // 
            // textBoxReportTotal
            // 
            textBoxReportTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxReportTotal.Location = new Point(860, 455);
            textBoxReportTotal.Margin = new Padding(4);
            textBoxReportTotal.Name = "textBoxReportTotal";
            textBoxReportTotal.ReadOnly = true;
            textBoxReportTotal.Size = new Size(542, 31);
            textBoxReportTotal.TabIndex = 13;
            // 
            // labelReportTotal
            // 
            labelReportTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelReportTotal.AutoSize = true;
            labelReportTotal.Location = new Point(860, 426);
            labelReportTotal.Margin = new Padding(4, 0, 4, 0);
            labelReportTotal.Name = "labelReportTotal";
            labelReportTotal.Size = new Size(49, 25);
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
            dataGridViewReportDetailTransaction.Columns.AddRange(new DataGridViewColumn[] { columnReportItemTransactionLaptopName, columnReportItemTransactionLaptopPrice, columnReportItemTransactionLaptopAmount });
            dataGridViewReportDetailTransaction.Location = new Point(860, 5);
            dataGridViewReportDetailTransaction.Margin = new Padding(4);
            dataGridViewReportDetailTransaction.MultiSelect = false;
            dataGridViewReportDetailTransaction.Name = "dataGridViewReportDetailTransaction";
            dataGridViewReportDetailTransaction.ReadOnly = true;
            dataGridViewReportDetailTransaction.RowHeadersVisible = false;
            dataGridViewReportDetailTransaction.RowHeadersWidth = 51;
            dataGridViewReportDetailTransaction.RowTemplate.Height = 29;
            dataGridViewReportDetailTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReportDetailTransaction.Size = new Size(548, 418);
            dataGridViewReportDetailTransaction.TabIndex = 11;
            // 
            // columnReportItemTransactionLaptopName
            // 
            columnReportItemTransactionLaptopName.HeaderText = "Nama Laptop";
            columnReportItemTransactionLaptopName.MinimumWidth = 6;
            columnReportItemTransactionLaptopName.Name = "columnReportItemTransactionLaptopName";
            columnReportItemTransactionLaptopName.ReadOnly = true;
            columnReportItemTransactionLaptopName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnReportItemTransactionLaptopPrice
            // 
            columnReportItemTransactionLaptopPrice.HeaderText = "Harga Laptop";
            columnReportItemTransactionLaptopPrice.MinimumWidth = 6;
            columnReportItemTransactionLaptopPrice.Name = "columnReportItemTransactionLaptopPrice";
            columnReportItemTransactionLaptopPrice.ReadOnly = true;
            columnReportItemTransactionLaptopPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnReportItemTransactionLaptopAmount
            // 
            columnReportItemTransactionLaptopAmount.HeaderText = "Jumlah";
            columnReportItemTransactionLaptopAmount.MinimumWidth = 6;
            columnReportItemTransactionLaptopAmount.Name = "columnReportItemTransactionLaptopAmount";
            columnReportItemTransactionLaptopAmount.ReadOnly = true;
            columnReportItemTransactionLaptopAmount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridReportTransaction
            // 
            dataGridReportTransaction.AllowUserToAddRows = false;
            dataGridReportTransaction.AllowUserToDeleteRows = false;
            dataGridReportTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridReportTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReportTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReportTransaction.Columns.AddRange(new DataGridViewColumn[] { columnReportIdTransaction, columnReportDateTransaction });
            dataGridReportTransaction.Location = new Point(4, 4);
            dataGridReportTransaction.Margin = new Padding(4);
            dataGridReportTransaction.MultiSelect = false;
            dataGridReportTransaction.Name = "dataGridReportTransaction";
            dataGridReportTransaction.ReadOnly = true;
            dataGridReportTransaction.RowHeadersVisible = false;
            dataGridReportTransaction.RowHeadersWidth = 51;
            dataGridReportTransaction.RowTemplate.Height = 29;
            dataGridReportTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridReportTransaction.Size = new Size(849, 668);
            dataGridReportTransaction.TabIndex = 10;
            dataGridReportTransaction.SelectionChanged += OnDataGridReportTransactionSelectionChanged;
            // 
            // columnReportIdTransaction
            // 
            columnReportIdTransaction.HeaderText = "Id Transaksi";
            columnReportIdTransaction.MinimumWidth = 6;
            columnReportIdTransaction.Name = "columnReportIdTransaction";
            columnReportIdTransaction.ReadOnly = true;
            columnReportIdTransaction.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnReportDateTransaction
            // 
            columnReportDateTransaction.HeaderText = "Tanggal";
            columnReportDateTransaction.MinimumWidth = 6;
            columnReportDateTransaction.Name = "columnReportDateTransaction";
            columnReportDateTransaction.ReadOnly = true;
            columnReportDateTransaction.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            tabWeatherApi.Location = new Point(4, 34);
            tabWeatherApi.Margin = new Padding(4);
            tabWeatherApi.Name = "tabWeatherApi";
            tabWeatherApi.Size = new Size(1414, 678);
            tabWeatherApi.TabIndex = 3;
            tabWeatherApi.Text = "Weather API?";
            tabWeatherApi.UseVisualStyleBackColor = true;
            // 
            // labelCloudinessValue
            // 
            labelCloudinessValue.AutoSize = true;
            labelCloudinessValue.Location = new Point(131, 541);
            labelCloudinessValue.Margin = new Padding(4, 0, 4, 0);
            labelCloudinessValue.Name = "labelCloudinessValue";
            labelCloudinessValue.Size = new Size(40, 25);
            labelCloudinessValue.TabIndex = 38;
            labelCloudinessValue.Text = "null";
            // 
            // labelCloudiness
            // 
            labelCloudiness.AutoSize = true;
            labelCloudiness.Location = new Point(30, 541);
            labelCloudiness.Margin = new Padding(4, 0, 4, 0);
            labelCloudiness.Name = "labelCloudiness";
            labelCloudiness.Size = new Size(93, 25);
            labelCloudiness.TabIndex = 37;
            labelCloudiness.Text = "Mendung:";
            // 
            // labelWindGustValue
            // 
            labelWindGustValue.AutoSize = true;
            labelWindGustValue.Location = new Point(182, 516);
            labelWindGustValue.Margin = new Padding(4, 0, 4, 0);
            labelWindGustValue.Name = "labelWindGustValue";
            labelWindGustValue.Size = new Size(40, 25);
            labelWindGustValue.TabIndex = 36;
            labelWindGustValue.Text = "null";
            // 
            // labelWindGust
            // 
            labelWindGust.AutoSize = true;
            labelWindGust.Location = new Point(50, 516);
            labelWindGust.Margin = new Padding(4, 0, 4, 0);
            labelWindGust.Name = "labelWindGust";
            labelWindGust.Size = new Size(121, 25);
            labelWindGust.TabIndex = 35;
            labelWindGust.Text = "Tiupan Angin:";
            // 
            // labelWindDegreeValue
            // 
            labelWindDegreeValue.AutoSize = true;
            labelWindDegreeValue.Location = new Point(165, 491);
            labelWindDegreeValue.Margin = new Padding(4, 0, 4, 0);
            labelWindDegreeValue.Name = "labelWindDegreeValue";
            labelWindDegreeValue.Size = new Size(40, 25);
            labelWindDegreeValue.TabIndex = 34;
            labelWindDegreeValue.Text = "null";
            // 
            // labelWindDegree
            // 
            labelWindDegree.AutoSize = true;
            labelWindDegree.Location = new Point(50, 491);
            labelWindDegree.Margin = new Padding(4, 0, 4, 0);
            labelWindDegree.Name = "labelWindDegree";
            labelWindDegree.Size = new Size(105, 25);
            labelWindDegree.TabIndex = 33;
            labelWindDegree.Text = "Arah Angin:";
            // 
            // labelWindSpeedValue
            // 
            labelWindSpeedValue.AutoSize = true;
            labelWindSpeedValue.Location = new Point(214, 466);
            labelWindSpeedValue.Margin = new Padding(4, 0, 4, 0);
            labelWindSpeedValue.Name = "labelWindSpeedValue";
            labelWindSpeedValue.Size = new Size(40, 25);
            labelWindSpeedValue.TabIndex = 32;
            labelWindSpeedValue.Text = "null";
            // 
            // labelWindSpeed
            // 
            labelWindSpeed.AutoSize = true;
            labelWindSpeed.Location = new Point(50, 466);
            labelWindSpeed.Margin = new Padding(4, 0, 4, 0);
            labelWindSpeed.Name = "labelWindSpeed";
            labelWindSpeed.Size = new Size(149, 25);
            labelWindSpeed.TabIndex = 31;
            labelWindSpeed.Text = "Kecepatan Angin:";
            // 
            // labelWind
            // 
            labelWind.AutoSize = true;
            labelWind.Location = new Point(30, 441);
            labelWind.Margin = new Padding(4, 0, 4, 0);
            labelWind.Name = "labelWind";
            labelWind.Size = new Size(63, 25);
            labelWind.TabIndex = 30;
            labelWind.Text = "Angin:";
            // 
            // labelVisibilityValue
            // 
            labelVisibilityValue.AutoSize = true;
            labelVisibilityValue.Location = new Point(195, 416);
            labelVisibilityValue.Margin = new Padding(4, 0, 4, 0);
            labelVisibilityValue.Name = "labelVisibilityValue";
            labelVisibilityValue.Size = new Size(40, 25);
            labelVisibilityValue.TabIndex = 29;
            labelVisibilityValue.Text = "null";
            // 
            // labelVisibility
            // 
            labelVisibility.AutoSize = true;
            labelVisibility.Location = new Point(30, 416);
            labelVisibility.Margin = new Padding(4, 0, 4, 0);
            labelVisibility.Name = "labelVisibility";
            labelVisibility.Size = new Size(151, 25);
            labelVisibility.TabIndex = 28;
            labelVisibility.Text = "Jarak Penglihatan:";
            // 
            // labelGroundPressureValue
            // 
            labelGroundPressureValue.AutoSize = true;
            labelGroundPressureValue.Location = new Point(191, 366);
            labelGroundPressureValue.Margin = new Padding(4, 0, 4, 0);
            labelGroundPressureValue.Name = "labelGroundPressureValue";
            labelGroundPressureValue.Size = new Size(40, 25);
            labelGroundPressureValue.TabIndex = 27;
            labelGroundPressureValue.Text = "null";
            // 
            // labelSeaPressureValue
            // 
            labelSeaPressureValue.AutoSize = true;
            labelSeaPressureValue.Location = new Point(209, 341);
            labelSeaPressureValue.Margin = new Padding(4, 0, 4, 0);
            labelSeaPressureValue.Name = "labelSeaPressureValue";
            labelSeaPressureValue.Size = new Size(40, 25);
            labelSeaPressureValue.TabIndex = 26;
            labelSeaPressureValue.Text = "null";
            // 
            // labelGroundPressure
            // 
            labelGroundPressure.AutoSize = true;
            labelGroundPressure.Location = new Point(50, 366);
            labelGroundPressure.Margin = new Padding(4, 0, 4, 0);
            labelGroundPressure.Name = "labelGroundPressure";
            labelGroundPressure.Size = new Size(127, 25);
            labelGroundPressure.TabIndex = 25;
            labelGroundPressure.Text = "Tekanan Darat:";
            // 
            // labelSeaPressure
            // 
            labelSeaPressure.AutoSize = true;
            labelSeaPressure.Location = new Point(50, 341);
            labelSeaPressure.Margin = new Padding(4, 0, 4, 0);
            labelSeaPressure.Name = "labelSeaPressure";
            labelSeaPressure.Size = new Size(144, 25);
            labelSeaPressure.TabIndex = 24;
            labelSeaPressure.Text = "Tekanan Air Laut:";
            // 
            // labelMainPressure
            // 
            labelMainPressure.AutoSize = true;
            labelMainPressure.Location = new Point(50, 316);
            labelMainPressure.Margin = new Padding(4, 0, 4, 0);
            labelMainPressure.Name = "labelMainPressure";
            labelMainPressure.Size = new Size(136, 25);
            labelMainPressure.TabIndex = 23;
            labelMainPressure.Text = "Tekanan Utama:";
            // 
            // labelHumidityValue
            // 
            labelHumidityValue.AutoSize = true;
            labelHumidityValue.Location = new Point(158, 391);
            labelHumidityValue.Margin = new Padding(4, 0, 4, 0);
            labelHumidityValue.Name = "labelHumidityValue";
            labelHumidityValue.Size = new Size(40, 25);
            labelHumidityValue.TabIndex = 22;
            labelHumidityValue.Text = "null";
            // 
            // labelHumidity
            // 
            labelHumidity.AutoSize = true;
            labelHumidity.Location = new Point(30, 391);
            labelHumidity.Margin = new Padding(4, 0, 4, 0);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(114, 25);
            labelHumidity.TabIndex = 21;
            labelHumidity.Text = "Kelembaban:";
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.DisplayMember = "Celcius";
            comboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Items.AddRange(new object[] { "Kelvin", "Celcius", "Fahrenheit" });
            comboBoxUnit.Location = new Point(266, 29);
            comboBoxUnit.Margin = new Padding(4);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(188, 33);
            comboBoxUnit.TabIndex = 20;
            // 
            // labelMainPressureValue
            // 
            labelMainPressureValue.AutoSize = true;
            labelMainPressureValue.Location = new Point(200, 316);
            labelMainPressureValue.Margin = new Padding(4, 0, 4, 0);
            labelMainPressureValue.Name = "labelMainPressureValue";
            labelMainPressureValue.Size = new Size(40, 25);
            labelMainPressureValue.TabIndex = 19;
            labelMainPressureValue.Text = "null";
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.Location = new Point(30, 291);
            labelPressure.Margin = new Padding(4, 0, 4, 0);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new Size(79, 25);
            labelPressure.TabIndex = 18;
            labelPressure.Text = "Tekanan:";
            // 
            // labelMaxTemperatureValue
            // 
            labelMaxTemperatureValue.AutoSize = true;
            labelMaxTemperatureValue.Location = new Point(196, 266);
            labelMaxTemperatureValue.Margin = new Padding(4, 0, 4, 0);
            labelMaxTemperatureValue.Name = "labelMaxTemperatureValue";
            labelMaxTemperatureValue.Size = new Size(40, 25);
            labelMaxTemperatureValue.TabIndex = 17;
            labelMaxTemperatureValue.Text = "null";
            // 
            // labelMaxTemperature
            // 
            labelMaxTemperature.AutoSize = true;
            labelMaxTemperature.Location = new Point(50, 266);
            labelMaxTemperature.Margin = new Padding(4, 0, 4, 0);
            labelMaxTemperature.Name = "labelMaxTemperature";
            labelMaxTemperature.Size = new Size(136, 25);
            labelMaxTemperature.TabIndex = 16;
            labelMaxTemperature.Text = "Suhu Maksimal:";
            // 
            // labelMinimalTemperatureValue
            // 
            labelMinimalTemperatureValue.AutoSize = true;
            labelMinimalTemperatureValue.Location = new Point(185, 241);
            labelMinimalTemperatureValue.Margin = new Padding(4, 0, 4, 0);
            labelMinimalTemperatureValue.Name = "labelMinimalTemperatureValue";
            labelMinimalTemperatureValue.Size = new Size(40, 25);
            labelMinimalTemperatureValue.TabIndex = 15;
            labelMinimalTemperatureValue.Text = "null";
            // 
            // labelMinimalTemperature
            // 
            labelMinimalTemperature.AutoSize = true;
            labelMinimalTemperature.Location = new Point(50, 241);
            labelMinimalTemperature.Margin = new Padding(4, 0, 4, 0);
            labelMinimalTemperature.Name = "labelMinimalTemperature";
            labelMinimalTemperature.Size = new Size(124, 25);
            labelMinimalTemperature.TabIndex = 14;
            labelMinimalTemperature.Text = "Suhu Minimal:";
            // 
            // labelMainTemperatureValue
            // 
            labelMainTemperatureValue.AutoSize = true;
            labelMainTemperatureValue.Location = new Point(172, 216);
            labelMainTemperatureValue.Margin = new Padding(4, 0, 4, 0);
            labelMainTemperatureValue.Name = "labelMainTemperatureValue";
            labelMainTemperatureValue.Size = new Size(40, 25);
            labelMainTemperatureValue.TabIndex = 13;
            labelMainTemperatureValue.Text = "null";
            // 
            // labelMainTemperature
            // 
            labelMainTemperature.AutoSize = true;
            labelMainTemperature.Location = new Point(50, 216);
            labelMainTemperature.Margin = new Padding(4, 0, 4, 0);
            labelMainTemperature.Name = "labelMainTemperature";
            labelMainTemperature.Size = new Size(113, 25);
            labelMainTemperature.TabIndex = 12;
            labelMainTemperature.Text = "Suhu Utama:";
            // 
            // labelTemperature
            // 
            labelTemperature.AutoSize = true;
            labelTemperature.Location = new Point(30, 191);
            labelTemperature.Margin = new Padding(4, 0, 4, 0);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new Size(56, 25);
            labelTemperature.TabIndex = 11;
            labelTemperature.Text = "Suhu:";
            // 
            // labelWeatherValue
            // 
            labelWeatherValue.AutoSize = true;
            labelWeatherValue.Location = new Point(102, 166);
            labelWeatherValue.Margin = new Padding(4, 0, 4, 0);
            labelWeatherValue.Name = "labelWeatherValue";
            labelWeatherValue.Size = new Size(40, 25);
            labelWeatherValue.TabIndex = 10;
            labelWeatherValue.Text = "null";
            // 
            // labelWeather
            // 
            labelWeather.AutoSize = true;
            labelWeather.Location = new Point(30, 166);
            labelWeather.Margin = new Padding(4, 0, 4, 0);
            labelWeather.Name = "labelWeather";
            labelWeather.Size = new Size(63, 25);
            labelWeather.TabIndex = 9;
            labelWeather.Text = "Cuaca:";
            // 
            // labelLongitudeValue
            // 
            labelLongitudeValue.AutoSize = true;
            labelLongitudeValue.Location = new Point(156, 141);
            labelLongitudeValue.Margin = new Padding(4, 0, 4, 0);
            labelLongitudeValue.Name = "labelLongitudeValue";
            labelLongitudeValue.Size = new Size(40, 25);
            labelLongitudeValue.TabIndex = 8;
            labelLongitudeValue.Text = "null";
            // 
            // labelLongitude
            // 
            labelLongitude.AutoSize = true;
            labelLongitude.Location = new Point(50, 141);
            labelLongitude.Margin = new Padding(4, 0, 4, 0);
            labelLongitude.Name = "labelLongitude";
            labelLongitude.Size = new Size(96, 25);
            labelLongitude.TabIndex = 7;
            labelLongitude.Text = "Longitude:";
            // 
            // labelLatitudeValue
            // 
            labelLatitudeValue.AutoSize = true;
            labelLatitudeValue.Location = new Point(136, 116);
            labelLatitudeValue.Margin = new Padding(4, 0, 4, 0);
            labelLatitudeValue.Name = "labelLatitudeValue";
            labelLatitudeValue.Size = new Size(40, 25);
            labelLatitudeValue.TabIndex = 6;
            labelLatitudeValue.Text = "null";
            // 
            // labelLatitude
            // 
            labelLatitude.AutoSize = true;
            labelLatitude.Location = new Point(50, 116);
            labelLatitude.Margin = new Padding(4, 0, 4, 0);
            labelLatitude.Name = "labelLatitude";
            labelLatitude.Size = new Size(79, 25);
            labelLatitude.TabIndex = 5;
            labelLatitude.Text = "Latitude:";
            // 
            // labelCoordinate
            // 
            labelCoordinate.AutoSize = true;
            labelCoordinate.Location = new Point(30, 91);
            labelCoordinate.Margin = new Padding(4, 0, 4, 0);
            labelCoordinate.Name = "labelCoordinate";
            labelCoordinate.Size = new Size(94, 25);
            labelCoordinate.TabIndex = 4;
            labelCoordinate.Text = "Koordinat:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(10, 66);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(54, 25);
            labelResult.TabIndex = 3;
            labelResult.Text = "Hasil:";
            // 
            // buttonSearchWeather
            // 
            buttonSearchWeather.Location = new Point(462, 29);
            buttonSearchWeather.Margin = new Padding(4);
            buttonSearchWeather.Name = "buttonSearchWeather";
            buttonSearchWeather.Size = new Size(118, 36);
            buttonSearchWeather.TabIndex = 2;
            buttonSearchWeather.Text = "Cari";
            buttonSearchWeather.UseVisualStyleBackColor = true;
            buttonSearchWeather.Click += OnButtonSearchWeatherClick;
            // 
            // textBoxSearchWeather
            // 
            textBoxSearchWeather.Location = new Point(10, 29);
            textBoxSearchWeather.Margin = new Padding(4);
            textBoxSearchWeather.Name = "textBoxSearchWeather";
            textBoxSearchWeather.Size = new Size(248, 31);
            textBoxSearchWeather.TabIndex = 1;
            textBoxSearchWeather.Text = "jember";
            // 
            // labelCityName
            // 
            labelCityName.AutoSize = true;
            labelCityName.Location = new Point(4, 0);
            labelCityName.Margin = new Padding(4, 0, 4, 0);
            labelCityName.Name = "labelCityName";
            labelCityName.Size = new Size(100, 25);
            labelCityName.TabIndex = 0;
            labelCityName.Text = "Nama Kota";
            // 
            // tabPengaturan
            // 
            tabPengaturan.Controls.Add(buttonTestPrint);
            tabPengaturan.Controls.Add(comboBoxPaperSize);
            tabPengaturan.Controls.Add(labelPaperSize);
            tabPengaturan.Controls.Add(comboBoxPrinter);
            tabPengaturan.Controls.Add(labelPrinter);
            tabPengaturan.Location = new Point(4, 34);
            tabPengaturan.Margin = new Padding(4);
            tabPengaturan.Name = "tabPengaturan";
            tabPengaturan.Size = new Size(1414, 678);
            tabPengaturan.TabIndex = 4;
            tabPengaturan.Text = "Pengaturan";
            tabPengaturan.UseVisualStyleBackColor = true;
            // 
            // comboBoxPaperSize
            // 
            comboBoxPaperSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaperSize.FormattingEnabled = true;
            comboBoxPaperSize.Location = new Point(8, 92);
            comboBoxPaperSize.Name = "comboBoxPaperSize";
            comboBoxPaperSize.Size = new Size(341, 33);
            comboBoxPaperSize.TabIndex = 3;
            comboBoxPaperSize.SelectedIndexChanged += OnComboBoxPaperSizeSelectedIndexChanged;
            // 
            // labelPaperSize
            // 
            labelPaperSize.AutoSize = true;
            labelPaperSize.Location = new Point(8, 64);
            labelPaperSize.Name = "labelPaperSize";
            labelPaperSize.Size = new Size(121, 25);
            labelPaperSize.TabIndex = 2;
            labelPaperSize.Text = "Ukuran Kertas";
            // 
            // comboBoxPrinter
            // 
            comboBoxPrinter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrinter.FormattingEnabled = true;
            comboBoxPrinter.Location = new Point(8, 28);
            comboBoxPrinter.Name = "comboBoxPrinter";
            comboBoxPrinter.Size = new Size(341, 33);
            comboBoxPrinter.TabIndex = 1;
            comboBoxPrinter.SelectedIndexChanged += OnComboBoxPrinterSelectedIndexChanged;
            // 
            // labelPrinter
            // 
            labelPrinter.AutoSize = true;
            labelPrinter.Location = new Point(8, 0);
            labelPrinter.Name = "labelPrinter";
            labelPrinter.Size = new Size(63, 25);
            labelPrinter.TabIndex = 0;
            labelPrinter.Text = "Printer";
            // 
            // buttonTestPrint
            // 
            buttonTestPrint.Location = new Point(8, 131);
            buttonTestPrint.Name = "buttonTestPrint";
            buttonTestPrint.Size = new Size(112, 34);
            buttonTestPrint.TabIndex = 4;
            buttonTestPrint.Text = "Test Print";
            buttonTestPrint.UseVisualStyleBackColor = true;
            buttonTestPrint.Click += OnButtonTestPrintClick;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1422, 716);
            Controls.Add(tabControlHome);
            Margin = new Padding(4);
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
            tabPengaturan.ResumeLayout(false);
            tabPengaturan.PerformLayout();
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
        private DataGridView dataGridViewReportDetailTransaction;
        private DataGridView dataGridReportTransaction;
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
        private ComboBox comboBoxPrinter;
        private Label labelPrinter;
        private Label labelPaperSize;
        private ComboBox comboBoxPaperSize;
        private DataGridViewTextBoxColumn columnLaptopLaptopName;
        private DataGridViewTextBoxColumn columnLaptopLaptopPrice;
        private DataGridViewTextBoxColumn columnLaptopLaptopStock;
        private DataGridViewTextBoxColumn columnShoppingCartLaptopName;
        private DataGridViewTextBoxColumn columnShoppingCartLaptopPrice;
        private DataGridViewTextBoxColumn columnShoppingCartLaptopAmount;
        private DataGridViewButtonColumn columnShoppingCartAction;
        private DataGridViewTextBoxColumn columnTransactionLaptopName;
        private DataGridViewTextBoxColumn columnTransactionLaptopPrice;
        private DataGridViewTextBoxColumn columnTransactionLaptopStock;
        private DataGridViewButtonColumn columnTransactionAction;
        private DataGridViewTextBoxColumn columnReportItemTransactionLaptopName;
        private DataGridViewTextBoxColumn columnReportItemTransactionLaptopPrice;
        private DataGridViewTextBoxColumn columnReportItemTransactionLaptopAmount;
        private DataGridViewTextBoxColumn columnReportIdTransaction;
        private DataGridViewTextBoxColumn columnReportDateTransaction;
        private Button buttonTestPrint;
    }
}