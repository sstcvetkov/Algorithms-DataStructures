using System;
using System.Collections.Generic;

namespace Sorting
{
	public interface ISorter<T>
		where T: IComparable<T>
	{
		void Sort(IList<T> collection, IComparer<T> comparer = null);
		void Sort(T[] collection, IComparer<T> comparer = null);
	}
}
