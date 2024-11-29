namespace SortAndSearchAlgoritms.Algoritms.Sort;

public static class BubbleSort
{
    public static int[] Execute(int[] numeros)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            for (int j = 0; j < numeros.Length - i - 1; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int temp = numeros[j];

                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        return numeros;
    }
}
