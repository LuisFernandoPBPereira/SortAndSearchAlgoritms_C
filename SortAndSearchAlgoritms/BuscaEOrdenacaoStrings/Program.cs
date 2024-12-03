using BuscaEOrdenacaoStrings.Algortims;

string[] listaStringsAleatoriaOriginal = { "Luis", "Fernando", "Pedro"};
string[] listaStringsAleatoriaMerge = { "Luis", "Fernando", "Pedro"};
string[] listaStringsAleatoriaQuick = { "Luis", "Fernando", "Pedro"};

var listaOrdenadaMerge = MergeSort.Execute(listaStringsAleatoriaMerge);
var listaOrdenadaQuick = QuickSort.Execute(listaStringsAleatoriaQuick);


Console.Write($"Lista original: ");
ImprimeLista(listaStringsAleatoriaOriginal);
Console.WriteLine();
Console.Write("Ordenação de strings com Merge Sort: ");
ImprimeLista(listaOrdenadaMerge);
Console.WriteLine("\n");

Console.Write($"Lista original: ");
ImprimeLista(listaStringsAleatoriaOriginal);
Console.WriteLine();
Console.Write("Ordenação de strings com Quick Sort: ");
ImprimeLista(listaOrdenadaQuick);
Console.WriteLine("\n");

var indice = BinarySearch.Execute(listaOrdenadaQuick, "Luis");
Console.WriteLine($"Elemento a ser buscado com Binary Search: Luis\n\n\"Luis\" está no índice: {indice}");

void ImprimeLista(string[] strings)
{
    foreach (var item in strings)
    {
        Console.Write($"{item} ");
    }
}