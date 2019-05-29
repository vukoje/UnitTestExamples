using System;

namespace UnitTestExamples.Basic
{
	public class AdvancedCounter
	{
		public int Number { get; private set; }

		public event Action NumberChanged;

		public void Increase()
		{
			this.Number++;
			this.OnNumberChanged();
		}

		public void Decrease()
		{
			if (this.Number == 0)
			{
				throw new InvalidOperationException();
			}

			this.Number--;
			this.OnNumberChanged();
		}

		public void Reset()
		{
			this.Number = 0;
		}

		public override bool Equals(object obj)
		{
			AdvancedCounter counter = obj as AdvancedCounter;
			if (counter != null
				&& counter.Number == this.Number)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public override int GetHashCode()
		{
			return this.Number;
		}

		protected virtual void OnNumberChanged()
		{
			Action action = this.NumberChanged;
			if (action != null)
			{
				action();
			}
		}
	}
}
