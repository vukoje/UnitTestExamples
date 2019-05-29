using System.Collections.ObjectModel;
using UnitTestExamples;

namespace UnitTestExamples.Stub.Tests
{
	public class MailManagerHardcodedStub : IMailManager
	{
		public bool SendEmail(Email email)
		{
			return false;
		}
	}
}
