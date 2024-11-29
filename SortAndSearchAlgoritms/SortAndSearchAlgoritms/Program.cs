using SortAndSearchAlgoritms.Algoritms.Search;
using SortAndSearchAlgoritms.Algoritms.Sort;

int[] numerosOrdenados = { 1,2,3,4,5,6,7,8,9 };
int[] numerosAleatorios = { 5,1,65,86,41,34,0,45,32 };
float[] numerosAleatorios2 = { 0.78f, 0.17f, 0.39f, 0.26f, 0.72f, 0.94f, 0.21f, 0.12f, 0.23f, 0.68f };
int alvo = 6;

var buscaBinary = BinarySearch.Execute(numerosOrdenados, alvo);
var buscaJump = JumpSearch.Execute(numerosOrdenados, alvo);
var ordenacaoBucket = BucketSort.Execute(numerosAleatorios2);
var ordenacaoMerge = MergeSort.Execute(numerosAleatorios);
var ordenacaoShell = ShellSort.Execute(numerosAleatorios);
var ordenacaoBubble = BubbleSort.Execute(numerosAleatorios);


//ImprimeLista(ordenacaoBucket);
//ImprimeLista(ordenacaoMerge);
//ImprimeLista(ordenacaoShell);
//ImprimeLista(ordenacaoBubble);

Console.WriteLine(buscaJump);

void ImprimeLista<Number>(Number[] numeros)
{
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(numeros[i]);
    }
}