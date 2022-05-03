using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace SNR.Utilities;

public static class MailHelper
{
    public static void Send(string from, string to, string password, string fromFullName, string subject, bool isBodyHtml, string body, int port, string host, bool enableSsl)
    {
        MailMessage Mail = new MailMessage();
        Mail.From = new MailAddress(from, fromFullName);
        Mail.To.Add(to);

        Mail.Subject = subject;
        Mail.IsBodyHtml = isBodyHtml;
        Mail.Body = body;

        SmtpClient smpt = new SmtpClient();
        smpt.Port = port;
        smpt.Host = host;
        smpt.EnableSsl = enableSsl;
        smpt.DeliveryMethod = SmtpDeliveryMethod.Network;
        smpt.UseDefaultCredentials = false;
        smpt.Credentials = new NetworkCredential(from, password);

#pragma warning disable CS8622
        ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
#pragma warning restore CS8622

        smpt.Send(Mail);
    }
}