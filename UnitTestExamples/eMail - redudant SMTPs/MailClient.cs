
namespace UnitTestExamples.RedudantSMTP
{
	public class MailClient
	{
		public MailClient()
        {
            this.MailManager = new MailManager();
        }
       
        internal MailManager MailManager { get; set; }

		public bool SendEmail(Email email)
		{
			bool emailSent = false;

			// sending email with first host
			if (!string.IsNullOrEmpty(AppProperties.MailHost1))
			{
				emailSent = this.SendEmail(email, AppProperties.MailHost1, AppProperties.MailLogOnName1, AppProperties.MailLogOnPassword1, AppProperties.MailPort1, AppProperties.MailTimeout1);
			}

			// sending email with second host if previous send was unsucessful
			if (!emailSent && !string.IsNullOrEmpty(AppProperties.MailHost2))
			{
				emailSent = this.SendEmail(email, AppProperties.MailHost2, AppProperties.MailLogOnName2, AppProperties.MailLogOnPassword2, AppProperties.MailPort2, AppProperties.MailTimeout2);
			}

			// sending email with third host if previous send was unsucessful
			if (!emailSent && !string.IsNullOrEmpty(AppProperties.MailHost3))
			{
				emailSent = this.SendEmail(email, AppProperties.MailHost3, AppProperties.MailLogOnName3, AppProperties.MailLogOnPassword3, AppProperties.MailPort3, AppProperties.MailTimeout3);
			}

			return emailSent;
		}

		private bool SendEmail(Email email, string host, string userName, string password, int port, int connectionTimeOut)
		{
			this.MailManager.SmtpHost = host;
			this.MailManager.SmtpUserName = userName;
			this.MailManager.SmtpPassword = password;
			this.MailManager.ConnectionTimeout = connectionTimeOut;
			this.MailManager.SmtpPort = port;

			return this.MailManager.SendEmail(email);
		}
	}
}
