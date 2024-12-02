namespace OrdenarNotas;

public static class InterpolationSearch
{
    public static int Execute(Aluno[] alunos, int nota)
    {
        int esquerda = 0;
        int direita = alunos.Length - 1;

        while (esquerda <= direita && nota >= alunos[esquerda].Nota && nota <= alunos[direita].Nota)
        {
            int pos = esquerda + ((nota - alunos[esquerda].Nota) * (direita - esquerda)) / (alunos[direita].Nota - alunos[esquerda].Nota);

            if (alunos[pos].Nota == nota)
                return pos;

            if (alunos[pos].Nota < nota)
                esquerda = pos + 1;
            else
                direita = pos - 1;
        }

        return -1;
    }
}
