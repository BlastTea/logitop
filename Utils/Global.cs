using System.Drawing.Printing;

namespace Logitop.Utils
{
    public static class Global
    {
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

        public const string DatabaseHost = "localhost";
        public const int DatabasePort = 5432;
        public const string DatabaseUsername = "postgres";
        public const string DatabasePassword = "HELLOWORLD123";
        public const string DatabaseName = "postgres";
        public const string DatabaseSchema = "public";

        public const string OpenWheatherMapApiKey = "f9f10740f79d2757163ca9be85aebf8f";

        public static readonly PaperSize PaperSize58mm = new PaperSize("Custom", 201, 0);
        public static readonly PaperSize PaperSize80mm = new PaperSize("Custom", 283, 0);

        public const string PaperSize58mmName = "58mm";
        public const string PaperSize80mmName = "80mm";

        public static string TranslateDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "Senin";
                case DayOfWeek.Tuesday:
                    return "Selasa";
                case DayOfWeek.Wednesday:
                    return "Rabu";
                case DayOfWeek.Thursday:
                    return "Kamis";
                case DayOfWeek.Friday:
                    return "Jum'at";
                case DayOfWeek.Saturday:
                    return "Sabtu";
                default:
                    return "Minggu";
            }
        }

        public static string TranslateMonth(int month)
        {
            switch (month) {
                case 2:
                    return "Februari";
                case 3:
                    return "Maret";
                case 4:
                    return "April";
                case 5:
                    return "Mei";
                case 6:
                    return "Juni";
                case 7:
                    return "Juli";
                case 8:
                    return "Agustus";
                case 9:
                    return "September";
                case 10:
                    return "Oktober";
                case 11:
                    return "November";
                case 12:
                    return "Desember";
                default:
                    return "Januari";
            }
        }

        public static string PadLeft(int number) => number.ToString().PadLeft(2, '0');

        public static string GetFormattedDate(DateTime date, bool withDayOfWeek = false, bool withMonthName = false) => $"{(withDayOfWeek ? $"{Global.TranslateDayOfWeek(date.DayOfWeek)}, " : "")}{PadLeft(date.Day)}{(withMonthName ? " " : "/")}{(withMonthName ? Global.TranslateMonth(date.Month) : PadLeft(date.Month))}{(withMonthName ? " " : "/")}{PadLeft(date.Year)} {PadLeft(date.Hour)}:{PadLeft(date.Minute)}:{PadLeft(date.Second)}";
    }
}
