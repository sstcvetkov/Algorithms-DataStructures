using System;
using System.Collections.Generic;
using Common;

namespace Sorting
{
	public class InsertionSorter<T> : SorterBase<T>
		where T : IComparable<T>
	{
		protected override void Implementation(IList<T> collection, IComparer<T> comparer = null)
		{
			Classic(collection, comparer);
			//TwoForCircles(collection, comparer);
		}

		private void Classic(IList<T> collection, IComparer<T> comparer = null)
		{
			for (var i = 1; i < collection.Count; i++)
			{
				var value = collection[i];
				var j = i - 1;
				while (j >= 0 && collection[j].IsGreaterThan(value, comparer))
				{
					collection[j + 1] = collection[j];
					j--;
					Debug(collection);
				}

				collection[j + 1] = value;
				Debug(collection);
			}
		}

		private void TwoForCircles(IList<T> collection, IComparer<T> comparer = null)
		{
			for (var i = 1; i < collection.Count; i++)
			{
				var value = collection[i];
				var j = i - 1;
				for (;j >= 0 && collection[j].IsGreaterThan(value, comparer); j--)
				{
					collection[j+1] = collection[j];
					Debug(collection);
				}

				collection[j+1] = value;
				Debug(collection);
			}
		}
	}
}
