namespace Logitop.Utils
{
    public static class Global
    {
        public const string TableLaptop = "laptop";
        public const string ColumnLaptopId = "id_laptop";
        public const string ColumnLaptopName = "nama_laptop";
        public const string ColumnLaptopPrice = "harga_laptop";
        public const string ColumnLaptopStock = "stok";

        public const string TableTransaction = "transaksi";
        public const string ColumnTransactionId = "id_transaksi";
        public const string ColumnTransactionDate = "tanggal_transaksi";
        public const string ColumnTransactionPay = "bayar";

        public const string TableDetailTransaction = "detail_transaksi";
        public const string ColumnDetailTransactionId = "id_detail_transaksi";
        public const string ColumnDetailTransactionTransactionId = "id_transaksi";
        public const string ColumnDetailTransactionLaptopId = "id_laptop";
        public const string ColumnDetailTransactionAmount = "jumlah";

        public const string DatabaseHost = "localhost";
        public const int DatabasePort = 5432;
        public const string DatabaseUsername = "postgres";
        public const string DatabasePassword = "HELLOWORLD123";
        public const string DatabaseName = "logitop";
        public const string DatabaseSchema = "public";

        public const string OpenWheatherMapApiKey = "YOUR-API-KEY";
    }
}
