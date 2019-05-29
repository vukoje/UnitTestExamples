using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestExamples
{
	public interface IMailManager
	{
		bool SendEmail(Email email);
	}
}
