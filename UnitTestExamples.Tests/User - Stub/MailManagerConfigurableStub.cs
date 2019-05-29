
using UnitTestExamples;

namespace UnitTestExamples.Stub.Tests
{
	public class MailManagerConfigurableStub : IMailManager
	{
		public bool Result { get; set; }

		public bool SendEmail(Email email)
		{
			return this.Result;
		}
	}
}
