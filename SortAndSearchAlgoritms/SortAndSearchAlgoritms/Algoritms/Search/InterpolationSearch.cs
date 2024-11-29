namespace SortAndSearchAlgoritms.Algoritms.Search;

public static class InterpolationSearch
{
    public static int Execute(int[] numeros, int alvo)
    {
        int menor = 0;
        int maior = numeros.Length - 1;

        while (menor <= maior && alvo >= numeros[menor] && alvo <= numeros[maior])
        {
            int posicao = (int)(menor + ((double)(maior - menor) / (numeros[maior] - numeros[menor]) * (alvo - numeros[menor])));

            if (numeros[posicao] == alvo) return posicao;
            else if (numeros[posicao] < alvo) menor = posicao + 1;
            else maior = posicao - 1;
        }

        return -1;
    }
}
