using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SMS.SmsService;

namespace SMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string message = "";
            string[] Payam = new string[1];
            Payam[0] = "سلام من مرضیه کریمی هستم";
            long[] number = new long[1];
            number[0] = 09362445840;
            SendReceive sms = new SendReceive();
            long numb= sms.SendSingleMessage("9335243570", "Amirhosein1201", Payam[0], "09362445840", "30007732908981", ref message);
            //long[] numb= sms.SendMessageWithLineNumber("9335243570", "Amirhosein1201", number, Payam, "30007732908981", DateTime.Now, ref message);

            MessageBox.Show(numb.ToString());

           // string data=(sms.GetSMSLines("9335243570", "Amirhosein1201", ref message)[0].LineNumber.ToString());
            //MessageBox.Show(data);

            /*    SmsIr smsIr = new SmsIr("nyJQUoYXZejTvu5fZc8Vq3uqV4JQDMtnFvOLxhC7Ylckcz8s0iexPr0M4faXxQQx");
                  var bulkSendResult = await smsIr.BulkSendAsync
                  (95007079000006, "Hello World!",
                      new string[] { "9335243570" });
                  var verificationSendResult = await smsIr.VerifySendAsync
                      ("9335243570", 100000,
                  new VerifySendParameter[] { new("Code", "12345") });

            
            
           /*
                  try
                  {
                      smsService.SendReceive sms = new smsService.SendReceive();
                      string mesage = "";//username:9335243570  pass:Amirhosein1201
                      smsService.SMSLineNumber[] lines = sms.GetSMSLines(txt_UserName.Text.Trim(), txt_Password.Text.Trim(), ref mesage);
                      DataGrid_ID.ItemsSource = lines;
                  }
                  catch (Exception E)
                  {

                      MessageBox.Show(E.Message);
                  }*/

        }

        private void btn_Send_Click(object sender, RoutedEventArgs e)
        {/*
            try
            {
                int smsLineID = 0;
                List<SmsService.WebServiceSmsSend> sendDetails = new List<SmsService.WebServiceSmsSend>();

                {
                    string messageBody = string.Empty;
                    long mobileNo = 0;
                    bool isFlash = false;

                    //////////متن پ?ام و شماره تماس گ?رنده
                    messageBody = txt_Message.Text.Trim();
                    mobileNo = Convert.ToInt64(txt_TellUsers.Text.Trim());
                    isFlash = false;

                    //SmsService.SendReceive sms = new SmsService.SendReceive();
                    //string mesage = "";
                    //SmsService.SMSLineNumber[] lines = sms.GetSMSLines(txt_UserName.Text.Trim(), txt_Password.Text.Trim(), ref mesage);
                    //MessageBox.Show(lines.Count().ToString());
                    //txt_ID.Text = lines[0].ID.ToString();




                    sendDetails.Add(new SmsService.WebServiceSmsSend()
                    {
                        IsFlash = isFlash,
                        MessageBody = messageBody,
                        MobileNo = mobileNo
                    });
                }

                SmsService.SendReceive ws = new SmsService.SendReceive();
                MessageBox.Show(ws.Url);

                ////////چک کردن آ? د? خط
                if (!int.TryParse(txt_ID.Text, out smsLineID)) throw new Exception("شماره آ? د? خط اشتباه است");


                string message = string.Empty;


                ////////ارسال اطلاعات به وب سرو?س
                long[] result = ws.SendMessage(txt_UserName.Text.Trim(), txt_Password.Text.Trim(), sendDetails.ToArray(), smsLineID, null, ref message);
                if (!string.IsNullOrWhiteSpace(message))
                    throw new Exception(message);

                StringBuilder sbResult = new StringBuilder();
                foreach (long current in result)
                    sbResult.Append(current + ",");
            }
            catch (Exception ex)
            {
                MessageBox.Show("در ارسال پ?ام مشکل? بوجود آمده است");
            }
        */
        }
    }
}
