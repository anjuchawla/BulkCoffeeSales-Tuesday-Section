using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkCoffeeSales
{
    public partial class FormCoffeeBulkSales : Form
    {
        public FormCoffeeBulkSales()
        {
            InitializeComponent();
        }

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //setting up the print page for preview and print
            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial Black", 14, FontStyle.Bold);
            float lineHeightFloat = printFont.GetHeight();
            float col1HorizontalPrintLocationFloat = e.MarginBounds.Left;
            float col2HorizontalPrintLocationFloat = 300;
            float col3HorizontalPrintLocationFloat;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            SizeF fontSizeF = new SizeF();
            string formattedPriceString;


            //print the heading
            e.Graphics.DrawString("Coffee Bulk Sales Report", headingFont, Brushes.Black,
                col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
            verticalPrintLocationFloat += lineHeightFloat * 2;
            //headings to columns
            e.Graphics.DrawString("Quantity", headingFont, Brushes.Black,
               col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
            e.Graphics.DrawString("Type", headingFont, Brushes.Black,
               col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
            e.Graphics.DrawString("Price", headingFont, Brushes.Black,
               500, verticalPrintLocationFloat);

            verticalPrintLocationFloat += lineHeightFloat * 2;

            //print the transactions
            // can use a for each loop
            foreach (CoffeeSale transaction in transactionsCoffeeSalesList)
            {
                //refer with transaction.quantityString
                //print the quantity
                e.Graphics.DrawString(transaction.quantityString, printFont,
                    Brushes.Black, col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                //print the coffee type
                e.Graphics.DrawString(transaction.typeString, printFont,
                   Brushes.Black, col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                //format and right align the price
                formattedPriceString = transaction.priceDecimal.ToString("c");
                //measure string in this fone
                fontSizeF = e.Graphics.MeasureString(formattedPriceString, printFont);
                //subtract width from column position
                col3HorizontalPrintLocationFloat = 550 - fontSizeF.Width;
                //print the price
                e.Graphics.DrawString(formattedPriceString, printFont,
                  Brushes.Black, col3HorizontalPrintLocationFloat, verticalPrintLocationFloat);

                //go to next printing position
                verticalPrintLocationFloat += lineHeightFloat;
            }

            for (int index = 0; index < transactionNumberInteger; index++)
            {
                //print the quantity
                e.Graphics.DrawString(transactionsCoffeeSales[index].quantityString, printFont,
                    Brushes.Black, col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                //print the coffee type
                e.Graphics.DrawString(transactionsCoffeeSales[index].typeString, printFont,
                   Brushes.Black, col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                //format and right align the price
                formattedPriceString = transactionsCoffeeSales[index].priceDecimal.ToString("c");
                //measure string in this fone
                fontSizeF = e.Graphics.MeasureString(formattedPriceString, printFont);
                //subtract width from column position
                col3HorizontalPrintLocationFloat = 550 - fontSizeF.Width;
                //print the price
                e.Graphics.DrawString(formattedPriceString, printFont,
                  Brushes.Black, col3HorizontalPrintLocationFloat, verticalPrintLocationFloat);

                //go to next printing position
                verticalPrintLocationFloat += lineHeightFloat;


            }

            }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //preview the transaction report and print if required
            //print if there are any transactions
            if (transactionNumberInteger > 0)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                //only if printing is required without previewing
                //printDocument1.Print();
            }
            else
            {
                MessageBox.Show("There are no transactions to print",
                   "Print Transactions", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }

        }
    }
}
