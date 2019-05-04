using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Cliff Phan (821099130)
/// Bookstore application v2.0
/// Allows the user to choose and checkout from a pre-defined assortment of books, view a summary of their purchase, and calculate total costs
/// Obtains pre-constructed book objects from a text file, and writes the final order to a second text file
/// </summary>
namespace COMPE561_Lab01
{
    public partial class Form1 : Form
    {
        //instantiate a datatable for the datagridview element
        DataTable dt = new DataTable();

        //file names and delimiter character
        const string src_name = "book.txt";
        const string dest_name = "orders.txt";
        const char DELIM = ',';

        //initialisation method
        public Form1()
        {
            InitializeComponent();

            //instantiate a list to contain pre-determined Book objects
            List<Book> BookList = new List<Book>();

            //read Book objects from the source text document, and add them to the list
            try
            {
                StreamReader scan_tool = new StreamReader(src_name);
                string book_line; //holds a single line from the .txt
                while ((book_line = scan_tool.ReadLine()) != null) //while more lines exist to be read
                {
                    string[] book_properties = book_line.Split(DELIM); //split the line into multiple strings, and store them in an array
                    BookList.Add(new Book(book_properties[0], book_properties[1], book_properties[2], book_properties[3])); //construct a Book object with the strings, and add it to the list
                }
                scan_tool.Close();
            }

            catch
            {
                MessageBox.Show("BUGSPLAT: Failed to read stock details. Please contact the administrator.");
                Environment.Exit(0);
            }

            //fill the combobox with the items in the list
            dropdown.DataSource = BookList;

            //initialise the default selection of the combobox to null
            dropdown.SelectedItem = null;

            //set up the columns of the datatable
            dt.Columns.AddRange(new DataColumn[4]
            {
                new DataColumn("Title", typeof(string)),
                new DataColumn("Author", typeof(string)),
                new DataColumn("ISBN", typeof(string)),
                new DataColumn("Price($)", typeof(string))
            });

            //set the datatable as the source for the datagridview
            maingrid.DataSource = dt;
        }


        //controls values displayed in textboxes based on combobox selection
        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if an item in the combobox has been selected, populate the textboxes
            if (!(dropdown.SelectedItem is null))
            {
                //obtain the currently selected Book object
                Book selected_book = dropdown.SelectedItem as Book;

                //access its properties and display them in the textboxes
                authorbox.Text = selected_book.author;
                isbnbox.Text = selected_book.isbn;
                pricebox.Text = $"${selected_book.price}"; //convert to money-format
            }

            //if there is no selection, ensure the textboxes are empty
            else
            {
                authorbox.Text = null;
                isbnbox.Text = null;
                pricebox.Text = null;
            }
        }


        //addbutton click event handler
        private void addbutton_Click(object sender, EventArgs e)
        {
            //if an item in the combobox has been selected, attempt to fill the datatable
            if (!(dropdown.SelectedItem is null))
            {
                //obtain the currently selected Book object
                Book selected_book = dropdown.SelectedItem as Book;

                //if the quantity textbox input is valid, perform price calculations and populate the datatable
                if (int.TryParse(qtybox.Text, out int qty))
                {
                    //QoL: prevent the user from entering a zero quantity
                    if (qty != 0)
                    {
                        //calculate a price for the current selection and convert it into a money-format string
                        double baseprice = Convert.ToDouble(selected_book.price) * qty;
                        string displayprice = baseprice.ToString();

                        //add a row to the datatable based on the properties of the selected book
                        dt.Rows.Add(selected_book.title, selected_book.author, selected_book.isbn, displayprice);

                        //QoL: clear the quantity input after an item is added to the datatable
                        qtybox.Text = null;
                    }

                    else MessageBox.Show("Please enter a nonzero quantity.");
                }

                //display an error message in the case of an invalid input in qtybox
                else
                {
                    MessageBox.Show("Please submit a valid quantity.");
                    qtybox.Focus();
                }
            }

            //display an error message if there is no combobox selection
            else
            {
                MessageBox.Show("Please select a book from the drop-down menu.");
                dropdown.Focus();
            }
        }


        //confirmbutton click event handler
        private void confirmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //this if-statement simply serves to check if any cells exist
                //the if-check logic itself will never fail because the program will instead throw an exception if the cell doesn't exist
                //this is handled in a catch-block instead of an else-block
                if (!(dt.Rows[0][0] is null))
                {
                    double subtotal = 0; //running total for subtotal calculation
                    int count = dt.Rows.Count; //total number of entries added to datatable

                    //sum up the prices of all items in the datatable
                    for (int i = 0; i < count; i++)
                    {
                        double itemprice = Convert.ToDouble(dt.Rows[i][3]);
                        subtotal += itemprice;
                    }

                    //calculate tax and total
                    double tax = (Math.Ceiling(subtotal * 10) / 100.0); //rounds up to 2 decimal places by dividing a whole number by 100
                    double total = subtotal + tax;

                    //display all costs in their relevant textboxes
                    subtotalbox.Text = $"${subtotal}";
                    taxbox.Text = $"${tax}";
                    totalbox.Text = $"${total}";

                    //write the finalised order to the destination text document
                    try
                    {
                        FileStream destination = new FileStream(dest_name, FileMode.Create, FileAccess.Write);
                        StreamWriter print_tool = new StreamWriter(destination);

                        print_tool.WriteLine($"\nSubtotal: ${subtotal}");
                        print_tool.WriteLine($"Tax: ${tax}");
                        print_tool.WriteLine($"Total: ${total}");
                        print_tool.WriteLine("*******END OF ORDER SUMMARY*******");

                        print_tool.Close();
                        destination.Close();
                        MessageBox.Show("Checkout successful!");
                    }

                    catch
                    {
                        MessageBox.Show("BUGSPLAT: Failed to record checkout details. Please contact the administrator.");
                    }
                }
            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please select at least one checkout item.");
            }
        }


        //cancelbutton click event handler
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            //set up the yes-no dialogue prompt
            DialogResult choice = MessageBox.Show("Are you sure you want to cancel your current order?", "Cancel order", MessageBoxButtons.YesNo);

            //if the user selects "Yes", clear the datatable and all price calculations
            if (choice == DialogResult.Yes)
            {
                dt.Clear();
                subtotalbox.Text = null;
                taxbox.Text = null;
                totalbox.Text = null;
            }
        }
    }
}
