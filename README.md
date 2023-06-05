# logitop
Project yang dibuat untuk mengerjakan tugas jajanan pasar

# 1. Membuat database 
Untuk membuat database, silahkan pergi ke file Assets/database.sql lalu import databasenya, atau bisa copy di https://github.com/BlastTea/logitop/blob/master/Assets/database.sql

# 2. Konfigurasi
Lakukan konfigurasi di file Utils/global.cs sebagai berikut:
```cs
namespace Logitop.Utils
{
    public static class Global
    {
	// Ini adalah const variable, jika nama kolom berbeda dari yang ada di bawah, silahkan ganti valuenya
        public const string TableLaptop = "laptop";
        public const string ColumnLaptopId = "id_laptop";
        public const string ColumnLaptopName = "nama_laptop";
        public const string ColumnLaptopPrice = "harga_laptop";
        public const string ColumnLaptopStock = "stok";
        public const string ColumnLaptopIsDeleted = "is_laptop_deleted";

        public const string TableTransaction = "transaksi";
        public const string ColumnTransactionId = "id_transaksi";
        public const string ColumnTransactionDate = "tanggal_transaksi";
        public const string ColumnTransactionPay = "bayar";

        public const string TableDetailTransaction = "detail_transaksi";
        public const string ColumnDetailTransactionId = "id_detail_transaksi";
        public const string ColumnDetailTransactionTransactionId = "id_transaksi";
        public const string ColumnDetailTransactionLaptopId = "id_laptop";
        public const string ColumnDetailTransactionAmount = "jumlah";

        public const string DatabaseHost = "localhost"; // Ubah hostnya jika berbeda
        public const int DatabasePort = 5432; // Database Port
        public const string DatabaseUsername = "postgres"; // Username
        public const string DatabasePassword = "HELLOWORLD123"; // Password
        public const string DatabaseName = "postgres"; // Nama databasenya
        public const string DatabaseSchema = "public"; // Nama schemanya

        public const string OpenWheatherMapApiKey = "YOUR-API-KEY"; // silahkan ganti API key
	...
    }
}
```
# 3. Jalankan Aplikasi
Silahkan jalankan aplikasinya