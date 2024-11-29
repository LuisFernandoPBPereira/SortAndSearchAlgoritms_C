namespace SortAndSearchAlgoritms.Algoritms.Sort;

public static class ShellSort
{
    public static int[] Execute(int[] numeros)
    {
        for (int gap = numeros.Length / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < numeros.Length; i++)
            {
                int temp = numeros[i];
                int j;

                for (j = i; j >= gap && numeros[j - gap] > temp; j -= gap)
                {
                    numeros[j] = numeros[j - gap];   
                }

                numeros[j] = temp;
            }
        }

        return numeros;
    }
}
