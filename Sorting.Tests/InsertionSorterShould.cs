using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Sorting.Tests
{
	public class InsertionSorterShould : TestBase
	{
		public InsertionSorterShould(ITestOutputHelper outputHelper) 
			: base(outputHelper)
		{
		}

		[Theory]
		[ClassData(typeof(TestData))]
		public void SortAscending(IList<int> source)
		{
			TestSortAscending(source, new InsertionSorter<int>());
		}

		[Theory]
		[ClassData(typeof(TestData))]
		public void SortDescending(IList<int> source)
		{
			TestSortDescending(source, new InsertionSorter<int>());
		}
	}
}