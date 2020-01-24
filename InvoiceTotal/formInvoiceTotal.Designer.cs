namespace InvoiceTotal
{
  partial class formInvoiceTotal
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnCalc = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtSubtotal = new System.Windows.Forms.TextBox();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.txtDiscountAmount = new System.Windows.Forms.TextBox();
      this.txtDiscountPercent = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnCalc
      // 
      this.btnCalc.Location = new System.Drawing.Point(35, 227);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(122, 39);
      this.btnCalc.TabIndex = 1;
      this.btnCalc.Text = "Calculate";
      this.btnCalc.UseVisualStyleBackColor = true;
      this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(217, 227);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(122, 39);
      this.btnExit.TabIndex = 2;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(17, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 25);
      this.label1.TabIndex = 2;
      this.label1.Text = "Subtotal";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(17, 68);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(176, 25);
      this.label2.TabIndex = 3;
      this.label2.Text = "Discount Percent";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(17, 120);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(175, 25);
      this.label3.TabIndex = 4;
      this.label3.Text = "Discount Amount";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(17, 174);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 25);
      this.label4.TabIndex = 5;
      this.label4.Text = "Total";
      // 
      // txtSubtotal
      // 
      this.txtSubtotal.Location = new System.Drawing.Point(223, 12);
      this.txtSubtotal.Name = "txtSubtotal";
      this.txtSubtotal.Size = new System.Drawing.Size(136, 31);
      this.txtSubtotal.TabIndex = 0;
      // 
      // txtTotal
      // 
      this.txtTotal.Location = new System.Drawing.Point(223, 168);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.ReadOnly = true;
      this.txtTotal.Size = new System.Drawing.Size(136, 31);
      this.txtTotal.TabIndex = 7;
      this.txtTotal.TabStop = false;
      // 
      // txtDiscountAmount
      // 
      this.txtDiscountAmount.Location = new System.Drawing.Point(223, 114);
      this.txtDiscountAmount.Name = "txtDiscountAmount";
      this.txtDiscountAmount.ReadOnly = true;
      this.txtDiscountAmount.Size = new System.Drawing.Size(136, 31);
      this.txtDiscountAmount.TabIndex = 8;
      this.txtDiscountAmount.TabStop = false;
      // 
      // txtDiscountPercent
      // 
      this.txtDiscountPercent.Location = new System.Drawing.Point(223, 62);
      this.txtDiscountPercent.Name = "txtDiscountPercent";
      this.txtDiscountPercent.ReadOnly = true;
      this.txtDiscountPercent.Size = new System.Drawing.Size(136, 31);
      this.txtDiscountPercent.TabIndex = 9;
      this.txtDiscountPercent.TabStop = false;
      // 
      // formInvoiceTotal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(379, 292);
      this.Controls.Add(this.txtDiscountPercent);
      this.Controls.Add(this.txtDiscountAmount);
      this.Controls.Add(this.txtTotal);
      this.Controls.Add(this.txtSubtotal);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnCalc);
      this.Name = "formInvoiceTotal";
      this.Text = "Invoice Total";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalc;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtSubtotal;
    private System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.TextBox txtDiscountAmount;
    private System.Windows.Forms.TextBox txtDiscountPercent;
  }
}

