using System;
using Calculator;

namespace memory
{
	public class Memory
	{
        private List<MemoryItem> memoryItems = new List<MemoryItem>();

        public void Store(double value)
        {
            memoryItems.Add(new MemoryItem(value));
        }

        public double RecallLast()
        {
            return memoryItems.Count > 0 ? memoryItems[^1].Value : 0;
        }

    }
}

