using System.Collections.Generic;
using System.Linq;
using Common;
using Xunit;
using Xunit.Abstractions;

namespace Sorting.Tests
{
	public abstract class TestBase
	{
		private readonly ITestOutputHelper _outputHelper;

		public TestBase(ITestOutputHelper outputHelper)
		{
			_outputHelper = outputHelper;
		}

		protected void TestSort(IList<int> input, IEnumerable<int> expected, ISorter<int> sorter, IComparer<int> comparer)
		{
			_outputHelper.WriteLine($"Input:\t{string.Join(",", input)}.");
			_outputHelper.WriteLine($"Sorted:\t{sorter.GetType().Name}.");
			_outputHelper.WriteLine($"Expected:\t{string.Join(",", input)}.");

			sorter.Sort(input, comparer);

			Assert.Equal(expected, input);
		}

		protected void TestSortAscending(
			IList<int> source, ISorter<int> sorter, IComparer<int> comparer = null)
		{
			comparer ??= Comparer<int>.Default;
			TestSort(source, source.OrderBy(x => x), sorter, comparer);
		}

		protected void TestSortDescending(IList<int> source, ISorter<int> sorter, IComparer<int> comparer = null)
		{
			comparer ??= new ComparerInverted<int>(Comparer<int>.Default);
			TestSort(source, source.OrderByDescending(x => x), sorter, comparer);
		}
	}
}