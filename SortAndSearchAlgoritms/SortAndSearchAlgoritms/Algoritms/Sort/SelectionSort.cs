namespace SortAndSearchAlgoritms.Algoritms.Sort;

public static class SelectionSort
{
    public static int[] Execute(int[] numeros)
    {
        int numeroMinimo = 0;
        int auxiliar = 0;

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            numeroMinimo = i;

            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[j] < numeros[numeroMinimo])
                {
                    numeroMinimo = j;
                }
            }

            if (i != numeroMinimo)
            {
                auxiliar = numeros[i];
                numeros[i] = numeros[numeroMinimo];
                numeros[numeroMinimo] = auxiliar;
            }
        }

        return numeros;
    }
}