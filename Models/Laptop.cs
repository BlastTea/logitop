using Logitop.Utils;
using System.Data;

namespace Logitop.Models
{
    public class Laptop
    {
        public int Id;
        public string Name;
        public int Price;
        public int Stock;

        public Laptop(int id, string name, int price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public static Laptop FromDataRow(DataRow row) => new Laptop(
            (int)row[Global.ColumnLaptopId],
            (string)row[Global.ColumnLaptopName],
            (int)row[Global.ColumnLaptopPrice],
            (int)row[Global.ColumnLaptopStock]
        );

        public Dictionary<string, object> ToJson() => new Dictionary<string, object> {
            { Global.ColumnLaptopName, Name },
            { Global.ColumnLaptopPrice, Price },
            { Global.ColumnLaptopStock, Stock },
        };
    }
}
