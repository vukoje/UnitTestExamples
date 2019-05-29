using NUnit.Framework;

namespace UnitTestExamples.NotTestable.Tests
{
    public class UserTest
	{
		[Test]
		public void SendMessageTest()
		{
			User user = new User("Mika", "Mika@example.com");
			user.SendMessage("Hello!");

			// Aaaaaand it's gone! :)
			// now what?
		}
	}
}
