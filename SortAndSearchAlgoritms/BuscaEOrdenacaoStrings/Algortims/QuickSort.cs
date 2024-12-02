namespace BuscaEOrdenacaoStrings.Algortims;

public static class QuickSort
{
    public static string[] Execute(string[] strings)
    {
        QuickSorting(strings, 0, strings.Length - 1);

        return strings;
    }

    private static void QuickSorting(string[] strings, int esquerda, int direita)
    {
        if (esquerda < direita)
        {
            int indexPivot = Particionar(strings, esquerda, direita);

            QuickSorting(strings, esquerda, indexPivot - 1);
            QuickSorting(strings, indexPivot + 1, direita);
        }
    }

    private static int Particionar(string[] strings, int esquerda, int direita)
    {
        string pivot = strings[direita];
        int i = esquerda - 1;

        for (int j = esquerda; j < direita; j++)
        {
            if (string.Compare(strings[j], pivot, StringComparison.Ordinal) <= 0)
            {
                i++;
                TrocaPivot(strings, i, j);
            }
        }

        TrocaPivot(strings, i + 1, direita);

        return i + 1;
    }

    private static void TrocaPivot(string[] strings, int i, int j)
    {
        string temp = strings[i];
        strings[i] = strings[j];
        strings[j] = temp;
    }
}
