using App.DAL.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace App.PL.Helpers
{
	public static class EmailSettings
	{

		public static void SendEmail(this Email email)
		{
			var mail = new MimeMessage()
			{
				Sender = MailboxAddress.Parse("aamr24987@gmail.com"),
				Subject = email.Subject
			};

			mail.To.Add(MailboxAddress.Parse(email.To));
			mail.From.Add(MailboxAddress.Parse("aamr24987@gmail.com"));

			var builder = new BodyBuilder();
			builder.TextBody = email.Body;

			mail.Body = builder.ToMessageBody();


			using var smtp = new SmtpClient();
			smtp.Connect("smtp.gmail.com",587, SecureSocketOptions.StartTls);
			smtp.Authenticate("aamr24987@gmail.com", "lpma lvvz dexl fxek");
			smtp.Send(mail);
			smtp.Disconnect(true);
		}
	}
}
