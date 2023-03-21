namespace codewars.Modules.Practice.Spiral;

public class Kata
{
    public static int[,] Spiralize(int size)
    {
        int[,] spiral = new int[size, size];

        int left = 0;
        int top = 0;
        int bottom = size;
        int right = size;

        while(true)
        {
            for (int i = left; i < right; i++)
            {
                if (i == left && i > 1)
                    spiral[top, left - 1] = 1;
                spiral[top, i] = 1;
            }

            if (++top > bottom) break;

            for (int i = top; i < bottom; i++)
                spiral[i, right - 1] = 1;

            if (left > --right) break;

            for (int i = right; i > left; i--)
                spiral[bottom - 1, i] = 1;

            if (top > --bottom) break;

            for (int i = bottom; i > top; i--)
                spiral[i, left] = 1;

            if (++left > right) break;

            top++;
            right--;
            bottom--;
            left++;
        }

        return spiral;
    }
}