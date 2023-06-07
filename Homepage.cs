using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using Logitop.Models;
using Logitop.Services;
using Logitop.Utils;
using System.Collections.ObjectModel;
using System.Data;
using System.Text.Json;

namespace Logitop
{
    public partial class Homepage : Form
    {
        private int? CurrentIdLaptop;

        private List<Laptop> Laptops = new List<Laptop>();
        private Dictionary<int, int> CurrentShoppingCarts = new Dictionary<int, int>() { };

        private List<Transaction> Transactions = new List<Transaction>();
        private List<DetailTransaction> DetailTransactions = new List<DetailTransaction>();

        public Homepage()
        {
            InitializeComponent();
            comboBoxUnit.Text = "Celcius";
            ReadLaptopData();
            SetLaptopState();
            ReadTransactionData();
            SetTransactionState();
            RequestWeatherApi(null);

            comboBoxPrinter.Items.Clear();
            foreach (string printer in Printing.GetAvailablePrinters())
            {
                comboBoxPrinter.Items.Add(printer);
            }
            comboBoxPrinter.Text = Printing.GetCurrentPrinter();

            comboBoxPaperSize.Items.Clear();
            foreach (string paperSize in Printing.GetAvailablePaperSizes())
            {
                comboBoxPaperSize.Items.Add(paperSize);
            }
            comboBoxPaperSize.Text = Printing.GetCurrentPaperSize();

            cartesianChart1.Series = new ISeries[]
            {
                new ColumnSeries<DateTimePoint>
                {
                    Name = "Mary",
                    Values = new ObservableCollection<DateTimePoint>
                    {
                        new DateTimePoint(new DateTime(2021, 1, 1), 3),
                        // notice we are missing the day new DateTime(2021, 1, 2)
                        new DateTimePoint(new DateTime(2021, 1, 2), 6),
                        new DateTimePoint(new DateTime(2021, 1, 2), 5),
                    },
                }
            };

            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = value => new DateTime((long) value).ToString("MMMM dd"),
                    LabelsRotation = 80,

                    // when using a date time type, let the library know your unit 
                    UnitWidth = TimeSpan.FromDays(1).Ticks, 

                    // if the difference between our points is in hours then we would:
                    // UnitWidth = TimeSpan.FromHours(1).Ticks,

                    // since all the months and years have a different number of days
                    // we can use the average, it would not cause any visible error in the user interface
                    // Months: TimeSpan.FromDays(30.4375).Ticks
                    // Years: TimeSpan.FromDays(365.25).Ticks

                    // The MinStep property forces the separator to be greater than 1 day.
                    MinStep = TimeSpan.FromDays(1).Ticks
                }
            };
        }

        private void ReadLaptopData()
        {
            Laptops.Clear();

            DataTable laptops = DbHelper.GetInstance().ExecuteQuery($"SELECT * FROM {Global.TableLaptop} WHERE {Global.ColumnLaptopIsDeleted} = false ORDER BY {Global.ColumnLaptopId}");
            foreach (DataRow dr in laptops.Rows)
            {
                Laptop laptop = Laptop.FromDataRow(dr);
                Laptops.Add(laptop);
            }
        }

        private void ReadTransactionData()
        {
            Transactions.Clear();
            DetailTransactions.Clear();

            DataTable transactions = DbHelper.GetInstance().Read(Global.TableTransaction, Global.ColumnTransactionId);
            foreach (DataRow dr in transactions.Rows)
            {
                Transaction transaction = Transaction.FromDataRow(dr);
                Transactions.Add(transaction);
            }

            DataTable detailTransactions = DbHelper.GetInstance().ExecuteQuery($"SELECT * FROM public.{Global.TableDetailTransaction} JOIN {Global.TableTransaction} ON {Global.TableDetailTransaction}.{Global.ColumnDetailTransactionTransactionId} = {Global.TableTransaction}.{Global.ColumnTransactionId} JOIN {Global.TableLaptop} ON {Global.TableDetailTransaction}.{Global.ColumnDetailTransactionLaptopId} = {Global.TableLaptop}.{Global.ColumnLaptopId} ORDER BY {Global.ColumnDetailTransactionId}");
            foreach (DataRow dr in detailTransactions.Rows)
            {
                DetailTransaction detailTransaction = DetailTransaction.FromDataRow(dr);
                DetailTransactions.Add(detailTransaction);
            }
        }

        private void SetLaptopState()
        {
            dataGridLaptop.Rows.Clear();
            dataGridLaptopTransaction.Rows.Clear();

            foreach (Laptop laptop in Laptops)
            {
                dataGridLaptop.Rows.Add(new object[] { laptop.Name, laptop.Price, laptop.Stock });
                dataGridLaptopTransaction.Rows.Add(new object[] { laptop.Name, laptop.Price, laptop.Stock, "Tambah" });
            }
        }
        private void SetShoppingCartState()
        {
            dataGridShoppingCart.Rows.Clear();
            foreach (int idLaptop in CurrentShoppingCarts.Keys)
            {
                Laptop theLaptop = Laptops.Where((e) => e.Id == idLaptop).Single();
                dataGridShoppingCart.Rows.Add(new object[] { theLaptop.Name, theLaptop.Price, CurrentShoppingCarts[idLaptop], "Kurangi" });
            }
        }

        private void SetTotalState()
        {
            int total = 0;

            foreach (int idLaptop in CurrentShoppingCarts.Keys)
            {
                Laptop theLaptop = Laptops.Where((e) => e.Id == idLaptop).Single();
                total += theLaptop.Price * CurrentShoppingCarts[idLaptop];
            }
            textBoxTransactionTotal.Text = total.ToString();
        }

        private void SetTransactionChangeState()
        {
            int total = 0;
            int pay = 0;

            try
            {
                total = int.Parse(textBoxTransactionTotal.Text.Trim());
            }
            catch
            {
                // Ignored, really
            }

            try
            {
                pay = int.Parse(textBoxTransactionPay.Text.Trim());
            }
            catch
            {
                // Ignored, really
            }

            textBoxTransactionChange.Text = (pay - total).ToString();
        }

        private void SetTransactionState()
        {
            dataGridReportTransaction.Rows.Clear();
            foreach (Transaction transaction in Transactions)
            {
                dataGridReportTransaction.Rows.Add(new object[] { transaction.Id, transaction.GetFormattedDate(withDayOfWeek: true, withMonthName: true) });
            }
        }

        private void ClearCurrentLaptopEditing()
        {
            textBoxLaptopName.Text = "";
            textBoxLaptopPrice.Text = "";
            textBoxLaptopStock.Text = "0";
            CurrentIdLaptop = null;
            buttonDelete.Enabled = false;
        }

        private void ClearShoppingCarts()
        {
            CurrentShoppingCarts.Clear();
            dataGridShoppingCart.Rows.Clear();
        }

        private string TranslateWeatherSpeed()
        {
            switch (comboBoxUnit.Text)
            {
                case "Fahrenheit":
                    return "mil/detik";
                default:
                    return "meter/detik";
            }
        }

        private async void RequestWeatherApi(string? unit)
        {
            Dictionary<string, dynamic>? weatherData = await WeatherAPI.CurrentWeatherData(textBoxSearchWeather.Text, unit);

            if (weatherData == null)
            {
                return;
            }

            labelLatitudeValue.Text = weatherData["coord"]["lat"].ToString();
            labelLongitudeValue.Text = weatherData["coord"]["lon"].ToString();

            labelWeatherValue.Text = $"{weatherData["weather"][0]["main"]}, {weatherData["weather"][0]["description"]}";

            labelMainTemperatureValue.Text = $"{weatherData["main"]["temp"]}°{comboBoxUnit.Text}";
            labelMinimalTemperatureValue.Text = $"{weatherData["main"]["temp_min"]}°{comboBoxUnit.Text}";
            labelMaxTemperatureValue.Text = $"{weatherData["main"]["temp_max"]}°{comboBoxUnit.Text}";

            labelMainPressureValue.Text = $"{weatherData["main"]["pressure"]} hPa";
            labelSeaPressureValue.Text = $"{weatherData["main"]["sea_level"]} hPa";
            labelGroundPressureValue.Text = $"{weatherData["main"]["grnd_level"]} hPa";

            labelHumidityValue.Text = $"{weatherData["main"]["humidity"]} %";

            labelVisibilityValue.Text = $"{weatherData["visibility"]} meter";

            labelWindSpeedValue.Text = $"{weatherData["wind"]["speed"]} {TranslateWeatherSpeed()}";
            labelWindDegreeValue.Text = $"{weatherData["wind"]["deg"]}°";
            labelWindGustValue.Text = $"{weatherData["wind"]["gust"]} {TranslateWeatherSpeed()}";

            labelCloudinessValue.Text = $"{weatherData["clouds"]["all"]} %";
        }

        private void OnTextBoxLaptopPriceKeyPressed(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void OnTextBoxLaptopStockKeyPressed(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void OnButtonClearLaptopClick(object sender, EventArgs e) => ClearCurrentLaptopEditing();

        private void OnButtonDeleteLaptopClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus {Laptops.Where((e) => e.Id == CurrentIdLaptop).Single().Name}?", "Konfirmasi penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            int affectedRows = DbHelper.GetInstance().ExecuteNonQuery($"UPDATE {Global.TableLaptop} SET {Global.ColumnLaptopIsDeleted} = true WHERE {Global.ColumnLaptopId} = {CurrentIdLaptop}");

            if (affectedRows > 0)
            {
                ReadLaptopData();
                SetLaptopState();
                ClearCurrentLaptopEditing();
                return;
            }
            MessageBox.Show("Gagal pada saat menghapus laptop!", "Data gagal dihapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnButtonSaveLaptopClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLaptopName.Text.Trim()))
            {
                MessageBox.Show("Nama Laptop masih kosong!", "Gagal menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxLaptopPrice.Text.Trim()))
            {
                MessageBox.Show("Harga Laptop masih kosong!", "Gagal menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxLaptopStock.Text.Trim()))
            {
                MessageBox.Show("Stok Laptop masih kosong!", "Gagal menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = textBoxLaptopName.Text.Trim();
            int price = int.Parse(textBoxLaptopPrice.Text.Trim());
            int stock = int.Parse(textBoxLaptopStock.Text.Trim());

            int affectedRows;
            if (CurrentIdLaptop == null)
            {
                affectedRows = DbHelper.GetInstance().Create(Global.TableLaptop, new Laptop(0, name, price, stock).ToJson());
            }
            else
            {
                affectedRows = DbHelper.GetInstance().Update(Global.TableLaptop, new Laptop(0, name, price, stock).ToJson(), Global.ColumnLaptopId, CurrentIdLaptop!);
            }

            if (affectedRows > 0)
            {
                ReadLaptopData();
                SetLaptopState();
                ClearCurrentLaptopEditing();
                return;
            }
            MessageBox.Show($"Laptop {name} gagal {(CurrentIdLaptop != null ? "diubah" : "ditambahkan")}!", $"Gagal {(CurrentIdLaptop != null ? "mengubah" : "menambahkan")} data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnDataGridLaptopCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridLaptop.SelectedCells.Count > 0)
            {
                Laptop laptop = Laptops[e.RowIndex];
                CurrentIdLaptop = laptop.Id;

                textBoxLaptopName.Text = laptop.Name;
                textBoxLaptopPrice.Text = laptop.Price.ToString();
                textBoxLaptopStock.Text = laptop.Stock.ToString();

                buttonDelete.Enabled = true;
            }
        }

        private void OnDataGridLaptopTransactionCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Laptop laptop = Laptops[e.RowIndex];

                if (laptop.Stock <= 0)
                {
                    MessageBox.Show("Stok kurang dari atau sama dengan 0!", "Gagal menambahkan laptop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (CurrentShoppingCarts.ContainsKey(laptop.Id))
                {
                    CurrentShoppingCarts[laptop.Id] += 1;
                    laptop.Stock -= 1;
                }
                else
                {
                    CurrentShoppingCarts[laptop.Id] = 1;
                    laptop.Stock -= 1;
                }

                SetShoppingCartState();
                SetLaptopState();
                SetTotalState();
                SetTransactionChangeState();
            }
        }

        private void OnDataGridShoppingCardCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Laptop laptop = Laptops[e.RowIndex];

                if (CurrentShoppingCarts[laptop.Id] - 1 <= 0)
                {
                    CurrentShoppingCarts.Remove(laptop.Id);
                    laptop.Stock += 1;
                }
                else
                {
                    CurrentShoppingCarts[laptop.Id] -= 1;
                    laptop.Stock += 1;
                }

                SetShoppingCartState();
                SetLaptopState();
                SetTotalState();
                SetTransactionChangeState();
            }
        }

        private void OnTextBoxTransactionPayKeyPressed(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void OnTextBoxTransactionPayTextChanged(object sender, EventArgs e) => SetTransactionChangeState();

        private void OnButtonTransactionPayClick(object sender, EventArgs e)
        {
            int change = int.Parse(textBoxTransactionChange.Text);

            if (change < 0)
            {
                MessageBox.Show($"Uang kurang {Math.Abs(change)}!", "Gagal membayar transaksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Transaction newTransaction = new Transaction(0, DateTime.Now, int.Parse(textBoxTransactionPay.Text.Trim()));
            int affectedTransactionRows = DbHelper.GetInstance().Create(Global.TableTransaction, newTransaction.ToJson());
            if (affectedTransactionRows < 1)
            {
                MessageBox.Show("Gagal pada saat membuat transaksi!", "Gagal membayar transaksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable transactionTables = DbHelper.GetInstance().Read(Global.TableTransaction, Global.ColumnTransactionId);
            newTransaction.Id = (int)transactionTables.Rows[transactionTables.Rows.Count - 1][Global.ColumnTransactionId];

            List<DetailTransaction> detailTransactions = new List<DetailTransaction>();

            foreach (int idLaptop in CurrentShoppingCarts.Keys)
            {
                Laptop theLaptop = Laptops.Where((e) => e.Id == idLaptop).Single();
                DetailTransaction newDetailTransaction = new DetailTransaction(0, newTransaction, theLaptop, CurrentShoppingCarts[idLaptop]);
                detailTransactions.Add(newDetailTransaction);

                DbHelper.GetInstance().Create(Global.TableDetailTransaction, newDetailTransaction.ToJson());
                DbHelper.GetInstance().Update(Global.TableLaptop, theLaptop.ToJson(), Global.ColumnLaptopId, theLaptop.Id);
            }

            Printing.Print(new PrintingArgumentsTransaction(newTransaction, detailTransactions));

            ClearShoppingCarts();
            ReadLaptopData();
            SetLaptopState();
            SetTotalState();
            SetTransactionChangeState();
            textBoxTransactionPay.Clear();
            ReadTransactionData();
            SetTransactionState();
        }

        private void OnDataGridReportTransactionSelectionChanged(object sender, EventArgs e)
        {
            int selectedIdTransaction = Convert.ToInt32(dataGridReportTransaction.SelectedRows[0].Cells[0].Value);

            Transaction transaction = Transactions.Where((e) => e.Id == selectedIdTransaction).Single();

            List<DetailTransaction> detailTransactions = DetailTransactions.Where((e) => e.Transaction.Id == selectedIdTransaction).ToList();

            dataGridViewReportDetailTransaction.Rows.Clear();

            int total = 0;
            foreach (DetailTransaction detailTransaction in detailTransactions)
            {
                dataGridViewReportDetailTransaction.Rows.Add(new object[] { detailTransaction.Laptop.Name, detailTransaction.Laptop.Price, detailTransaction.Amount });
                total += detailTransaction.Laptop.Price * detailTransaction.Amount;
            }

            textBoxReportTotal.Text = total.ToString();
            textBoxReportPay.Text = transaction.pay.ToString();
            textBoxReportChange.Text = (transaction.pay - total).ToString();
        }

        private void OnButtonSearchWeatherClick(object sender, EventArgs e) => RequestWeatherApi(comboBoxUnit.Text);

        private void OnComboBoxPrinterSelectedIndexChanged(object sender, EventArgs e) => Printing.SetCurrentPrinter(comboBoxPrinter.Text);

        private void OnComboBoxPaperSizeSelectedIndexChanged(object sender, EventArgs e) => Printing.SetCurrentPaperSize(comboBoxPaperSize.Text);

        private void OnButtonTestPrintClick(object sender, EventArgs e) => Printing.Print(new PrintingArgumentsMessage("Hello World"));

        private void OnButtonExportReportClick(object sender, EventArgs e)
        {
            DialogResult result = saveReportDialogAs.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            string filePath = saveReportDialogAs.FileName;
            string fileExtension = Path.GetExtension(filePath);

            if (fileExtension == ".xlsx")
            {
                ExportHelper.ExportReportToExcel(filePath, Transactions, DetailTransactions);
            }
            else if (fileExtension == ".pdf")
            {
                ExportHelper.ExportReportToPdf(filePath, Transactions, DetailTransactions);
            }
        }
    }
}