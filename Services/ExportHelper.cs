using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Logitop.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Logitop.Services
{
    public class ExportHelper
    {
        private static ExcelPackage ExportReportToExcel(List<Transaction> transactions, List<DetailTransaction> detailTransactions)
        {
            ExcelPackage excelPackage = new ExcelPackage();

            ExcelWorksheet reportSheet = excelPackage.Workbook.Worksheets.Add("Laporan");

            reportSheet.Cells[1, 1].Value = "Laporan Logitop";
            reportSheet.Cells[3, 1].Value = "Id Transaksi";
            reportSheet.Cells[3, 2].Value = "Tanggal Transaksi";
            reportSheet.Cells[3, 3].Value = "Laptop";
            reportSheet.Cells[4, 3].Value = "Nama";
            reportSheet.Cells[4, 4].Value = "Harga";
            reportSheet.Cells[4, 5].Value = "Jumlah";
            reportSheet.Cells[4, 6].Value = "Total";
            reportSheet.Cells[3, 7].Value = "Total";
            reportSheet.Cells[3, 8].Value = "Bayar";
            reportSheet.Cells[3, 9].Value = "Kembali";

            List<ExcelRange> mergedCells = new List<ExcelRange>()
            {
                reportSheet.Cells["A1:I2"],
                reportSheet.Cells["A3:A4"],
                reportSheet.Cells["B3:B4"],
                reportSheet.Cells["C3:F3"],
                reportSheet.Cells["G3:G4"],
                reportSheet.Cells["H3:H4"],
                reportSheet.Cells["I3:I4"]
            };

            foreach (ExcelRange mergedCell in mergedCells)
            {
                mergedCell.Merge = true;
                mergedCell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                mergedCell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            }

            int i = 0;
            const int additionalRow = 5;
            foreach (Transaction transaction in transactions)
            {
                int detailTransactionLength = 0;
                int totalTransaction = 0;

                // Set Id Transaksi
                reportSheet.Cells[i + additionalRow, 1].Value = transaction.Id;
                // Set Tanggal Transaksi
                reportSheet.Cells[i + additionalRow, 2].Value = transaction.GetFormattedDate(withDayOfWeek: true, withMonthName: true);
                foreach (DetailTransaction detailTransaction in detailTransactions.Where((e) => e.Transaction.Id == transaction.Id))
                {
                    // Set Nama Laptop
                    reportSheet.Cells[i + additionalRow + detailTransactionLength, 3].Value = detailTransaction.Laptop.Name;
                    // Set Harga Laptop
                    reportSheet.Cells[i + additionalRow + detailTransactionLength, 4].Value = detailTransaction.Laptop.Price;
                    // Set Jumlah Laptop
                    reportSheet.Cells[i + additionalRow + detailTransactionLength, 5].Value = detailTransaction.Amount;
                    // Set Total Laptop
                    int totalLaptop = detailTransaction.Laptop.Price * detailTransaction.Amount;
                    reportSheet.Cells[i + additionalRow + detailTransactionLength, 6].Value = totalLaptop;

                    totalTransaction += totalLaptop;
                    detailTransactionLength++;
                }
                // Set Total Transaksi
                reportSheet.Cells[i + additionalRow, 7].Value = totalTransaction;
                // Set Bayar
                reportSheet.Cells[i + additionalRow, 8].Value = transaction.pay;
                // Set Kembali
                reportSheet.Cells[i + additionalRow, 9].Value = transaction.pay - totalTransaction;

                List<ExcelRange> mergedTransactionCells = new List<ExcelRange>()
                {
                    reportSheet.Cells[$"A{i + additionalRow}:A{i + additionalRow + detailTransactionLength - 1}"],
                    reportSheet.Cells[$"B{i + additionalRow}:B{i + additionalRow + detailTransactionLength - 1}"],
                    reportSheet.Cells[$"G{i + additionalRow}:G{i + additionalRow + detailTransactionLength - 1}"],
                    reportSheet.Cells[$"H{i + additionalRow}:H{i + additionalRow + detailTransactionLength - 1}"],
                    reportSheet.Cells[$"I{i + additionalRow}:I{i + additionalRow + detailTransactionLength - 1}"],
                };

                foreach (ExcelRange mergedTransactionCell in mergedTransactionCells)
                {
                    mergedTransactionCell.Merge = true;
                    mergedTransactionCell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    mergedTransactionCell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }
                i += detailTransactionLength;
            }
            return excelPackage;
        }

        public static void ExportReportToExcel(string filePath, List<Transaction> transactions, List<DetailTransaction> detailTransactions)
        {
            ExcelPackage excelPackage = ExportReportToExcel(transactions, detailTransactions);

            FileInfo fileInfo = new FileInfo(filePath);
            excelPackage.SaveAs(fileInfo);
        }

        public static void ExportReportToPdf(string filePath, List<Transaction> transactions, List<DetailTransaction> detailTransactions)
        {
            ExcelPackage excelPackage = ExportReportToExcel(transactions, detailTransactions);

            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdfDocument = new PdfDocument(writer))
                {
                    Document document = new Document(pdfDocument);

                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;

                    Table table = new Table(colCount);

                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int col = 1; col <= colCount; col++)
                        {
                            string cellValue = worksheet.Cells[row, col].Value?.ToString();
                            if (cellValue == null)
                            {
                                continue;
                            }
                            Cell cell = new Cell().Add(new Paragraph(cellValue));
                            table.AddCell(cell);
                        }
                    }

                    document.Add(table);
                    document.Close();

                }
            }
        }
    }
}