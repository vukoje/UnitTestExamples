using System;

namespace UnitTestExamples.NotTestable
{
	public class User
	{
		public string Name { get; private set; }

		public string MailAddress { get; private set; }

		private MailManager MailManager { get; set; }

		public User(string name, string mailAddress)
		{
			this.Name = name;
			this.MailAddress = mailAddress;
			this.MailManager = new MailManager();
		}

		public void SendMessage(string message)
		{
			Email email = new Email();
			email.ToEmailAddress = this.MailAddress;
			email.Message = message;

			bool succeeed = this.MailManager.SendEmail(email);
			if (!succeeed)
			{
				throw new InvalidOperationException("Mail sending faled.");
			}
		}
	}
}
