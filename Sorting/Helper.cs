namespace Sorting;
public static class SortingHelper
{
    public static void Swap(int a , int b)
    {
        a=a+b;
        b=a-b;
        a=a-b;
    }
}
