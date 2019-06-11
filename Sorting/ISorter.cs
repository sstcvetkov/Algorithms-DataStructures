using System;
using System.Collections.Generic;

namespace Sorting
{
	public interface ISorter<T>
		where T: IComparable<T>
	{
		void Sort(IList<T> source, IComparer<T> comparer = null);
		void Sort(T[] source, IComparer<T> comparer = null);
	}
}
