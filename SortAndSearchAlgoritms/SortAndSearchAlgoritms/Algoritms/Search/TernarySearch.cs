namespace SortAndSearchAlgoritms.Algoritms.Search;

public static class TernarySearch
{
    public static int Execute(int[] numeros, int alvo)
    {
        return ternarySearching(numeros, 0, numeros.Length - 1, alvo);
    }

    private static int ternarySearching(int[] numeros, int esquerda, int direita, int alvo)
    {
        if(direita >= esquerda)
        {
            int meio1 = esquerda + (direita - esquerda) / 3;
            int meio2 = direita - (direita - esquerda) / 3;

            if (numeros[meio1] == alvo) return meio1;
            if (numeros[meio2] == alvo) return meio2;

            if (alvo < numeros[meio1])
                return ternarySearching(numeros, esquerda, meio1 - 1, alvo);
            else if(alvo > numeros[meio2])
                return ternarySearching(numeros, meio2 + 1, direita, alvo);
            else 
                return ternarySearching(numeros, meio1 + 1, meio2 - 1, alvo);
        }

        return -1;
    }
}
