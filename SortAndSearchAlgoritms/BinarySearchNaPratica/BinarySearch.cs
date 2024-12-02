namespace BinarySearchNaPratica;

public static class BinarySearch
{
    public static int Execute(Livro[] numeros, int alvo)
    {
        int esquerda = 0, direita = numeros.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (numeros[meio].Isbn == alvo)
            {
                return meio;
            }
            else if (numeros[meio].Isbn < alvo)
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
