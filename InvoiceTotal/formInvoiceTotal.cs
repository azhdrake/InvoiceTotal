using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
  public partial class formInvoiceTotal : Form
  {
    public formInvoiceTotal()
    {
      InitializeComponent();
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
      //gets contents of the subtotal box.
        //Data validation is for suckers.
      double invoiceSubtotal = Convert.ToDouble(txtSubtotal.Text);
      double discountPercent = 0;

      //caculates what the discount percent should be 
      if(invoiceSubtotal >= 500)
      {
        discountPercent = 0.2;
      }
      else if(invoiceSubtotal >= 250 && invoiceSubtotal < 500)
      {
        discountPercent = 0.15;
      }
      else if (invoiceSubtotal >= 100 && invoiceSubtotal < 250)
      {
        discountPercent = 0.1;
      }

      //caculates the invoice total
      double discountAmount = invoiceSubtotal * discountPercent;
      double invoiceTotal = invoiceSubtotal - discountAmount;

      //assigns calculated values to text boxes.
      txtDiscountPercent.Text = discountPercent.ToString("p1");
      txtDiscountAmount.Text = discountAmount.ToString("c");
      txtTotal.Text = invoiceTotal.ToString("c");

      txtSubtotal.Focus();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
