using System;

public static class MatrixHelper
{
    public static int[] Sum(this Matrix m1, Matrix m2)
    {
        m1 ??= new Matrix(0);
        m2 ??= new Matrix(0);

        var maxSize = Math.Max(m1.Size, m2.Size);
        var newArray = new int[maxSize];

        for (var i = 0; i < maxSize; i++)
        {
            newArray[i] = m1[i, i] + m2[i, i];
        }

        return newArray;
    }
}