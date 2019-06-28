using System.Collections.Generic;
using System.Linq;
using Common;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace Sorting.Tests
{
	public abstract class TestBase
	{
		private readonly ITestOutputHelper _outputHelper;

		protected TestBase(ITestOutputHelper outputHelper)
		{
			_outputHelper = outputHelper;
		}

		protected void TestSort(IList<int> collection, ISorter<int> sorter, IComparer<int> comparer)
		{
			_outputHelper.WriteLine($"Input:\t{string.Join(",", collection)}.");
			_outputHelper.WriteLine($"Sorter:\t{sorter.GetType().Name}.");
			_outputHelper.WriteLine($"Expected:\t{string.Join(",", collection)}.");
			var clone = JsonConvert.DeserializeObject<IList<int>>(
				JsonConvert.SerializeObject(collection));
			var expected = clone.OrderBy(x => x, comparer);

			sorter.Sort(collection, comparer);

			Assert.Equal(expected, collection);
		}

		protected void TestSortAscending(
			IList<int> collection, ISorter<int> sorter, IComparer<int> comparer = null)
		{
			comparer ??= Comparer<int>.Default;
			TestSort(collection, sorter, comparer);
		}

		protected void TestSortDescending(IList<int> collection, ISorter<int> sorter, IComparer<int> comparer = null)
		{
			comparer ??= new ComparerInverted<int>(Comparer<int>.Default);
			TestSort(collection, sorter, comparer);
		}
	}
}