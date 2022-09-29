
using Sorting;
namespace SortingTest;

[TestClass]
public class BubbleSortTest
{
    [TestMethod]
    public void TestSort()
    {
 
         int[] arr=BubbleSort.Sort(new int[]{4,-1,54,22,30});

         int[] expected = new int[]{-1,4,22,30, 54};
         for(int i=0;i<arr.Length;i++)
         {
            Assert.AreEqual(arr[i],expected[i]);
         }
    }
}