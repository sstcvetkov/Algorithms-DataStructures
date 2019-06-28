using System.Collections.Generic;

namespace Common
{
	public class ComparerInverted<T> : IComparer<T>
	{
		private readonly IComparer<T> _comparer;

		public ComparerInverted(IComparer<T> comparer)
		{
			_comparer = comparer;
		}

		public int Compare(T x, T y)
		{
			return -_comparer.Compare(x, y);
		}
	}
}
