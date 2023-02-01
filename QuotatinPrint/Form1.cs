using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuotatinPrint
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Multiply()
        {
            double  a = Convert.ToInt32(txtUnitPrice.Text);

            double  b = Convert.ToInt32(txtQty.Text);

            double  c = a * b;

            lblAmount.Text = Convert.ToString(c);

        }

        public void PrintCommand()
        {
            try
            {
                NPrintPreviewDialog.Size = new System.Drawing.Size(500, 700);
                NPrintPreviewDialog.Document = NPrintDocument;
                NPrintPreviewDialog.ShowDialog();
                NPrintDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA5", 270, 600);
                
            }
            catch
            {
                
               MessageBox.Show("Not permission for reprint.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void NPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("RECEIPT", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(0, 8));
            e.Graphics.DrawString("Nethmina Mobile", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(29, 26));
            e.Graphics.DrawString("NO:10, First Floor, MC Plaza", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(54, 57));
            e.Graphics.DrawString("KURUNEGALA", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(85, 72));
            e.Graphics.DrawString("Tel:- 071 642 7418", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(75, 87));
            e.Graphics.DrawString("Date:  " + "Date", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(1, 112));
            e.Graphics.DrawString("Time:  " + "Time", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(1, 128));
            e.Graphics.DrawString("Customer Name : " + "Mr" + " " + "Name", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, 153));
            e.Graphics.DrawString("Product : " + "Phone_Type", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(51, 174));
            e.Graphics.DrawString("IMEI : " + "[" + "IMEI" + "]", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(71, 198));
            e.Graphics.DrawString("---------------------------------------------------------------", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(15, 212));
            e.Graphics.DrawString("Amount : Rs." + "Total", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(52, 226));
            e.Graphics.DrawString("---------------------------------------------------------------", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(15, 242));
            e.Graphics.DrawString("Cash : Rs." + "Cash", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(66, 257));
            e.Graphics.DrawString("---------------------------------------------------------------", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(15, 272));
            e.Graphics.DrawString("Balance : Rs." + "Balance", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(47, 289));
            e.Graphics.DrawString("---------------------------------------------------------------", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(15, 305));
            e.Graphics.DrawString("Warranty Period :-", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, 329));
            e.Graphics.DrawString("Years : " + "Years", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(68, 349));
            e.Graphics.DrawString("Months : " + "Months", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(145, 349));
            e.Graphics.DrawString("* Goods once sold will not be taken", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 384));
            e.Graphics.DrawString("back and not refundable.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(45, 398));
            e.Graphics.DrawString("* Warranty does not cover for damages", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 412));
            e.Graphics.DrawString("such as burn mars, soldering marks,", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(45, 426));
            e.Graphics.DrawString("scratch marks, pin damages, lightning, ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(45, 440));
            e.Graphics.DrawString("remove or damage warranty sticker and", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(45, 454));
            e.Graphics.DrawString("natural disasters etc.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(45, 468));
            e.Graphics.DrawString("Thank You !!! ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(82, 506));
            e.Graphics.DrawString("Come again !!", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(90, 526));
            e.Graphics.DrawString("(Software Design by J-Max Corp)", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(68, 567));
            e.Graphics.DrawString("+ + + + + + + + + + + + +", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(68, 580));

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintCommand();
        }

        int order = 1;
        double total = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemName.Text) && !string.IsNullOrEmpty(txtUnitPrice.Text))
            {
              //  Receipt obj = new Receipt() {ID=order++,ItemName=txtItemName.Text, };
            }
        }

    }
}
