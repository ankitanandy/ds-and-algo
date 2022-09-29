namespace Sorting;
public static class BubbleSort
{
    public static int[] Sort(int[] arr)
    {
        for(int i=0;i<arr.Length;i++)
            for(int j=i+1;i<arr.Length;j++)
                if(arr[i]<arr[j])
                SortingHelper.Swap(arr[i],arr[j]);
              

              return arr;
    }   
}
