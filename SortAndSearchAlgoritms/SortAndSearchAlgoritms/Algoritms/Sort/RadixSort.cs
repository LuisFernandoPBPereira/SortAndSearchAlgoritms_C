namespace SortAndSearchAlgoritms.Algoritms.Sort;

public static class RadixSort
{
    public static int[] Execute(int[] numeros)
    {
        int maximo = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maximo)
            {
                maximo = numeros[i];
            }
        }

        for (int expoente = 1; maximo / expoente > 0; expoente *= 10)
        {
            CountSort(numeros, expoente);
        }

        return numeros;
    }

    private static void CountSort(int[] numeros, int expoente)
    {
        int[] saida = new int[numeros.Length];
        int[] contador = new int[10];
        contador[0] = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            contador[(numeros[i] / expoente) % 10]++;
        }

        for (int i = 1; i < 10; i++)
        {
            contador[i] += contador[i-1];
        }

        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            saida[contador[(numeros[i]) / expoente % 10] - 1] = numeros[i];
            contador[(numeros[i] / expoente) % 10]--;
        }

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = saida[i];
        }
    }
}
