using System.Net;
using System.Net.Mail;

namespace MailNotification
{
    public class MailDeliveri
    {
         public static void NotifyNewAdmin(string login, string password, string email)
        {
            MailAddress From = new MailAddress("abtsportsline@outlook.com", "ABT");
            MailAddress To = new MailAddress(email);
            MailMessage msg = new MailMessage(From, To);
            msg.Subject = "Доступ до БД клієнтів";
            msg.Body = $"Вам було надано доступ до Бази Даних клієнтів СТО😃. Ваш дані для входу Логін: {login}  Пароль: {password}";
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
            smtp.Credentials = new NetworkCredential("abtsportsline@outlook.com", "23851238afkj");
            smtp.EnableSsl = true;
           smtp.Send(msg);
        }
    }
}
