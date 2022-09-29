namespace Sorting;

public static class HeapSort{
    public static int[] Sort(int[] arr)
    {
        int n=arr.Length-1;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr,i,n);
        }

        while(n>0)
        {
            SortingHelper.Swap(ref arr[0],ref arr[n]);
            --n;
            Heapify(arr,0,n);
        }
        return arr;

    }

    public static void Heapify(int[] arr, int i, int n) // Building a max heap
    {
        int left=2*i+1;
        int right=2*i+2;
        int pivot=i;

        if(left<=n)
            if(arr[pivot]<arr[left])
            pivot=left;
        
        if(right<=n)
            if(arr[pivot]<arr[right])
            pivot=right;

            if(pivot!=i)
            {
                SortingHelper.Swap(ref arr[pivot],ref arr[i]);
                Heapify(arr,pivot,n);
            }
        }
    }
