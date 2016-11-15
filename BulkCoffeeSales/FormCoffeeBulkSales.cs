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
        private struct CoffeeSale
        {
            public String quantity;
            public String type;
            public decimal price;

        }
        //number of transactions that will be saved
        private const int MaximumTransactions = 5;
        //save the transactions in a 1d array
        private CoffeeSale[] transactionsCoffeeSales = new CoffeeSale[MaximumTransactions];
        //save transactions in a list
        private List<CoffeeSale> transactionsCoffeeSalesList = new List<CoffeeSale>();
        //keep track of the radio button/quantity of coffee
        private string selectedRadioButtonName;
        //index for the array
        private int transactionNumber = 0;

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
                e.Graphics.DrawString(transaction.quantity, printFont,
                    Brushes.Black, col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                //print the coffee type
                e.Graphics.DrawString(transaction.type, printFont,
                   Brushes.Black, col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                //format and right align the price
                formattedPriceString = transaction.price.ToString("c");
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

            for (int index = 0; index < transactionNumber; index++)
            {
                //print the quantity
                e.Graphics.DrawString(transactionsCoffeeSales[index].quantity, printFont,
                    Brushes.Black, col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                //print the coffee type
                e.Graphics.DrawString(transactionsCoffeeSales[index].type, printFont,
                   Brushes.Black, col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                //format and right align the price
                formattedPriceString = transactionsCoffeeSales[index].price.ToString("c");
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
            if (transactionNumber > 0)
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

        private void FormCoffeeBulkSales_Load(object sender, EventArgs e)
        {
            //default sttings when the applicationn starts
            radioButtonQuarterPound.Checked = true;
            selectedRadioButtonName = "radioButtonQuarterPound";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //terminate the application after confirming printing of transactions
            DialogResult confirm = MessageBox.Show("Want tp print the transaction report before exit?",
                "Transaction Report Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (confirm == DialogResult.Yes)
            {
                buttonPrint_Click(sender, e);

            }
            Application.Exit();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clear the form contents and bring back to default settings
            comboBoxCoffeeType.SelectedIndex = -1;
            radioButtonQuarterPound.Checked = true;
            selectedRadioButtonName = "radioButtonQuarterPound";
            textBoxPrice.Clear();
        }

        private void radioButtonQuantity_CheckedChanged(object sender, EventArgs e)
        {
            //keeps a track of the quantity of the coffee selected
            selectedRadioButtonName = ((RadioButton)sender).Name;

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //finds/looks up and displays the price of the selected coffee type and quantity 

            //save the prices of the coffees - quantity prices per row- quarter, half, full founf prices
            //for regular, decaffinated and special blend
            decimal[,] price = {
                {2.60m, 2.90m, 3.25m },
                { 4.90m, 5.60m, 6.10m},
                {8.75m,9.75m,11.25m}
            };
            int row, column;
            decimal salesPrice;
            CoffeeSale sale;


            //Console.WriteLine(price.GetLength(0));

            //can't save more than 5 transactions
            // if (transactionNumber < MaximumTransactions)
            //{
            try
            {
                column = comboBoxCoffeeType.SelectedIndex;

                //was a coffee type selected?
                if (column != -1)
                {
                    //find the quantity selected
                    switch (selectedRadioButtonName)
                    {

                        case "radioButtonQuarterPound":
                            row = 0;
                            transactionsCoffeeSales[transactionNumber].quantity = "Quarter Pound";
                            sale.quantity = "Quarter Pound";
                            break;

                        case "radioButtonHalfPound":
                            row = 1;
                            transactionsCoffeeSales[transactionNumber].quantity = "Half Pound";
                            sale.quantity = "Half Pound";
                            break;
                        case "radioButtonFullPound":
                            row = 2;
                            transactionsCoffeeSales[transactionNumber].quantity = "Full Pound";
                            sale.quantity = "Full Pound";
                            break;
                        default:
                            row = 0;
                            transactionsCoffeeSales[transactionNumber].quantity = "Quarter Pound";
                            sale.quantity = "Quarter Pound";
                            break;
                    }//switch

                    //find the price and display it
                    salesPrice = price[row, column];
                    textBoxPrice.Text = salesPrice.ToString("c");
                    //complete the transaction information
                    transactionsCoffeeSales[transactionNumber].type = comboBoxCoffeeType.Text;
                    transactionsCoffeeSales[transactionNumber].price = salesPrice;
                    transactionNumber++;
                    //complete the sale information and save it in list
                    sale.type = comboBoxCoffeeType.Text;
                    sale.price = salesPrice;
                    transactionsCoffeeSalesList.Add(sale);

                }//coffee type selected
                else
                {
                    MessageBox.Show("Please select a coffee type", "Incomplete Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBoxCoffeeType.Focus();
                }
            }//try ends
            //}
            //else
            //{
            //    MessageBox.Show("Only " + MaximumTransactions + " are allowed. Cannot save the current transaction",
            //        "Save Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //}
            catch (IndexOutOfRangeException )
            {
                MessageBox.Show("Only " + MaximumTransactions + " are allowed. Cannot save the current transaction",
                   "Save Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
    }
}
