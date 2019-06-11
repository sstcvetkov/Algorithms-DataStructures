using System;
using System.Collections.Generic;
using System.Diagnostics;
using Common;

namespace Sorting
{
	public class InsertionSorter<T> : ISorter<T>
		where T : IComparable<T>
	{
		public void Sort(T[] source, IComparer<T> comparer = null)
			=> Sort((IList<T>) source, comparer);

		public void Sort(IList<T> source, IComparer<T> comparer = null)
		{
			Debug.Write($"{nameof(InsertionSorter<T>)}, source:\n" +
			            string.Join(",", source));

			for (var index = 1; index < source.Count; index++)
			{
				var v = source[index];
				var subIndex = index - 1;

				while (subIndex >= 0 && source[subIndex].IsGreaterThan(v, comparer))
				{
					source[subIndex + 1] = source[subIndex];
					subIndex--;

					Debug.WriteLine(string.Join(",", source));
				}

				source[subIndex + 1] = v;

				Debug.WriteLine(string.Join(",", source));
			}
		}
	}
}
