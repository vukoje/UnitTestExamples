
namespace UnitTestExamples.RedudantSMTP
{
	public class MailManager : IMailManager
	{
		#region Properties

		/// <summary>
		/// Gets or sets the SMTP host.
		/// </summary>
		/// <value>The SMTP host.</value>
		public string SmtpHost { get; set; }

		/// <summary>
		/// Gets or sets the SMTP user name.
		/// </summary>
		/// <value>The the SMTP user name.</value>
		public string SmtpUserName { get; set; }

		/// <summary>
		/// Gets or sets the SMTP password.
		/// </summary>
		/// <value>The SMTP password.</value>
		public string SmtpPassword { get; set; }

		/// <summary>
		/// Gets or sets the SMTP port.
		/// </summary>
		/// <value>The SMTP port.</value>
		public int SmtpPort { get; set; }

		/// <summary>
		/// Gets or sets the connection timeout.
		/// </summary>
		/// <value>The connection timeout.</value>
		public int ConnectionTimeout { get; set; }

		#endregion

		#region Public methods

		/// <summary>
		/// Sends the email.
		/// </summary>
		/// <param name="email">The email message to be send.</param>
		/// <returns>True if sending was successfull</returns>
		public bool SendEmail(Email email)
		{
			// logic for sending mail
			// ...

			return true;
		}

		#endregion
	}
}
