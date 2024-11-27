namespace SortAndSearchAlgoritms.Algoritms.Search;

public static class BinarySearch
{
    public static int Execute(int[] numeros, int alvo)
    {
        int esquerda = 0, direita = numeros.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if(numeros[meio] == alvo)
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
