using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
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
            using (ExcelPackage excelPackage = ExportReportToExcel(transactions, detailTransactions))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdfDocument = new PdfDocument(writer)) {
                        pdfDocument.SetDefaultPageSize(PageSize.A4);

                        using (Document document = new Document(pdfDocument))
                        {
                            document.SetMargins(20, 20, 20, 20);

                            PdfFont titleFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                            PdfFont cellFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                            // Add title to the PDF
                            Paragraph title = new Paragraph("Laporan Logitop")
                                .SetFont(titleFont)
                                .SetFontSize(18)
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetMarginBottom(20);
                            document.Add(title);

                            // Create a table for the data
                            Table table = new Table(UnitValue.CreatePercentArray(9)).UseAllAvailableWidth();
                            table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                            // Add table headers
                            table.AddCell(CreateCell("Id Transaksi", cellFont, true));
                            table.AddCell(CreateCell("Tanggal Transaksi", cellFont, true));
                            table.AddCell(CreateCell("Laptop - Nama", cellFont, true));
                            table.AddCell(CreateCell("Laptop - Harga", cellFont, true));
                            table.AddCell(CreateCell("Laptop - Jumlah", cellFont, true));
                            table.AddCell(CreateCell("Laptop - Total", cellFont, true));
                            table.AddCell(CreateCell("Total", cellFont, true));
                            table.AddCell(CreateCell("Bayar", cellFont, true));
                            table.AddCell(CreateCell("Kembali", cellFont, true));

                            // Populate table with data from Excel
                            for (int row = 6; row <= worksheet.Dimension.End.Row; row++)
                            {
                                table.AddCell(CreateCell(worksheet.Cells[row, 1].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 2].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 3].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 4].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 5].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 6].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 7].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 8].Value?.ToString() ?? "", cellFont));
                                table.AddCell(CreateCell(worksheet.Cells[row, 9].Value?.ToString() ?? "", cellFont));
                            }

                            document.Add(table);
                        }
                    }
                }
            }
        }

        private static Cell CreateCell(string cellValue, PdfFont font, bool isHeader = false)
        {
            Cell cell = new Cell().Add(new Paragraph(cellValue).SetFont(font));

            if (isHeader)
            {
                cell.SetBold();
            }

            return cell;
        }

    }
}