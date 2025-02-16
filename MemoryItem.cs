using System;
namespace Calculator
{
	public class MemoryItem
	{
		public MemoryItem()
		{

		}
        public double Value { get; set; }

        public MemoryItem(double value)
        {
            Value = value;
        }
    }
}

