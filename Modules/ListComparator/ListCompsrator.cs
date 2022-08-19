namespace ListComparator;

public class ListComparator
{
    public int Compare(int[] firstArray, int[] secondArray)
    {
        int equalCount = 0;

        foreach (int firstArrayElement in firstArray)
            foreach (int secondArrayElement in secondArray)
                if (firstArrayElement == secondArrayElement)
                    equalCount++;

        return equalCount;
    }
}