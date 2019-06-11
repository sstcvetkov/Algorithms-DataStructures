using System.Collections;
using System.Collections.Generic;

namespace Common
{
	public class ComparerInverted<T> : IComparer<T>
	{
		private readonly IComparer _comparer;

		public ComparerInverted(IComparer comparer)
		{
			_comparer = comparer;
		}

		public int Compare(T x, T y)
		{
			return -_comparer.Compare(x, y);
		}
	}
}
