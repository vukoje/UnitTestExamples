
namespace UnitTestExamples
{
	public class Counter
	{
		public int Number { get; private set; }

		public void Increase()
		{
			this.Number++;
		}

		public void Decrease()
		{
			this.Number--;
		}

		public void Reset()
		{
			this.Number = 0;
		}
	}
}
