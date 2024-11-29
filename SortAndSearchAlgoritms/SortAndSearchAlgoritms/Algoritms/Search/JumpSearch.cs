namespace SortAndSearchAlgoritms.Algoritms.Search;

public static class JumpSearch
{
    public static int Execute(int[] numeros, int alvo)
    {
        int step = (int)Math.Sqrt(numeros.Length);
        int anterior = 0;

        while (numeros[Math.Min(step, numeros.Length) - 1] < alvo)
        {
            anterior = step;
            step += (int)Math.Sqrt(numeros.Length);

            if (anterior >= numeros.Length) return -1;
        }

        for (int i = anterior; i < Math.Min(step, numeros.Length); i++)
        {
            if (numeros[i] == alvo) return i;
        }

        return -1;
    }
}
