namespace SortAndSearchAlgoritms.Algoritms.Sort;

public static class MergeSort
{
    public static int[] Execute(int[] numeros)
    {
        MergeSorting(numeros, 0, numeros.Length - 1);

        return numeros;
    }

    private static void Merge(int[] numeros, int esquerda, int meio, int direita)
    {
        int num1 = meio - esquerda + 1;
        int num2 = direita - meio;

        int[] numerosEsquerda = new int[num1];
        int[] numerosDireita = new int[num2];

        for (int indice = 0; indice < numerosEsquerda.Length; indice++)
        {
            numerosEsquerda[indice] = numeros[esquerda + indice];
        }

        for (int indice = 0; indice < numerosDireita.Length; indice++)
        {
            numerosDireita[indice] = numeros[meio + 1 + indice];
        }

        int i = 0, j = 0, k = esquerda;

        while (i < numerosEsquerda.Length && j < numerosDireita.Length)
        {
            numeros[k++] = (numerosEsquerda[i] <= numerosDireita[j]) ? numerosEsquerda[i++] : numerosDireita[j++];
        }
        
        while (i < numerosEsquerda.Length)
        {
            numeros[k++] = numerosEsquerda[i++];
        }
        
        while (j < numerosDireita.Length)
        {
            numeros[k++] = numerosDireita[j++];
        }
    }
    
    private static void MergeSorting(int[] numeros, int esquerda, int direita)
    {
        if (esquerda < direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;
            MergeSorting(numeros, esquerda, meio);
            MergeSorting(numeros, meio + 1, direita);

            Merge(numeros, esquerda, meio, direita);
        }
    }
}
