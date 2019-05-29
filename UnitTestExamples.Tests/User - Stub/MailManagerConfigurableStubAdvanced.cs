using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestExamples.Stub.Tests
{
	public class MailManagerConfigurableStubAdvanced : IMailManager
	{
		public Func<Email, bool> SendEmailHandler { get; set; }

		public bool SendEmail(Email email)
		{
			return this.SendEmailHandler.Invoke(email);
		}

	}
}
