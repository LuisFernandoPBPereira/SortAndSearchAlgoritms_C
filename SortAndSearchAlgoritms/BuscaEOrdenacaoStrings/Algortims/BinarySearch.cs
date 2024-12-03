namespace BuscaEOrdenacaoStrings.Algortims;

public static class BinarySearch
{
    public static int Execute(string[] palavras, string alvo)
    {
        int esquerda = 0, direita = palavras.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            int comparacao = string.Compare(palavras[meio], alvo, StringComparison.Ordinal);

            if (comparacao == 0)
            {
                return meio;
            }
            else if (comparacao < 0)
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
