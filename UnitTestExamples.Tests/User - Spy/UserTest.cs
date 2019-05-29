using NUnit.Framework;
using UnitTestExamples.Spy;

namespace UnitTestExamples.Spy.Tests
{
	public class UserTest
	{
		[Test]
		public void SendMessageTest()
		{
			MailManagerSpy spy = new MailManagerSpy();
			User receiver = new User("Mika", "mika@example.com", spy);
			receiver.SendMessage("Hello!");

			Assert.AreEqual(1, spy.SentLog.Count);
			Assert.AreEqual("Hello!", spy.SentLog[0].Message);
			Assert.AreEqual("mika@example.com", spy.SentLog[0].ToEmailAddress);
		}
	}
}
