using Logitop.Utils;
using System.Data;

namespace Logitop.Models
{
    public class Transaction
    {
        public int Id;
        public DateTime Date;
        public int pay;

        public Transaction(int id, DateTime date, int pay)
        {
            Id = id;
            Date = date;
            this.pay = pay;
        }

        private string PadLeft(int number) => number.ToString().PadLeft(2, '0');

        public string GetFormattedDate(bool withDayOfWeek = false, bool withMonthName = false) => $"{(withDayOfWeek ? $"{Global.TranslateDayOfWeek(Date.DayOfWeek)}, " : "")}{PadLeft(Date.Day)}{(withMonthName ? " " : "/")}{(withMonthName ? Global.TranslateMonth(Date.Month) : PadLeft(Date.Month))}{(withMonthName ? " " : "/")}{PadLeft(Date.Year)} {PadLeft(Date.Hour)}:{PadLeft(Date.Minute)}:{PadLeft(Date.Second)}";

        public static Transaction FromDataRow(DataRow row) => new Transaction(
            (int)row[Global.ColumnTransactionId],
            (DateTime)row[Global.ColumnTransactionDate],
            (int)row[Global.ColumnTransactionPay]
        );

        public Dictionary<string, object> ToJson() => new Dictionary<string, object>
        {
            { Global.ColumnTransactionDate,Date },
            { Global.ColumnTransactionPay, pay }
        };
    }
}
