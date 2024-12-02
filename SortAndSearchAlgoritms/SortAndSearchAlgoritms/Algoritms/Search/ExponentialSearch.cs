namespace SortAndSearchAlgoritms.Algoritms.Search;

public static class ExponentialSearch
{
    public static int Execute(int[] numeros, int alvo)
    {
        if (numeros[0] == alvo) return 0;

        int intervalo = 1;
        
        while (intervalo < numeros.Length && numeros[intervalo] <= alvo)
        {
            intervalo *= 2;
        }

        return BinarySearch(numeros, alvo, intervalo / 2, Math.Min(intervalo, numeros.Length - 1));
    }

    private static int BinarySearch(int[] numeros, int alvo, int esquerda, int direita)
    {
        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (numeros[meio] == alvo)
            {
                return meio;
            }
            else if (numeros[meio] < alvo)
            {
                esquerda = meio + 1;
            }
            else
            {
                direita = meio - 1;
            }
        }

        return -1;
    }
}
