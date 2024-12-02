namespace OrdenarNotas;

public static class BucketSort
{
    public static Aluno[] Execute(Aluno[] alunos)
    {
        int numBuckets = 10;
        List<Aluno>[] buckets = new List<Aluno>[numBuckets];

        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<Aluno>();
        }

        foreach (Aluno aluno in alunos)
        {
            int bucketIndex = aluno.Nota / 10;
            if (bucketIndex >= numBuckets) bucketIndex = numBuckets - 1;
            buckets[bucketIndex].Add(aluno);
        }

        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i].Sort((a, b) => a.Nota.CompareTo(b.Nota));
        }

        int index = 0;
        foreach (var bucket in buckets)
        {
            foreach (Aluno aluno in bucket)
            {
                alunos[index++] = aluno;
            }
        }

        return alunos;
    }
}
