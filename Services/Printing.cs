﻿using Logitop.Models;
using Logitop.Utils;
using System.Drawing.Printing;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Logitop.Services
{
    public class Printing
    {
        public static void Print(PrintingArguments args)
        {
            PrintDocument printDocument = new PrintDocument();
            PrinterSettings printerSettings = new PrinterSettings();

            printerSettings.DefaultPageSettings.PaperSize = TranslateCurrentPaperSize();
            printerSettings.DefaultPageSettings.Margins = new Margins(0, 0, 4, 4);

            printDocument.PrinterSettings = printerSettings;

            printDocument.PrintPage += new PrintPageEventHandler((sender, e) => PrintMessageHandler(sender, e, args));

            printDocument.Print();
        }

        private static void PrintMessageHandler(object sender, PrintPageEventArgs e, PrintingArguments args)
        {
            Font font = new Font("Monospace", 10);
            Brush brush = Brushes.Black;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            float spacing = 0;
            int maxLength = 23;
            char separator = '=';

            if (args is PrintingArgumentsMessage)
            {
                PrintingArgumentsMessage messageArgs = (PrintingArgumentsMessage)args;

                e.Graphics!.DrawString(messageArgs.Message, font, brush, GetCenterX(e, font, messageArgs.Message), y);
            }
            else if (args is PrintingArgumentsTransaction)
            {
                PrintingArgumentsTransaction transactionArgs = (PrintingArgumentsTransaction)args;
                int total = 0;

                e.Graphics!.DrawString("Tokoku", font, brush, GetCenterX(e, font, "Tokoku"), y);
                y += AddNewLine(e, font, "A", spacing);
                e.Graphics!.DrawString("Jalan Antah Berantah", font, brush, GetCenterX(e, font, "Jalan Antah Berantah"), y);
                y += AddNewLine(e, font, "A", spacing);
                e.Graphics!.DrawString("".PadRight(maxLength, separator), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                y += AddNewLine(e, font, "A", spacing);
                e.Graphics!.DrawString("1/kasir".PadRight(maxLength), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                y += AddNewLine(e, font, "A", spacing);
                e.Graphics!.DrawString($"{transactionArgs.Transaction.GetFormattedDate()}".PadRight(maxLength), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                y += AddNewLine(e, font, "A", spacing);
                e.Graphics!.DrawString("".PadRight(maxLength, separator), font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                y += AddNewLine(e, font, "A", spacing);
                foreach (DetailTransaction detailTransaction in transactionArgs.DetailTransactions)
                {
                    foreach (string name in BreakStringByLength(detailTransaction.Laptop.Name, maxLength))
                    {
                        e.Graphics!.DrawString($"{name.PadRight(maxLength)}", font, brush, GetCenterX(e, font, "".PadRight(maxLength, separator)), y);
                        y += AddNewLine(e, font, "A", spacing);
                    }
                    // Capek bang :)
                }
            }
        }

        private static float GetCenterX(PrintPageEventArgs e, Font font, string text) => e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics!.MeasureString(text, font).Width) / 2;

        private static float GetCenterY(PrintPageEventArgs e, Font font, string text) => e.MarginBounds.Top + (e.MarginBounds.Height - e.Graphics!.MeasureString(text, font).Height) / 2;

        private static float AddNewLine(PrintPageEventArgs e, Font font, string text, float spacing) => e.Graphics!.MeasureString(text, font).Height + spacing;

        private static List<string> BreakStringByLength(string input, int length)
        {
            List<string> lines = new List<string>();
            int currentIndex = 0;

            while (currentIndex < input.Length)
            {
                if (currentIndex + length < input.Length)
                {
                    lines.Add(input.Substring(currentIndex, length));
                    currentIndex += length;
                }
                else
                {
                    lines.Add(input.Substring(currentIndex));
                    currentIndex = input.Length;
                }
            }

            return lines;
        }

        private static string GetLastLineByLength(string input, int length)
        {
            int startIndex = input.Length - length;
            if (startIndex < 0)
                startIndex = 0;

            return input.Substring(startIndex);
        }

        public static PrinterSettings.StringCollection GetAvailablePrinters() => PrinterSettings.InstalledPrinters;

        public static void SetCurrentPrinter(string printer)
        {
            Properties.Settings.Default.CurrentPrinter = printer;
            Properties.Settings.Default.Save();
        }

        public static string GetCurrentPrinter()
        {
            string currentPrinter = Properties.Settings.Default.CurrentPrinter;

            if (string.IsNullOrEmpty(currentPrinter))
            {
                return new PrinterSettings().PrinterName;
            }
            return currentPrinter;
        }

        public static List<string> GetAvailablePaperSizes() => new List<string>() { Global.PaperSize58mmName, Global.PaperSize80mmName };

        public static void SetCurrentPaperSize(string paperSize)
        {
            Properties.Settings.Default.CurrentPaperSize = paperSize;
            Properties.Settings.Default.Save();
        }

        public static string GetCurrentPaperSize()
        {
            string currentPaperSize = Properties.Settings.Default.CurrentPaperSize;

            if (string.IsNullOrEmpty(currentPaperSize))
            {
                return Global.PaperSize58mmName;
            }
            return currentPaperSize;
        }

        private static PaperSize TranslateCurrentPaperSize()
        {
            switch (GetCurrentPaperSize())
            {
                case Global.PaperSize80mmName:
                    return Global.PaperSize80mm;
                default:
                    return Global.PaperSize58mm;
            }
        }
    }

    enum PrintingType { message, transaction }

    public abstract class PrintingArguments { }

    public class PrintingArgumentsMessage : PrintingArguments
    {
        public string Message;

        public PrintingArgumentsMessage(string message)
        {
            Message = message;
        }
    }

    public class PrintingArgumentsTransaction : PrintingArguments
    {
        public Transaction Transaction;
        public List<DetailTransaction> DetailTransactions;

        public PrintingArgumentsTransaction(Transaction transaction, List<DetailTransaction> detailTransactions)
        {
            Transaction = transaction;
            DetailTransactions = detailTransactions;
        }
    }
}
