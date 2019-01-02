using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;



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

        //Write response result to ResultBox
        private void SetResultBox(String content)
        {
            SetResultBox(content,false);
        }
       

        //Clear ResultBox content
        private void clear_btn_Click(object sender, EventArgs e)
        {
            Resultbox.Text = "";
        }

        //ClientSideToken
        private void ClientSideToken_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Resultbox.Text = "";

                ClientSideToken cli = new ClientSideToken();
                String result = cli.ClientSideTokenProcess();

                SetResultBox("Client Side Token process result:");
                SetResultBox(format_json(result), true);

            }
            catch (Exception exp)
            {
                Console.WriteLine("Client Side Token get exception: " + exp.Message);
                MessageBox.Show("Client Side Token get exception: " + exp.Message);
            }
        }


        private void rb_savecard_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_savecard.Checked)
            {
                //paste post data in messaebox
                String postData =
                                     "{" + "\n" +
                                     "  \"data\": {" + "\n" +
                                     "              \"paymentMethod\": \"creditCard\"," + "\n" +
                                     "              \"allowedCardTypes\": [" + "\n" +
                                     "                                      \"visa\"," + "\n" +
                                     "                                      \"mastercard\"," + "\n" +
                                     "                                      \"discover\"," + "\n" +
                                     "                                      \"amex\"" + "\n" +
                                     "                                    ]," + "\n" +
                                     "              \"amount\": 1.15," + "\n" +
                                     "              \"currency\": \"USD\"," + "\n" +
                                     "              \"description\": \"test purchase\"," + "\n" +
                                     "              \"customFields\": {" + "\n" +
                                     "                                  \"custom1\": \"hi mom\"," + "\n" +
                                     "                                  \"custom2\": \"P#dfk1234kdf\"" + "\n" +
                                     "                                }," + "\n" +
                                     "              \"customer\": {" + "\n" +
                                     "                              \"invoice\": \"123\"," + "\n" +
                                     "                              \"orderNumber\": \"456\"," + "\n" +
                                     "                              \"customerRef\": \"123\"," + "\n" +
                                     "                              \"firstName\": \"buck\"," + "\n" +
                                     "                              \"lastName\": \"wild\"," + "\n" +
                                     "                              \"billToAddressOne\": \"123 Street\"," + "\n" +
                                     "                              \"billToAddressTwo\": \"Suite 232\"," + "\n" +
                                     "                              \"billToCity\": \"Amarillo\"," + "\n" +
                                     "                              \"billToState\": \"TX\"," + "\n" +
                                     "                              \"billToPostal\": \"56649\"," + "\n" +
                                     "                              \"billToCountry\": \"US\"" + "\n" +
                                     "                            }" + "\n" +
                                     "            }," + "\n" +
                                     "  \"processingOptions\": {" + "\n" +
                                     "                          \"webhookUrl\": \"\"," + "\n" +
                                     "                          \"webhookFailUrl\": \"\"," + "\n" +
                                     "                          \"checkFraud\": true," + "\n" +
                                     "                          \"verifyCvc\": false," + "\n" +
                                     "                          \"verifyAvs\": 0," + "\n" +
                                     "                          \"verboseResponse\": true" + "\n" +
                                     "                         }," + "\n" +
                                     "  \"uiOptions\": {" + "\n" +
                                     "                  \"customTextUrl\": \"\"," + "\n" +
                                     "                  \"displaySubmitButton\": false," + "\n" +
                                     "                  \"hideCvc\": false," + "\n" +
                                     "                  \"requireCvc\": true," + "\n" +
                                     "                  \"hideBilling\": false," + "\n" +
                                     "                  \"limitCountriesTo\": [" + "\n" +
                                     "                                          \"CA\"," + "\n" +
                                     "                                          \"MX\"," + "\n" +
                                     "                                          \"GB\"," + "\n" +
                                     "                                          \"US\"" + "\n" +
                                     "                                        ]" + "\n" +
                                     "                }," + "\n" +
                                     "  \"card\": {" + "\n" +
                                     "              \"cardHolderName\": \"Kevin Batchelor\"" + "\n" +
                                     "            }," + "\n" +
                                     "  \"cart\": {" + "\n" +
                                     "              \"items\": [" + "\n" +
                                     "                          {" + "\n" +
                                     "                              \"item\": \"E100\"," + "\n" +
                                     "                              \"description\": \"Electric Socks\"," + "\n" +
                                     "                              \"quantity\": 2," + "\n" +
                                     "                              \"price\": 5," + "\n" +
                                     "                              \"type\": \"sale\"" + "\n" +
                                     "                          }" + "\n" +
                                     "                         ]" + "\n" +
                                     "            }" + "\n" +
                                     "}";

                PostDataBox.Text = format_json(postData);
                String urldata = "";
                URLBox.Text = urldata;
            }
        }

        private void rb_cardtrans_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cardtrans.Checked)
            {
                //paste post data in messaebox
                String postData = "{ " +
                                "\"isAuthOnly\":true," +
                                "\"tokenex\":{" +
                                    "\"token\":\"" + ConfigItems.Tokenex_token + "\"," +
                                    "\"firstSix\": \"123\"," +
                                    "\"lastFour\": \"1234\"" +
                                "}," +
                                "\"card\":{" +
                                    "\"expirationMonth\":\"1\"," +
                                    "\"expirationYear\":\"20\"," +
                                    "\"cardHolderName\": \"Captin Hammer\"," +
                                    "\"lastFour\":\"1111\"" +
                                "}," +
                                "\"data\": {" +
                                   "\"currency\":\"USD\"," +
                                   "\"amount\": 10," +
                                   "\"customFields\": {" +
                                       "\"custom1\": \"hi mom\"," +
                                       "\"custom2\": \"P#dfk1234kdf\"" +
                                   "}," +
                                   "\"customer\": {" +
                                       "\"orderNumber\":\"14233\"," +
                                       "\"customerRef\": 1234," +
                                       "\"firstName\":\"Captain\"," +
                                       "\"lastName\":\"Hammer\"," +
                                       "\"billToAddressOne\": \"123 Street\"," +
                                       "\"billToAddressTwo\": \"Box 232\"," +
                                       "\"billToCity\": \"Amarillo\"," +
                                       "\"billToState\": \"TX\"," +
                                       "\"billToPostal\": \"79118\"," +
                                       "\"billToCountry\": \"US\"" +
                                   "}," +
                                   "\"cart\":{" +
                                       "\"items\":[" +
                                           "{\"item\":\"E100\", \"description\":\"Electric Socks\", \"quantity\":2, \"price\":5, \"type\":\"sale\"}" +
                                       "]" +
                                   "}" +
                                "}," +
                                "\"processingOptions\":{" +
                                  "\"checkFraud\": true" +
                                "}" +
                            "}";

                PostDataBox.Text = format_json(postData);

                String urldata = ConfigItems.API_URL + "/pay/v3/process";
                URLBox.Text = urldata;
            }
        }

        private void rb_voidtrans_CheckedChanged(object sender, EventArgs e)
        {
            String postdata = null;
            if (rb_voidtrans.Checked)
            {
                if (this.TransList.Rows.Count > 0)
                {
                    postdata = "{\"data\":{\"amount\":";
                    Boolean found = false;
                    int row = 0;

                    for (int i = 0; i < this.TransList.Rows.Count; i++)
                    {
                        if (TransList[0, i].Value.ToString().ToUpper().Equals("TRUE"))
                        {
                            found = true;
                            row = i;
                            
                            break;
                        } 
                    }

                    if (found)
                    {
                        postdata = postdata + TransList[2, row].Value.ToString() + "}, \"id\":\"" + TransList[1, row].Value.ToString() + "\"}";
                        PostDataBox.Text = format_json(postdata);
                        String urldata = ConfigItems.API_URL + "/pay/v3/void";
                        URLBox.Text = urldata;

                    }
                    else
                    {
                        MessageBox.Show("Please select one transaction!");
                        rb_voidtrans.Checked = false;
                    }                     
                }
                else
                {
                    MessageBox.Show("There's no valid trans in Local Trans List, please card or eCheck trans first!");
                    rb_voidtrans.Checked = false;
                }   
                
            }

        }

        private void rb_refundtrans_CheckedChanged(object sender, EventArgs e)
        {
            String postdata = null;
            if (rb_refundtrans.Checked)
            {
                if (this.TransList.Rows.Count > 0)
                {
                    postdata = "{\"data\":{\"amount\":";
                    Boolean found = false;
                    int row = 0;

                    for (int i = 0; i < this.TransList.Rows.Count; i++)
                    {
                        if (TransList[0, i].Value.ToString().ToUpper().Equals("TRUE"))
                        {
                            found = true;
                            row = i;

                            break;
                        }
                    }

                    if (found)
                    {
                        postdata = postdata + TransList[2, row].Value.ToString() + "}, \"id\":\"" + TransList[1, row].Value.ToString() + "\"}";
                        PostDataBox.Text = format_json(postdata);
                        String urldata = ConfigItems.API_URL + "/pay/v3/refund";
                        URLBox.Text = urldata;
                    }
                    else
                    {
                        MessageBox.Show("Please select one transaction!");
                        rb_refundtrans.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("There's no valid trans in Local Trans List, please card or eCheck trans first!");
                    rb_refundtrans.Checked = false;
                }
            }
            
        }

        private void rb_capturetrans_CheckedChanged(object sender, EventArgs e)
        {
            String postdata = null;
            if (rb_capturetrans.Checked)
            {
                if (this.TransList.Rows.Count > 0)
                {
                    postdata = "{\"data\":{\"amount\":";
                    Boolean found = false;
                    int row = 0;

                    for (int i = 0; i < this.TransList.Rows.Count; i++)
                    {
                        if (TransList[0, i].Value.ToString().ToUpper().Equals("TRUE"))
                        {
                            found = true;
                            row = i;

                            break;
                        }
                    }

                    if (found)
                    {
                        postdata = postdata + TransList[2, row].Value.ToString() + "}, \"id\":\"" + TransList[1, row].Value.ToString() + "\"}";
                        PostDataBox.Text = format_json(postdata);
                        String urldata = ConfigItems.API_URL + "/pay/v3/capture";
                        URLBox.Text = urldata;
                    }
                    else
                    {
                        MessageBox.Show("Please select one transaction!");
                        rb_capturetrans.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("There's no valid trans in Local Trans List, please card or eCheck trans first!");
                    rb_capturetrans.Checked = false;
                }
            }

        }

        private void rb_echeck_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_echeck.Checked)
            {
                //paste post data in messaebox
                String postdata = "{" +
                                     "\"tokenex\":{" +
                                         "\"token\":\"" + ConfigItems.Tokenex_token + "\"" +
                                     "}," +
                                     "\"bank\": {" +
                                       "\"accountHolderName\": \"Test Name\"," +
                                       "\"routingNumber\": \"999546788\"" +
                                     "}," +
                                     "\"data\": {" +
                                       "\"amount\": 1.00," +
                                       "\"currency\": \"USD\"," +
                                       "\"description\": \"test purchase\"," +
                                       "\"customFields\": {" +
                                         "\"custom1\": \"hi mom\"," +
                                         "\"custom2\": \"P#dfk1234kdf\"" +
                                       "}," +
                                       "\"customer\": {" +
                                         "\"billToAddressOne\": \"123 Street\"," +
                                         "\"billToAddressTwo\": \"Box 232\"," +
                                         "\"billToCity\": \"Amarillo\"," +
                                         "\"billToState\": \"TX\"," +
                                         "\"billToPostal\": \"79118\"," +
                                         "\"billToCountry\": \"USA\"" +
                                       "}," +
                                       "\"cart\":{" +
                                               "\"items\":[" +
                                                   "{\"item\":\"E100\", \"description\":\"Electric Socks\", \"quantity\":2, \"price\":5, \"type\":\"sale\"}" +
                                               "]" +
                                           "}" +
                                     "}" +
                                    "}";

                PostDataBox.Text = format_json(postdata);
                String urldata = ConfigItems.API_URL + "/pay/v3/processECheck";
                URLBox.Text = urldata;
            }

            
        }

        private void rb_deltoken_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_deltoken.Checked)
            {
                String postdata = null;
                //check if there's token in token list first;
                if (this.TokenList.Rows.Count > 0)
                {
                    //paste post data in messaebox
                    //postdata = "{\"tokens\":[\"p6711abg-41fd-m56a-81a1-t0k3n287799b\"," +
                    //"\"f5899abf-41fd-49fa-80a0-t0k3n187763a\"]}";
                    postdata = "{\"tokens\":[\"";

                    for (int i = 0; i < this.TokenList.Rows.Count; i++)
                    {
                        if(i == this.TokenList.Rows.Count - 1)
                            postdata = postdata + TokenList[0, i].Value.ToString() + "\"]}";
                        else
                            postdata = postdata + TokenList[0, i].Value.ToString() + "\",\"";
                    }

                    PostDataBox.Text = format_json(postdata);
                    String urldata = ConfigItems.API_URL + "/pay/v3/deleteToken";
                    URLBox.Text = urldata;
                }
                else
                {
                    MessageBox.Show("There's no valid token in Token List, please do save card trans first!");
                    rb_deltoken.Checked = false;
                }
  
            }
            
        }


        

        private void bt_payment_sendcommand_Click(object sender, EventArgs e)
        {
            String result = null;
            Resultbox.Text = "";
            foreach (Control control in this.groupBox_payment.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        switch (radio.Name)
                        {
                            case "rb_savecard":
                                try
                                {
                                    //todo need define getonetimetoken data here
                                    PaymentService_iFrame.GetOneTimeToken(PostDataBox.Text);
                                    result = PaymentService.SaveCard();
                                    ResponseParse.SaveCardResponseParse(this, result);
                                    SetResultBox("save card result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Service save card get exception: " + ex.Message);
                                    SetResultBox("Payment Service save card get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                
                                break;
                            case "rb_cardtrans":
                                
                                try
                                {
                                    result = PaymentService.RunCreditCardTransaction(URLBox.Text, PostDataBox.Text);

                                    ResponseParse.TransResponseParse(this, result);
                                    
                                    SetResultBox("run transaction result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Service run transaction get exception: " + ex.Message);
                                    SetResultBox("run transaction get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_voidtrans":
                                try
                                {
                                    result = PaymentService.VoidTransaction(URLBox.Text, PostDataBox.Text);

                                    SetResultBox("Void transaction result:");
                                    SetResultBox(format_json(result), true);

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Service void transaction get exception: " + ex.Message);
                                    SetResultBox("Void transaction get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                
                                break;
                            case "rb_refundtrans":
                                try
                                {
                                    result = PaymentService.RefundTransaction(URLBox.Text, PostDataBox.Text);

                                    SetResultBox("Refund transaction result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Service refund transaction get exception: " + ex.Message);
                                    SetResultBox("Refund transaction get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                
                                break;
                            case "rb_capturetrans":
                                try
                                {
                                    result = PaymentService.CaptureTransaction(URLBox.Text, PostDataBox.Text);
                                    SetResultBox("Capture transaction result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Service capture transaction get exception: " + ex.Message);
                                    SetResultBox("Capture transaction get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                
                                break;
                            case "rb_echeck":
                                try
                                {
                                    result = PaymentService.RunECheckTransaction(URLBox.Text, PostDataBox.Text);
                                    
                                    SetResultBox("eCheck transaction result:");
                                    SetResultBox(format_json(result), true);

                                    ResponseParse.TransResponseParse(this,result);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Service eCheck transaction get exception: " + ex.Message);
                                    SetResultBox("eCheck transaction get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                
                                break;
                            case "rb_deltoken":
                                try
                                {
                                    result = PaymentService.DeleteCardTokens(URLBox.Text, PostDataBox.Text);
                                    SetResultBox("delete tokens result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Service delete tokens get exception: " + ex.Message);
                                    SetResultBox("delete tokens get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                
                                break;
                            default:
                                MessageBox.Show("Please select a transction type!");
                                break;
                        }
                    }
                }
            }
        }

        private void rb_iframe_onetimetoken_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_iframe_onetimetoken.Checked)
            {
                //paste post data in messaebox
                String postdata = "{\"data\": {" +
                                       "\"paymentMethod\": \"creditCard\"," +
                                       "\"currency\":\"USD\"," +
                                       "\"amount\": 5," +
                                       "\"partialAmount\":1," +
                                       "\"description\": \"test purchase\"," +
                                       "\"allowedCardTypes\": [" +
                                            "\"visa\"," +
                                            "\"mastercard\"," +
                                            "\"discover\"," +
                                            "\"amex\"" +
                                       "]," +
                                       "\"customFields\": {" +
                                           "\"custom1\": \"hi mom\"," +
                                           "\"custom2\": \"P#dfk1234kdf\"" +
                                       "}," +
                                       "\"customer\": {" +
                                           "\"firstName\":\"Captain\"," +
                                           "\"lastName\":\"Hammer\"," +
                                           "\"customerRef\": 1234," +
                                           "\"billToAddressOne\": \"123 Street\"," +
                                           "\"billToAddressTwo\": \"Box 232\"," +
                                           "\"billToCity\": \"Amarillo\"," +
                                           "\"billToState\": \"TX\"," +
                                           "\"billToPostal\": \"79118\"," +
                                           "\"billToCountry\": \"US\"" +
                                       "}," +
                                       "\"cart\":{" +
                                           "\"items\":[" +
                                               "{\"item\":\"E100\", \"description\":\"Electric Socks\", \"quantity\":2, \"price\":5, \"type\":\"sale\"}" +
                                           "]" +
                                       "}" +
                                        "}," +
                                  "\"uiOptions\": {" +
                                    "\"customTextUrl\": \"\"," +
                                    "\"css\": \"https://tester.nexiopaydev.com/example.css\"," +
                                    "\"displaySubmitButton\": false," +
                                    "\"hideCvc\": false," +
                                    "\"requireCvc\": true," +
                                    "\"hideBilling\": false," +
                                    "\"limitCountriesTo\": [" +
                                      "\"CA\"," +
                                      "\"MX\"," +
                                      "\"GB\"," +
                                      "\"US\"" +
                                    "]" +
                                  "}," +
                                  "\"processingOptions\": {" +
                                    "\"webhookUrl\": \"\"," +
                                    "\"webhookFailUrl\": \"\"," +
                                    "\"checkFraud\": true," +
                                    "\"verifyAvs\": 2," +
                                    "\"verifyCvc\": false," +
                                    "\"verboseResponse\": true" +
                                  "}" +
                                "}";

                String urldata = ConfigItems.API_URL + "/pay/v3/token";
                URLBox.Text = urldata;
                PostDataBox.Text = format_json(postdata);
            }
        }

        private void rb_iframe_runtrans_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_iframe_runtrans.Checked)
            {
                //paste post data in messaebox
                String postdata = "{" +
                                  "\"data\": {" +
                                   " \"paymentMethod\": \"creditCard\"," +
                                   " \"allowedCardTypes\": [" +
                                     " \"visa\"," +
                                     " \"mastercard\"," +
                                     " \"discover\"," +
                                     " \"amex\"" +
                                   " ]," +
                                   " \"amount\": 1.15," +
                                    "\"currency\": \"USD\"," +
                                    "\"description\": \"test purchase\"," +
                                   " \"customFields\": {" +
                                     " \"custom1\": \"hi mom\"," +
                                     " \"custom2\": \"P#dfk1234kdf\"" +
                                    "}," +
                                    "\"customer\": {" +
                                     "\"invoice\": \"123\"," +
                                      "\"orderNumber\": \"456\"," +
                                      "\"customerRef\": \"123\"," +
                                      "\"firstName\": \"buck\"," +
                                      "\"lastName\": \"wild\"," +
                                      "\"billToAddressOne\": \"123 Street\"," +
                                      "\"billToAddressTwo\": \"Suite 232\"," +
                                      "\"billToCity\": \"Amarillo\"," +
                                      "\"billToState\": \"TX\"," +
                                      "\"billToPostal\": \"56649\"," +
                                      "\"billToCountry\": \"US\"" +
                                    "}" +
                                  "}," +
                                  "\"processingOptions\": {" +
                                    "\"webhookUrl\": \"\"," +
                                    "\"webhookFailUrl\": \"\"," +
                                    "\"checkFraud\": true," +
                                    "\"verboseResponse\": true," +
                                    "\"merchantId\": \"\"" +
                                  "}," +
                                  "\"uiOptions\": {" +
                                    "\"customTextUrl\": \"\"," +
                                    "\"displaySubmitButton\": false," +
                                    "\"hideCvc\": false," +
                                    "\"requireCvc\": true," +
                                    "\"hideBilling\": false," +
                                    "\"limitCountriesTo\": [" +
                                      "\"CA\"," +
                                      "\"MX\"," +
                                      "\"GB\"," +
                                      "\"US\"" +
                                    "]" +
                                  "}," +
                                  "\"card\": {" +
                                    "\"cardHolderName\": \"Kevin Batchelor\"" +
                                  "}," +
                                  "\"cart\": {" +
                                    "\"items\": [" +
                                      "{" +
                                        "\"item\": \"E100\"," +
                                        "\"description\": \"Electric Socks\"," +
                                        "\"quantity\": 2," +
                                        "\"price\": 5," +
                                        "\"type\": \"sale\"" +
                                      "}" +
                                    "]" +
                                  "}" +
                                "}";
                
                PostDataBox.Text = format_json(postdata);
                String urldata = "";
                URLBox.Text = urldata;
            }
        }

        private void rb_iframe_alipay_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_iframe_alipay.Checked)
            {
                //paste post data in messaebox
                String postdata = "{" +
                                    " \"data\": {" +
                                    " \"paymentMethod\": \"aliPay\"," +
                                    "\"amount\": 1.15," +
                                    "\"currency\": \"USD\"," +
                                    "\"description\": \"test purchase\"," +
                                    "\"customFields\": {" +
                                        "\"custom1\": \"hi mom\"," +
                                        "\"custom2\": \"P#dfk1234kdf\"" +
                                    "}," +
                                    "\"customer\": {" +
                                        "\"invoice\": \"123\"," +
                                        "\"orderNumber\": \"456\"," +
                                        "\"customerRef\": \"123\"," +
                                        "\"firstName\": \"buck\"," +
                                        "\"lastName\": \"wild\"," +
                                        "\"billToAddressOne\": \"123 Street\"," +
                                        "\"billToAddressTwo\": \"Suite 232\"," +
                                        "\"billToCity\": \"Amarillo\"," +
                                        "\"billToState\": \"TX\"," +
                                        "\"billToPostal\": \"56649\"," +
                                        "\"billToCountry\": \"US\"" +
                                    "}" +
                                    "}," +
                                    "\"processingOptions\": {" +
                                    "\"webhookUrl\": \"\"," +
                                    "\"webhookFailUrl\": \"\"," +
                                    "\"testMode\": \"EXTERNAL\"" +
                                    "}," +
                                    "\"uiOptions\": {" +
                                    "\"customTextUrl\": \"\"" +
                                    "}," +
                                    "\"cart\": {" +
                                    "\"items\": [" +
                                        "{" +
                                        "\"item\": \"E100\"," +
                                        "\"description\": \"Electric Socks\"," +
                                        "\"quantity\": 2," +
                                        "\"price\": 5," +
                                        "\"type\": \"sale\"" +
                                        "}" +
                                    "]" +
                                    "}" +
                                "}";
                PostDataBox.Text = format_json(postdata);

                String urldata = "";
                URLBox.Text = urldata;
            }
        }

        private void rb_iframe_savecard_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_iframe_savecard.Checked)
            {
                //paste post data in messaebox
                String postdata = "{" +
                                     "\"data\": {" +
                                       " \"paymentMethod\": \"creditCard\"," +
                                        "\"allowedCardTypes\": [" +
                                          "\"visa\"," +
                                          "\"mastercard\"," +
                                          "\"discover\"," +
                                          "\"amex\"" +
                                        "]," +
                                        "\"amount\": 1.15," +
                                        "\"currency\": \"USD\"," +
                                        "\"description\": \"test purchase\"," +
                                        "\"customFields\": {" +
                                          "\"custom1\": \"hi mom\"," +
                                          "\"custom2\": \"P#dfk1234kdf\"" +
                                        "}," +
                                        "\"customer\": {" +
                                          "\"invoice\": \"123\"," +
                                          "\"orderNumber\": \"456\"," +
                                          "\"customerRef\": \"123\"," +
                                          "\"firstName\": \"buck\"," +
                                          "\"lastName\": \"wild\"," +
                                          "\"billToAddressOne\": \"123 Street\"," +
                                          "\"billToAddressTwo\": \"Suite 232\"," +
                                          "\"billToCity\": \"Amarillo\"," +
                                          "\"billToState\": \"TX\"," +
                                          "\"billToPostal\": \"56649\"," +
                                          "\"billToCountry\": \"US\"" +
                                        "}" +
                                      "}," +
                                      "\"processingOptions\": {" +
                                        "\"webhookUrl\": \"\"," +
                                        "\"webhookFailUrl\": \"\"," +
                                        "\"checkFraud\": true," +
                                        "\"verifyCvc\": false," +
                                        "\"verifyAvs\": 0," +
                                        "\"verboseResponse\": true" +
                                      "}," +
                                      "\"uiOptions\": {" +
                                        "\"customTextUrl\": \"\"," +
                                        "\"displaySubmitButton\": false," +
                                        "\"hideCvc\": false," +
                                        "\"requireCvc\": true," +
                                        "\"hideBilling\": false," +
                                        "\"limitCountriesTo\": [" +
                                          "\"CA\"," +
                                          "\"MX\"," +
                                          "\"GB\"," +
                                          "\"US\"" +
                                        "]" +
                                      "}," +
                                      "\"card\": {" +
                                        "\"cardHolderName\": \"Kevin Batchelor\"" +
                                      "}," +
                                      "\"cart\": {" +
                                        "\"items\": [" +
                                          "{" +
                                            "\"item\": \"E100\"," +
                                            "\"description\": \"Electric Socks\"," +
                                            "\"quantity\": 2," +
                                            "\"price\": 5," +
                                            "\"type\": \"sale\"" +
                                          "}" +
                                        "]" +
                                      "}" +
                                    "}";
                PostDataBox.Text = format_json(postdata);

                String urldata = "";
                URLBox.Text = urldata;
            }
        }

        private void rb_iframe_saveecheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_iframe_saveecheck.Checked)
            {
                //paste post data in messaebox
                String postdata = "{" +
                                  "\"data\": {" +
                                    "\"paymentMethod\": \"eCheck\"," +
                                    "\"amount\": 1.15," +
                                    "\"currency\": \"USD\"," +
                                    "\"description\": \"test purchase\"," +
                                    "\"customFields\": {" +
                                      "\"custom1\": \"hi mom\"," +
                                      "\"custom2\": \"P#dfk1234kdf\"" +
                                    "}," +
                                    "\"customer\": {" +
                                      "\"invoice\": \"123\"," +
                                      "\"orderNumber\": \"456\"," +
                                      "\"customerRef\": \"123\"," +
                                      "\"firstName\": \"buck\"," +
                                      "\"lastName\": \"wild\"," +
                                      "\"billToAddressOne\": \"123 Street\"," +
                                      "\"billToAddressTwo\": \"Suite 232\"," +
                                      "\"billToCity\": \"Amarillo\"," +
                                      "\"billToState\": \"TX\"," +
                                      "\"billToPostal\": \"56649\"," +
                                      "\"billToCountry\": \"US\"" +
                                    "}" +
                                  "}," +
                                  "\"processingOptions\": {" +
                                    "\"webhookUrl\": \"\"," +
                                    "\"webhookFailUrl\": \"\"," +
                                    "\"verboseResponse\": true" +
                                  "}," +
                                  "\"uiOptions\": {" +
                                    "\"customTextUrl\": \"\"," +
                                    "\"displaySubmitButton\": false," +
                                    "\"hideCvc\": false," +
                                    "\"requireCvc\": true," +
                                    "\"hideBilling\": false," +
                                    "\"limitCountriesTo\": [" +
                                      "\"CA\"," +
                                      "\"MX\"," +
                                      "\"GB\"," +
                                      "\"US\"" +
                                    "]" +
                                  "}," +
                                  "\"bank\": {" +
                                    "\"accountHolderName\": \"Todd Risenmay\"" +
                                  "}" +
                                "}";
                PostDataBox.Text = format_json(postdata);

                String urldata = "";
                URLBox.Text = urldata;
            }
        }

        private void rb_iframe_runecheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_iframe_runecheck.Checked)
            {
                //paste post data in messaebox
                String postdata = "{" +
                                  "\"data\": {" +
                                    "\"paymentMethod\": \"eCheck\"," +
                                    "\"amount\": 1.15," +
                                    "\"currency\": \"USD\"," +
                                    "\"description\": \"test purchase\"," +
                                    "\"customFields\": {" +
                                      "\"custom1\": \"hi mom\"," +
                                      "\"custom2\": \"P#dfk1234kdf\"" +
                                    "}," +
                                    "\"customer\": {" +
                                      "\"invoice\": \"123\"," +
                                      "\"orderNumber\": \"456\"," +
                                      "\"customerRef\": \"123\"," +
                                      "\"firstName\": \"buck\"," +
                                      "\"lastName\": \"wild\"," +
                                      "\"billToAddressOne\": \"123 Street\"," +
                                      "\"billToAddressTwo\": \"Suite 232\"," +
                                      "\"billToCity\": \"Amarillo\"," +
                                      "\"billToState\": \"TX\"," +
                                      "\"billToPostal\": \"56649\"," +
                                      "\"billToCountry\": \"US\"" +
                                    "}" +
                                  "}," +
                                  "\"processingOptions\": {" +
                                    "\"webhookUrl\": \"\"," +
                                    "\"webhookFailUrl\": \"\"," +
                                    "\"verboseResponse\": true" +
                                  "}," +
                                  "\"uiOptions\": {" +
                                    "\"customTextUrl\": \"\"," +
                                    "\"displaySubmitButton\": false," +
                                    "\"hideCvc\": false," +
                                    "\"requireCvc\": true," +
                                    "\"hideBilling\": false," +
                                    "\"limitCountriesTo\": [" +
                                      "\"CA\"," +
                                      "\"MX\"," +
                                      "\"GB\"," +
                                      "\"US\"" +
                                    "]" +
                                  "}," +
                                  "\"bank\": {" +
                                    "\"accountHolderName\": \"Todd Risenmay\"" +
                                  "}" +
                                "}";
                PostDataBox.Text = format_json(postdata);

                String urldata = "";
                URLBox.Text = urldata;
            }
        }

        private void iframe_sendcommand_btn_Click(object sender, EventArgs e)
        {
            String result = null;
            Resultbox.Text = "";
            foreach (Control control in this.groupBox_iframe.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        switch (radio.Name)
                        {
                            case "rb_iframe_onetimetoken":
                                try
                                {
                                    result = PaymentService_iFrame.GetOneTimeToken(PostDataBox.Text);

                                    SetResultBox("Get One Time Token result:");
                                    SetResultBox(result, true);

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("run get One Time Token exception: " + ex.Message);
                                    SetResultBox("Get One Time Token failed:");
                                    SetResultBox("exception: " + ex.Message, true);
                                }
                                break;
                            case "rb_iframe_runtrans":
                                try
                                {
                                    PaymentService_iFrame.GetOneTimeToken(PostDataBox.Text);
                                    result = PaymentService_iFrame.RunCreditCardTransaction();

                                    SetResultBox("run credit card trans result:");
                                    SetResultBox(result, true);

                                    //save result as temp.html
                                    File.WriteAllText(@"temp.html", result);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("run credit card trans get exception: " + ex.Message);
                                    SetResultBox("run credit card trans failed:");
                                    SetResultBox("run credit card trans get exception: " + ex.Message, true);
                                }
                                
                                break;
                            case "rb_iframe_alipay":
                                try
                                {
                                    PaymentService_iFrame.GetOneTimeToken(PostDataBox.Text);
                                    result = PaymentService_iFrame.RunAsyncAlipayTransaction();

                                    SetResultBox("run Alipay trans result:");
                                    SetResultBox(result, true);

                                    //save result as temp.html
                                    File.WriteAllText(@"temp.html", result);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("run Alipay trans get exception: " + ex.Message);
                                    SetResultBox("run Alipay trans failed:");
                                    SetResultBox("run Alipay trans get exception: " + ex.Message, true);
                                }

                                break;
                            case "rb_iframe_savecard":
                                try
                                {
                                    PaymentService_iFrame.GetOneTimeToken(PostDataBox.Text);
                                    result = PaymentService_iFrame.SaveCard();

                                    SetResultBox("iFrame save card result:");
                                    SetResultBox(result, true);

                                    //save result as temp.html
                                    File.WriteAllText(@"temp.html", result);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("iFrame save card get exception: " + ex.Message);
                                    SetResultBox("iFrame save card failed:");
                                    SetResultBox("iFrame save card get exception: " + ex.Message, true);
                                }

                                break;
                            case "rb_iframe_saveecheck":
                                try
                                {
                                    PaymentService_iFrame.GetOneTimeToken(PostDataBox.Text);
                                    result = PaymentService_iFrame.SaveECheck();

                                    SetResultBox("iFrame save eCheck result:");
                                    SetResultBox(result, true);

                                    //save result as temp.html
                                    File.WriteAllText(@"temp.html", result);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("iFrame save eCheck get exception: " + ex.Message);
                                    SetResultBox("iFrame save eCheck failed:");
                                    SetResultBox("iFrame save eCheck get exception: " + ex.Message, true);
                                }
                                break;
                            case "rb_iframe_runecheck":
                                try
                                {
                                    PaymentService_iFrame.GetOneTimeToken(PostDataBox.Text);
                                    result = PaymentService_iFrame.RunECheckTransaction();

                                    SetResultBox("iFrame run eCheck tans result:");
                                    SetResultBox(result, true);

                                    //save result as temp.html
                                    File.WriteAllText(@"temp.html", result);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("iFrame run eCheck tans get exception: " + ex.Message);
                                    SetResultBox("iFrame run eCheck tans failed:");
                                    SetResultBox("iFrame run eCheck tans get exception: " + ex.Message, true);
                                }

                                break;
                            default:
                                MessageBox.Show("Please select a transction type!");
                                break;
                        }
                    }
                }
            }

        }

        private void trans_sendcommand_btn_Click(object sender, EventArgs e)
        {
            String result = null;
            Resultbox.Text = "";
            foreach (Control control in this.groupBox_trans.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        switch (radio.Name)
                        {
                            case "rb_trans_tranwithId":
                                try
                                {
                                    result = TransactionService.TransactionWithTransactionId(URLBox.Text);
                                    SetResultBox("Transaction with trans id result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Transaction Service transaction with trans id get exception: " + ex.Message);
                                    SetResultBox("transaction with trans idget exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_tran":
                                try
                                {
                                    result = TransactionService.Transaction(URLBox.Text);
                                    SetResultBox("Transaction result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Service transaction get exception: " + ex.Message);
                                    SetResultBox("Transaction get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_Match4FDR":
                                try
                                {
                                    result = TransactionService.MatchingTransactionForFDRChargeback(URLBox.Text);
                                    SetResultBox("Matching Transaction For FDR Chargeback result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Matching Transaction For FDR Chargeback get exception: " + ex.Message);
                                    SetResultBox("Matching Transaction For FDR Chargeback get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_transcount":
                                try
                                {
                                    result = TransactionService.TransactionCount(URLBox.Text);
                                    SetResultBox("Transaction Count result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Transaction Count get exception: " + ex.Message);
                                    SetResultBox("Transaction Count get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_dailysum":
                                try
                                {
                                    result = TransactionService.DailyTransactionsSummary(URLBox.Text);
                                    SetResultBox("Daily Transaction Summary result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Daily Transaction Summary get exception: " + ex.Message);
                                    SetResultBox("Daily Transaction Summary get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_refundtran":
                                try
                                {
                                    result = TransactionService.RefundTransaction(URLBox.Text,PostDataBox.Text);
                                    SetResultBox("Refund Transaction result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Refund Transaction get exception: " + ex.Message);
                                    SetResultBox("Refund Transaction get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_transtotal":
                                try
                                {
                                    TransactionService.TransactionsTotal(URLBox.Text);
                                    SetResultBox("Transaction Total result:");
                                    SetResultBox(result, true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Transaction Total get exception: " + ex.Message);
                                    SetResultBox("Transaction Total get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_paymenttypes":
                                try
                                {
                                    result = TransactionService.PaymentTypes(URLBox.Text);
                                    SetResultBox("Payment Types result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Types get exception: " + ex.Message);
                                    SetResultBox("Payment Types get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_bulkvoid":
                                try
                                {
                                    result = TransactionService.BulkVoid(URLBox.Text, PostDataBox.Text);
                                    SetResultBox("Bulk Void result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Bulk Void get exception: " + ex.Message);
                                    SetResultBox("Bulk Void get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_searchtrans":
                                try
                                {
                                    result = TransactionService.SearchTransactions(URLBox.Text);
                                    SetResultBox("Search Transaction result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Search Transaction get exception: " + ex.Message);
                                    SetResultBox("Search Transaction get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_bulkcapture":
                                try
                                {
                                    result = TransactionService.BulkCapture(URLBox.Text, PostDataBox.Text);
                                    SetResultBox("Bulk Capture result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Bulk Capture get exception: " + ex.Message);
                                    SetResultBox("Bulk Capture get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_trans":
                                try
                                {
                                    result = TransactionService.Transactions();
                                    SetResultBox("Transactions result:");
                                    SetResultBox(format_json(result), true);
                                    ResponseParse.SearchTransResponse(this, result);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Transactions get exception: " + ex.Message);
                                    SetResultBox("Transactions get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_capturetrans":
                                try
                                {
                                    result = TransactionService.CaptureTransaction(URLBox.Text, PostDataBox.Text);
                                    SetResultBox("Capture Transaction result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Capture Transaction get exception: " + ex.Message);
                                    SetResultBox("Capture Transaction get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_voidtrans":
                                try
                                {
                                    result = TransactionService.VoidTransaction(URLBox.Text, PostDataBox.Text);
                                    SetResultBox("Void Transaction result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Service void transaction get exception: " + ex.Message);
                                    SetResultBox("Void Transaction get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                            case "rb_trans_summary":
                                try
                                {
                                    result = TransactionService.TransactionSummary(URLBox.Text);
                                    SetResultBox("Transaction Summary result:");
                                    SetResultBox(format_json(result), true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Payment Service Transaction Summary get exception: " + ex.Message);
                                    SetResultBox("Transaction Summary get exception:");
                                    SetResultBox(ex.Message, true);
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void rb_trans_tranwithId_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_tranwithId.Checked)
            {
                PostDataBox.Text = "";
                URLBox.Text = "";
                if (this.TransFromNexioList.Rows.Count > 0)
                {
                    
                    Boolean found = false;
                    int row = 0;

                    for (int i = 0; i < this.TransFromNexioList.Rows.Count; i++)
                    {
                        if (TransFromNexioList[0, i].Value.ToString().ToUpper().Equals("TRUE"))
                        {
                            found = true;
                            row = i;

                            break;
                        }
                    }

                    if (found)
                    {
                        urldata = ConfigItems.API_URL + "/transaction/v3/" + TransFromNexioList[1, row].Value.ToString();
                        
                        URLBox.Text = urldata;
                    }
                    else
                    {
                        MessageBox.Show("Please select one transaction!");
                        rb_trans_tranwithId.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("There's no valid trans in Nexio Trans List, please do transactions first!");
                    rb_trans_tranwithId.Checked = false;
                }
            }
        }

        private void rb_trans_tran_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_tran.Checked)
            {
                PostDataBox.Text = "";
                URLBox.Text = "";
                if (this.TransFromNexioList.Rows.Count > 0)
                {

                    Boolean found = false;
                    int row = 0;

                    for (int i = 0; i < this.TransFromNexioList.Rows.Count; i++)
                    {
                        if (TransFromNexioList[0, i].Value.ToString().ToUpper().Equals("TRUE"))
                        {
                            found = true;
                            row = i;

                            break;
                        }
                    }

                    if (found)
                    {
                        urldata =  ConfigItems.API_URL + "/transaction/v3?plugin.originalId=" + TransFromNexioList[1, row].Value.ToString();
                        
                        URLBox.Text = urldata;
                    }
                    else
                    {
                        MessageBox.Show("Please select one transaction!");
                        rb_trans_tran.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("There's no valid trans in Nexio Trans List, please do transactions first!");
                    rb_trans_tran.Checked = false;
                }
            }
        }

        private void rb_trans_Match4FDR_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_Match4FDR.Checked)
            {
                String authcode = "230194";
                String transdate = "27/11/2018";
                String cardNum = "1234";

                urldata = ConfigItems.API_URL + "/transaction/v3/getMatchingTransactionForFDRChargeback?authCode=" + authcode + "&transactionDate=" + transdate + "&cardNumber=" + cardNum;
                URLBox.Text = urldata;
                PostDataBox.Text = "";
            }
        }

        private void rb_trans_transcount_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_transcount.Checked)
            {
                urldata = ConfigItems.API_URL + "/transaction/v3/count";
                URLBox.Text = urldata;
                PostDataBox.Text = "";
            }
        }

        private void rb_trans_dailysum_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_dailysum.Checked)
            {
                urldata = ConfigItems.API_URL + "/transaction/v3/dailyTransactionsSummary";
                URLBox.Text = urldata;
                PostDataBox.Text = "";
            }
            
        }

        private void rb_trans_refundtran_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_trans_refundtran.Checked)
            {
                PostDataBox.Text = "";
                String urldata = ConfigItems.API_URL + "/transaction/v3/refund";
                URLBox.Text = urldata;
                if (this.TransFromNexioList.Rows.Count > 0)
                {

                    Boolean found = false;
                    int row = 0;

                    for (int i = 0; i < this.TransFromNexioList.Rows.Count; i++)
                    {
                        if (TransFromNexioList[0, i].Value.ToString().ToUpper().Equals("TRUE"))
                        {
                            found = true;
                            row = i;

                            break;
                        }
                    }

                    if (found)
                    {
                        

                        //postdata
                        String postData = "{\"amount\": " + TransFromNexioList[2, row].Value.ToString() + ", \"id\":\"" + TransFromNexioList[1, row].Value.ToString() + "\"}";

                        PostDataBox.Text = format_json(postData);
                    }
                    else
                    {
                        MessageBox.Show("Please select one transaction!");
                        rb_trans_refundtran.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("There's no valid trans in Nexio Trans List, please card or eCheck trans first!");
                    rb_trans_refundtran.Checked = false;
                }
                
            }
        }

        private void rb_trans_transtotal_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_transtotal.Checked)
            {
                urldata = ConfigItems.API_URL + "/transaction/v3/total?merchantIds=" + ConfigItems.Merchantid;
                URLBox.Text = urldata;
                PostDataBox.Text = "";
            }
            
        }

        private void rb_trans_paymenttypes_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_paymenttypes.Checked)
            {
                urldata = ConfigItems.API_URL + "/transaction/v3/paymentTypes";
                URLBox.Text = urldata;
                PostDataBox.Text = "";
            }
            
        }

        private void rb_trans_bulkvoid_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_bulkvoid.Checked)
            {
                PostDataBox.Text = "";
                urldata = ConfigItems.API_URL + "/transaction/v3/void/bulk";
                URLBox.Text = urldata;
                if (this.TransFromNexioList.Rows.Count > 0)
                {

                    Boolean found = false;
                    
                    String postdata = "{\"transactionIds\":[\"";

                    for (int i = 0; i < this.TransFromNexioList.Rows.Count; i++)
                    {
                        if (TransFromNexioList[0, i].Value.ToString().ToUpper().Equals("TRUE"))
                        {
                            
                            postdata = postdata + TransFromNexioList[1, i].Value.ToString() + "\",";

                            found = true;

                        }
                    }

                    if (found)
                    {
                        

                        //process the result
                        String result = postdata.Substring(0, postdata.Length - 1);
                        postdata = result +  "]}";

                        PostDataBox.Text = postdata;
                    }
                    else
                    {
                        MessageBox.Show("Please select at least one transaction!");
                        rb_trans_bulkvoid.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("There's no valid trans in Nexio Trans List, please do transactions first!");
                    rb_trans_bulkvoid.Checked = false;
                }
            }
        }

        private void rb_trans_searchtrans_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_searchtrans.Checked)
            {
                urldata = ConfigItems.API_URL + "/transaction/v3/search";
                URLBox.Text = urldata;
                PostDataBox.Text = "";
            }
            
        }

        private void rb_trans_bulkcapture_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;

            if (rb_trans_bulkcapture.Checked)
            {
                PostDataBox.Text = "";
                urldata = ConfigItems.API_URL + "/transaction/v3/capture/bulk";
                URLBox.Text = urldata;
                if (this.TransFromNexioList.Rows.Count > 0)
                {

                    Boolean found = false;

                    String postdata = "{\"transactionIds\":[\"";

                    for (int i = 0; i < this.TransFromNexioList.Rows.Count; i++)
                    {
                        if (TransFromNexioList[0, i].Value.ToString().ToUpper().Equals("TRUE"))
                        {

                            postdata = postdata + TransFromNexioList[1, i].Value.ToString() + "\",";

                            found = true;

                        }
                    }

                    if (found)
                    {
                        

                        //process the result
                        String result = postdata.Substring(0, postdata.Length - 1);
                        postdata = result + "]}";

                        PostDataBox.Text = postdata;
                    }
                    else
                    {
                        MessageBox.Show("Please select at least one transaction!");
                        rb_trans_bulkcapture.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("There's no valid trans in Nexio Trans List, please do transactions first!");
                    rb_trans_bulkcapture.Checked = false;
                }
            }
        }

        private void rb_trans_trans_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_trans.Checked)
            {
                urldata = ConfigItems.API_URL + "/transaction/v3";
                URLBox.Text = urldata;
                PostDataBox.Text = "";
            }
            
        }

        private void rb_trans_capturetrans_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_trans_capturetrans.Checked)
            {
                PostDataBox.Text = "";

                String urldata = ConfigItems.API_URL + "/transaction/v3/capture";
                URLBox.Text = urldata;
                if (this.TransFromNexioList.Rows.Count > 0)
                {

                    Boolean found = false;
                    int row = 0;

                    for (int i = 0; i < this.TransFromNexioList.Rows.Count; i++)
                    {
                        if (TransFromNexioList[0, i].Value.ToString().ToUpper().Equals("TRUE"))
                        {
                            found = true;
                            row = i;

                            break;
                        }
                    }

                    if (found)
                    {

                        //postdata
                        String postData = "{\"id\":\"" + TransFromNexioList[1, row].Value.ToString() + "\"}";

                        PostDataBox.Text = format_json(postData);
                    }
                    else
                    {
                        MessageBox.Show("Please select one transaction!");
                        rb_trans_capturetrans.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("There's no valid trans in Nexio Trans List, please card or eCheck trans first!");
                    rb_trans_capturetrans.Checked = false;
                }

            }
        }

        private void rb_trans_voidtrans_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_trans_voidtrans.Checked)
            {
                PostDataBox.Text = "";
                String urldata = ConfigItems.API_URL + "/transaction/v3/void";
                URLBox.Text = urldata;
                if (this.TransFromNexioList.Rows.Count > 0)
                {

                    Boolean found = false;
                    int row = 0;

                    for (int i = 0; i < this.TransFromNexioList.Rows.Count; i++)
                    {
                        if (TransFromNexioList[0, i].Value.ToString().ToUpper().Equals("TRUE"))
                        {
                            found = true;
                            row = i;

                            break;
                        }
                    }

                    if (found)
                    {
                        //postdata
                        String postData = "{\"id\":\"" + TransFromNexioList[1, row].Value.ToString() + "\"}";

                        PostDataBox.Text = format_json(postData);
                    }
                    else
                    {
                        MessageBox.Show("Please select one transaction!");
                        rb_trans_voidtrans.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("There's no valid trans in Nexio Trans List, please card or eCheck trans first!");
                    rb_trans_voidtrans.Checked = false;
                }

            }
        }

        private void rb_trans_summary_CheckedChanged(object sender, EventArgs e)
        {
            String urldata = null;
            if (rb_trans_summary.Checked)
            {
                urldata = ConfigItems.API_URL + "/transaction/v3/transactionsSummary";
                URLBox.Text = urldata;
                PostDataBox.Text = "";
            }
            
        }



        private string format_json(string json)
        {
            dynamic parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }

        
    }


}
