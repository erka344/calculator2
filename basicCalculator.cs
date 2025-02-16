using System;
using calculator;
using operation;

namespace basicCalculator
{
	public class BasicCalculator : Calculator1, Operation
	{
		public void add(double n)
		{
			result += n;
		}
        public void minus(double m)
        {
            result -= m;
        }
    }
}

