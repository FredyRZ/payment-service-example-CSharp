using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NexioPaySample
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Tools.ReadConfig();
            BasicAuth.GetBasicAuth();
        }

        private void SetResultBox(String content, Boolean blankline)
        {
            Resultbox.Text = Resultbox.Text + "\n" + content;
            if (blankline)
                Resultbox.Text = Resultbox.Text + "\n------------------------------------------------------\n";
        }

        private void SetResultBox(String content)
        {
            SetResultBox(content,false);
        }

        //Get JWT & Refresh
        private void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                String result = PaymentService.GetJWT();
                

                SetResultBox("Get JWT result:");
                SetResultBox(result,true);

            }
            catch (Exception ex)
            {
                Console.WriteLine("run GetJWT get exception: " + ex.Message);
                SetResultBox("Get JWT failed:");
                SetResultBox("run GetJWT get exception: " + ex.Message,true);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                String result = PaymentService.RefreshJWT();

                SetResultBox("Refresh JWT result:");
                SetResultBox(result,true);
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("run RefreshJWT get exception: " + ex.Message);
                SetResultBox("Refresh JWT failed:");
                SetResultBox("run RefreshJWT get exception: " + ex.Message,true);
            }
        }
 
        //Payment Service
        private void ps_runtrans_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String result = PaymentService.RunTransaction();

                String id = PaymentService.GetTransId(result);
                
                TransId.Text = id;
                PaymentService.transid = id;

                SetResultBox("run transaction result:");
                SetResultBox(result, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Payment Service run transaction get exception: " + ex.Message);
                SetResultBox("run transaction get exception:");
                SetResultBox(ex.Message, true);
            }
           
        }

        private void ps_voidtrans_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String result = PaymentService.VoidTransaction();

                SetResultBox("Void transaction result:");
                SetResultBox(result, true);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Payment Service void transaction get exception: " + ex.Message);
                SetResultBox("Void transaction get exception:");
                SetResultBox(ex.Message, true);
            }
        }

        private void ps_refundtrans_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String result = PaymentService.RefundTransaction();

                SetResultBox("Refund transaction result:");
                SetResultBox(result, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Payment Service refund transaction get exception: " + ex.Message);
                SetResultBox("Refund transaction get exception:");
                SetResultBox(ex.Message, true);
            }
        }

        private void ps_catpuretrans_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String result = PaymentService.CaptureTransaction();
                SetResultBox("Capture transaction result:");
                SetResultBox(result, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Payment Service capture transaction get exception: " + ex.Message);
                SetResultBox("Capture transaction get exception:");
                SetResultBox(ex.Message, true);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            Resultbox.Text = "";
        }
    }


}
