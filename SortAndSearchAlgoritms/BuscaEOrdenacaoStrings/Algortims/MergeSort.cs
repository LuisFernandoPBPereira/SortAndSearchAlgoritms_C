namespace BuscaEOrdenacaoStrings.Algortims;

public static class MergeSort
{
    public static string[] Execute(string[] strings)
    {
        MergeSorting(strings, 0, strings.Length - 1);

        return strings;
    }

    private static void Merge(string[] strings, int esquerda, int meio, int direita)
    {
        int num1 = meio - esquerda + 1;
        int num2 = direita - meio;

        string[] stringsEsquerda = new string[num1];
        string[] stringsDireita = new string[num2];

        for (int indice = 0; indice < stringsEsquerda.Length; indice++)
        {
            stringsEsquerda[indice] = strings[esquerda + indice];
        }

        for (int indice = 0; indice < stringsDireita.Length; indice++)
        {
            stringsDireita[indice] = strings[meio + 1 + indice];
        }

        int i = 0, j = 0, k = esquerda;

        while (i < stringsEsquerda.Length && j < stringsDireita.Length)
        {
            if (string.Compare(stringsEsquerda[i], stringsDireita[j], StringComparison.Ordinal) <= 0)
            {
                strings[k++] = stringsEsquerda[i++];
            }
            else
            {
                strings[k++] = stringsDireita[j++];
            }
        }

        while (i < stringsEsquerda.Length)
        {
            strings[k++] = stringsEsquerda[i++];
        }

        while (j < stringsDireita.Length)
        {
            strings[k++] = stringsDireita[j++];
        }
    }

    private static void MergeSorting(string[] strings, int esquerda, int direita)
    {
        if (esquerda < direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;
            MergeSorting(strings, esquerda, meio);
            MergeSorting(strings, meio + 1, direita);

            Merge(strings, esquerda, meio, direita);
        }
    }
}
