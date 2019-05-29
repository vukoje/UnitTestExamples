using System;
using NUnit.Framework;

namespace UnitTestExamples.Stub.Tests
{
	public class UserTest
	{
		[Test]
		public void SendMessageHardcodedStubTest()
		{
			MailManagerHardcodedStub stub = new MailManagerHardcodedStub();
			User receiver = new User("Mika", "mika@example.com", stub);

            Assert.Throws<InvalidOperationException>(
                () => receiver.SendMessage("Hello!"),
                "InvalidOperationException shuld be thrown if mail sending didn't succeed.");
		}

		[Test]
		public void SendMessageConfigurableStubTest()
		{
			MailManagerConfigurableStub stub = new MailManagerConfigurableStub();
			stub.Result = false;
			User receiver = new User("Mika", "mika@example.com", stub);

            Assert.Throws<InvalidOperationException>(
                () => receiver.SendMessage("Hello!"),
                "InvalidOperationException shuld be thrown if mail sending didn't succeed.");
        }

		[Test]
		public void SendMessageConfigurableStubAdvancedTest()
		{
			MailManagerConfigurableStubAdvanced stub = new MailManagerConfigurableStubAdvanced();
			stub.SendEmailHandler = delegate(Email mail)
			{
				// add logic here if needed
				return false;
			};

			User receiver = new User("Mika", "mika@example.com", stub);

            Assert.Throws<InvalidOperationException>(
                () => receiver.SendMessage("Hello!"),
                "InvalidOperationException shuld be thrown if mail sending didn't succeed.");
        }
	}
}
