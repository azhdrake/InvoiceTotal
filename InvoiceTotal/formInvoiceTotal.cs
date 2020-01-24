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
      double subtotal = Convert.ToDouble(txtSubtotal.Text);
      double discountPercent = 0;
      if(subtotal >= 100)
      {
        discountPercent = 0.2;
      }
      else if(subtotal >= 250 && subtotal < 500)
      {
        discountPercent = 0.15;
      }
      else
      {
        discountPercent = 0.1;
      }

      double discountAmount = subtotal * discountPercent;
      double invoiceTotal = subtotal - discountAmount;

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
