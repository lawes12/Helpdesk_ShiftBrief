using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace Helpdesk_ShiftBrief
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient cv = new SmtpClient("mail.greathealthworks.com", 587);
            cv.EnableSsl = true;
            cv.Credentials = new NetworkCredential("ad_User", "password");
            try
            {
                cv.Send("sender email", "reciever email", "subject", "email");
                Console.WriteLine("Email sent sucessfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine("email can't be sent sucessfully under bellow reason ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}