using Logitop.Utils;
using System.Data;

namespace Logitop.Models
{
    public class DetailTransaction
    {
        public int Id;
        public Transaction Transaction;
        public Laptop Laptop;
        public int Amount;

        public DetailTransaction(int id, Transaction transaction, Laptop laptop, int amount)
        {
            Id = id;
            Transaction = transaction;
            Laptop = laptop;
            Amount = amount;
        }

        public static DetailTransaction FromDataRow(DataRow row) => new DetailTransaction(
            (int)row[Global.ColumnDetailTransactionId],
            Transaction.FromDataRow(row),
            Laptop.FromDataRow(row),
            (int)row[Global.ColumnDetailTransactionAmount]
        );

        public Dictionary<string, object> ToJson() => new Dictionary<string, object> {
            { Global.ColumnDetailTransactionTransactionId, Transaction.Id },
            { Global.ColumnDetailTransactionLaptopId, Laptop.Id },
            { Global.ColumnDetailTransactionAmount, Amount },
        };
    }
}
