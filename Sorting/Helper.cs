namespace Sorting;
public static class SortingHelper
{
    public static void Swap(ref int a ,ref int b)
    {
        a=a+b;
        b=a-b;
        a=a-b;
    }
}
