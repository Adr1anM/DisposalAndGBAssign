using System.Net.Mail;
using System.Net;

Console.WriteLine("Welcome to the Email Notification Application!");
Console.WriteLine("Please enter your email address:");
string emailAddress = Console.ReadLine();


SendEmail(emailAddress);

Console.WriteLine("Thank you! An email has been sent to your provided email address.");


static void SendEmail(string toAddress)
{

    string fromMail = "andrian.melnic2003@gmail.com";
    string fromPassword = "fjiq zjsg bscm qmsn";

   
    
    using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
    {

        smtpClient.Port = 587; // Update with the appropriate port
        smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
        smtpClient.EnableSsl = true;

        MailMessage mailMessage = new MailMessage();
        mailMessage.From = new MailAddress(fromMail);
        mailMessage.To.Add(toAddress);
        mailMessage.Subject = "Thank You for Subscribing!";
        mailMessage.Body = "Dear Subscriber, \n\nThank you for subscribing to our newsletter!";
        mailMessage.IsBodyHtml = false;

        smtpClient.Send(mailMessage);

    }
    
}