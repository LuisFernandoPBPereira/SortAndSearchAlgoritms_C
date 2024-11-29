
namespace SortAndSearchAlgoritms.Algoritms.Sort;

public static class BucketSort
{
    public static float[] Execute(float[] numeros)
    {
        List<float>[] buckets = new List<float>[numeros.Length];

        for (int i = 0; i < numeros.Length; i++)
        {
            buckets[i] = new List<float>();
        }

        for (int i = 0; i < numeros.Length; i++)
        {
            int bucketIndex = (int)(numeros[i] * numeros.Length);
            buckets[bucketIndex].Add(numeros[i]);
        }

        for (int i = 0; i < numeros.Length; i++)
        {
            InsertionSort(buckets[i]);
        }

        int index = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            foreach (var valor in buckets[i])
            {
                numeros[index++] = valor;
            }
        }

        return numeros;
    }

    private static void InsertionSort(List<float> bucket)
    {
        for (int i = 0; i < bucket.Count; i++)
        {
            float key = bucket[i];
            int j = i - 1;

            while (j >= 0 && bucket[j] > key)
            {
                bucket[j + 1] = bucket[j];
                j--;
            }

            bucket[j + 1] = key;
        }
    }
}
