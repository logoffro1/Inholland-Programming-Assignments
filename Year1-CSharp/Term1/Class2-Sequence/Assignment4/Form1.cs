using System;

namespace Assignment4
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnVat_Click(object sender, EventArgs e)
        {
            const double vat = 21.00; //it's a const because it never changes (in our example)
            double price = double.Parse(txtPrice.Text); //convert the user input into a double
            double priceVat = (vat / 100) * price; //calculate the % 
            double totalPrice = price + priceVat;

            lblPrice.Text = price.ToString("0.00");
            lblVat.Text = priceVat.ToString("0.00");
            lblTotal.Text= totalPrice.ToString("0.00");
            
        }
    }
}
