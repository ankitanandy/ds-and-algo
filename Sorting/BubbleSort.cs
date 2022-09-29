namespace Sorting;
//Time:O(N^2), Space:O(1)
public static class BubbleSort
{
    public static int[] Sort(int[] arr)
    {
        for(int i=0;i<arr.Length;i++)
            for(int j=0;j<arr.Length-1;j++)
                if(arr[j]>arr[j+1])
                SortingHelper.Swap(ref arr[j],ref arr[j+1]);
              return arr;
    }   
}
