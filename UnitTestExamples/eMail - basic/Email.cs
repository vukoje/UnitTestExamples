using System.Collections.Specialized;

namespace UnitTestExamples
{
	/// <summary>
	/// Email class
	/// </summary>
	public class Email
	{
		#region Construcotrs

		/// <summary>
		/// Initializes a new instance of the <see cref="Email"/> class.
		/// </summary>
		public Email()
		{
			this.Attachments = new ListDictionary();
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets from.
		/// </summary>
		public string From { get; set; }

		/// <summary>
		/// Gets or sets to email address.
		/// </summary>
		public string ToEmailAddress { get; set; }

		/// <summary>
		/// Gets or sets the cc.
		/// </summary>
		public string CC { get; set; }

		/// <summary>
		/// Gets or sets the BCC.
		/// </summary>
		public string Bcc { get; set; }

		/// <summary>
		/// Gets or sets the subject.
		/// </summary>
		public string Subject { get; set; }

		/// <summary>
		/// Gets or sets the message.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Gets the attachments.
		/// </summary>
		public ListDictionary Attachments { get; private set; }

		#endregion
	}
}
