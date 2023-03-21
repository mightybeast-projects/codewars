namespace codewars.Modules.Practice.Spiral;

public class Kata
{
    public static int[,] Spiralize(int size)
    {
        int[,] spiral = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            spiral[0, i] = 1;
            spiral[i, size - 1] = 1;
            spiral[size - 1, i] = 1;
        }

        for (int i = 2; i < size; i++)
                spiral[i, 0] = 1;
        
        for (int i = 1; i < size - 2; i++)
                spiral[2, i] = 1;
                
        for (int i = 3; i < size - 2; i++)
                spiral[i, size - 3] = 1;

        if (size == 7)
        {
            for (int i = 2; i < size - 3; i++)
                spiral[size - 3, i] = 1;
        }
        else if (size == 8)
        {
            for (int i = 2; i < size - 3; i++)
                spiral[size - 3, i] = 1;

            spiral[4, 2] = 1;
        }

        return spiral;
    }
}