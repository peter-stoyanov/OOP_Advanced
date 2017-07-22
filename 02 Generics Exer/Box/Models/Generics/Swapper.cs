using System.Collections.Generic;

public static class Swapper
{
    public static void Swap<T>(IList<T> collection, int indexA, int indexB)
    {
        T temp = collection[indexA];

        collection[indexA] = collection[indexB];

        collection[indexB] = temp;
    }
}
