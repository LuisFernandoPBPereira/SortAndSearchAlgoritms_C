using SortAndSearchAlgoritms.Algoritms.Search;

int[] numerosOrdenados = { 1,2,3,4,5,6,7,8,9 };
int[] numerosAleatorios = { 5,1,65,86,41,34,0,45,32 };
int alvo = 6;
int resultado;

resultado = BinarySearch.Execute(numerosOrdenados, numerosOrdenados.Length, alvo);

Console.WriteLine(resultado);