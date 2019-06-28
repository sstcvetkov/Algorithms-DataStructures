using System;
using System.Collections.Generic;
using System.Diagnostics;
using Diagnostics = System.Diagnostics.Debug;

namespace Sorting
{
	public abstract class SorterBase<T> : ISorter<T>
		where T : IComparable<T>
	{
		public void Sort(T[] collection, IComparer<T> comparer = null)
			=> Sort((IList<T>) collection, comparer);

		public void Sort(IList<T> collection, IComparer<T> comparer = null)
		{
			Diagnostics.WriteLine(
				$"{nameof(SorterBase<T>)}, collection: " + GetString(collection));

			Implementation(collection, comparer);

			Diagnostics.WriteLine("Result: " + GetString(collection));
		}

		protected abstract void Implementation(IList<T> d, IComparer<T> comparer = null);

		[Conditional("DEBUG")]
		protected void Debug(IList<T> collection)
		{
			Diagnostics.WriteLine($"Result: " + GetString(collection));
		}

		private static string GetString(IEnumerable<T> collection)
		{
			return string.Join(",", collection);
		}
	}
}
