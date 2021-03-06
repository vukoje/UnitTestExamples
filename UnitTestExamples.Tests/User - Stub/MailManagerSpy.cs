﻿using System.Collections.ObjectModel;

namespace UnitTestExamples.Stub.Tests
{
    public class MailManagerSpy : IMailManager
	{
		public Collection<Email> SentLog { get; set; }

		public MailManagerSpy()
		{
			this.SentLog = new Collection<Email>();
		}

		public bool SendEmail(Email email)
		{
			this.SentLog.Add(email);
			return true;
		}
	}
}
