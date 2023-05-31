using Logitop.Models;
using Logitop.Services;
using Logitop.Utils;
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

        private Dictionary<string, dynamic> weatherData = new Dictionary<string, dynamic>();

        public Homepage()
        {
            InitializeComponent();
            comboBoxUnit.Text = "Celcius";
            ReadLaptopData();
            SetLaptopState();
            ReadTransactionData();
            SetTransactionState();
            RequestWeatherApi(null);
        }

        private void ReadLaptopData()
        {
            Laptops.Clear();

            DataTable laptops = DbHelper.GetInstance().Read(Global.TableLaptop, Global.ColumnLaptopId);
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
                dataGridReportTransaction.Rows.Add(new object[] { transaction.Id, transaction.Date });

            }
        }

        private void ClearCurrentLaptopEditing()
        {
            textBoxLaptopName.Text = "";
            textBoxLaptopPrice.Text = "";
            textBoxLaptopStock.Text = "0";
            CurrentIdLaptop = null;
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
            string degreeUnit = "metric";

            if (unit != null)
            {
                switch (unit)
                {
                    case "Kelvin":
                        degreeUnit = string.Empty;
                        break;
                    case "Fahrenheit":
                        degreeUnit = "imperial";
                        break;
                    default:
                        degreeUnit = "metric";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(degreeUnit))
            {
                degreeUnit = "&units=" + degreeUnit;
            }

            string uriString = $"https://api.openweathermap.org/data/2.5/weather?q={textBoxSearchWeather.Text}&appid={Global.OpenWheatherMapApiKey}{degreeUnit}";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(uriString);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string responseBody = await response.Content.ReadAsStringAsync();

            JsonDocument jsonDocument = JsonDocument.Parse(responseBody);

            weatherData.Clear();
            foreach (JsonProperty property in jsonDocument.RootElement.EnumerateObject())
            {
                weatherData.Add(property.Name, GetJsonValue(property.Value));
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

        private object GetJsonValue(JsonElement element)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    Dictionary<string, object> obj = new Dictionary<string, object>();
                    foreach (JsonProperty property in element.EnumerateObject())
                    {
                        obj.Add(property.Name, GetJsonValue(property.Value));
                    }
                    return obj;

                case JsonValueKind.Array:
                    List<object> array = new List<object>();
                    foreach (JsonElement arrayElement in element.EnumerateArray())
                    {
                        array.Add(GetJsonValue(arrayElement));
                    }
                    return array;

                case JsonValueKind.String:
                    return element.GetString()!;

                case JsonValueKind.Number:
                    return element.GetDouble()!;

                case JsonValueKind.True:
                    return true;

                case JsonValueKind.False:
                    return false;

                default:
                    throw new NotSupportedException("Unsupported JSON value kind " + element.ValueKind);
            }
        }

        private void OnTextBoxLaptopPriceKeyPressed(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void OnTextBoxLaptopStockKeyPressed(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void OnButtonClearLaptopClick(object sender, EventArgs e) => ClearCurrentLaptopEditing();

        private void OnButtonDeleteLaptopClick(object sender, EventArgs e) => MessageBox.Show("Perlu fitur hapus tidak ya?", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            int affectedRows = 0;
            if (CurrentIdLaptop == null)
            {
                affectedRows = DbHelper.GetInstance().Create(Global.TableLaptop, new Laptop(0, name, price, stock).ToJson());
            }
            else
            {
                affectedRows = DbHelper.GetInstance().Update(Global.TableLaptop, new Laptop(0, name, price, stock).ToJson(), Global.ColumnLaptopId, CurrentIdLaptop!);
            }
            ReadLaptopData();
            SetLaptopState();

            if (affectedRows > 0)
            {
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

            foreach (int idLaptop in CurrentShoppingCarts.Keys)
            {
                Laptop theLaptop = Laptops.Where((e) => e.Id == idLaptop).Single();
                DetailTransaction newDetailTransaction = new DetailTransaction(0, newTransaction, theLaptop, CurrentShoppingCarts[idLaptop]);

                DbHelper.GetInstance().Create(Global.TableDetailTransaction, newDetailTransaction.ToJson());
                DbHelper.GetInstance().Update(Global.TableLaptop, theLaptop.ToJson(), Global.ColumnLaptopId, theLaptop.Id);
            }

            ClearShoppingCarts();
            ReadLaptopData();
            SetLaptopState();
            SetTotalState();
            SetTransactionChangeState();
            textBoxTransactionPay.Clear();
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
    }
}