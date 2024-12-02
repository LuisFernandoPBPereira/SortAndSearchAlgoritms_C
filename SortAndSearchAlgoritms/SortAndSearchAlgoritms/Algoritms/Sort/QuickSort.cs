namespace SortAndSearchAlgoritms.Algoritms.Sort;

public static class QuickSort
{
    public static int[] Execute(int[] numeros)
    {
        QuickSorting(numeros, 0, numeros.Length - 1);

        return numeros;
    }

    private static void QuickSorting(int[] numeros, int esquerda, int direita)
    {
        if (esquerda < direita)
        {
            int indexPivot = Particionar(numeros, esquerda, direita);

            QuickSorting(numeros, esquerda, indexPivot - 1);
            QuickSorting(numeros, indexPivot + 1, direita);
        }
    }

    private static int Particionar(int[] numeros, int esquerda, int direita)
    {
        int pivot = numeros[direita];
        int i = esquerda - 1;

        for (int j = esquerda; j < direita; j++)
        {
            if (numeros[j] <= pivot)
            {
                i++;
                TrocaPivot(numeros, i, j);
            }
        }

        TrocaPivot(numeros, i + 1, direita);

        return i + 1;
    }

    private static void TrocaPivot(int[] numeros, int i, int j)
    {
        int temp = numeros[i];
        numeros[i] = numeros[j];
        numeros[j] = temp;
    }
}
