using System;

namespace UnitTestExamples.Stub
{
	public class User
	{
		public string Name { get; private set; }

		public string MailAddress { get; private set; }

		private IMailManager MailManager { get; set; }

		public User(string name, string mailAddress)
			: this(name, mailAddress, new MailManager())
		{
		}

		public User(string name, string mailAddress, IMailManager mailManager)
		{
			this.Name = name;
			this.MailAddress = mailAddress;
			this.MailManager = mailManager;
		}

		public void SendMessage(string message)
		{
			Email email = new Email();
			email.ToEmailAddress = this.MailAddress;
			email.Message = message;

			bool succeed = this.MailManager.SendEmail(email);
			if (!succeed)
			{
				throw new InvalidOperationException("Email sending failed!");
			}
		}
	}
}
