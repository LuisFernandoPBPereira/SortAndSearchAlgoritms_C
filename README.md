# Lista de Atividades: Reforço de Estudo para a Prova 02

## 1. Binary Search
   - Implemente o algoritmo Binary Search em uma lista ordenada e encontre o índice de um elemento dado.
   - Explique por que a lista deve estar ordenada para que o Binary Search funcione corretamente. Forneça exemplos.

### Resposta
A lista precisa estar ordenada, pois, ao dividirmos a lista pela metade, podemos saber em qual das metades o número a ser busca está.
Exemplos:
- `[1, 2, 3, 4, 5, 6, 7, 8, 9]`
- `[9, 8, 7, 6, 5, 4, 3, 2, 1]`

[Binary Search Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Search/BinarySearch.cs)

<br>

## 2. Interpolation Search  
   - Crie uma função que implemente o Interpolation Search e teste-a em listas ordenadas com intervalos uniformes e não uniformes. Compare com o Binary Search.
   - Identifique casos em que o Interpolation Search é mais eficiente que o Binary Search.

### Resposta
Interpolation Search é mais eficiente para busca frequente em dados quase uniformes, listas grandes e para distribuição uniforme de dados.

[Interpolation Search Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Search/InterpolationSearch.cs)

<br>

## 3. Jump Search
   - Desenvolva o algoritmo Jump Search e determine o tamanho ideal do "salto" para uma lista de tamanho 
   - Compare o tempo de execução do Jump Search com o Binary Search em listas de diferentes tamanhos.

### Resposta

| **Algoritmo**   | **1000 Elementos** | **10.000 Elementos** | **100.000 Elementos** |
|------------------|--------------------|-----------------------|------------------------|
| **Jump Search**  | 0.0002673s        | 0.0003305s           | 0.0005575s            |
| **Binary Search**| 0.0002901s        | 0.0002614s           | 0.0003292s            |


[Jump Search Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Search/JumpSearch.cs)

<br>

## 4. Exponential Search
   - Implemente o algoritmo Exponential Search para localizar um elemento em uma lista ordenada. Explique como ele combina elementos do Jump Search e Binary Search.
   - Analise o desempenho do Exponential Search em listas muito grandes e pequenas.

### Resposta

Como o Exponential Search Combina Jump Search e Binary Search:

#### Jump Search:
- O Exponential Search expande o intervalo exponencialmente para localizar o segmento onde o elemento pode estar, semelhante ao Jump Search que pula por intervalos fixos.

#### Binary Search:

- Após localizar o intervalo potencial, o Exponential Search realiza uma Binary Search dentro desse intervalo, garantindo eficiência .

| **Lista**      | **Alvo** | **Índice** | **Tempo (segundos)**   |
|----------------|----------|------------|-----------------------|
| **Pequena**    | 10       | 9          | \(1.53 \times 10^{-5}\) |
|                | 100      | 99         | \(5.48 \times 10^{-6}\) |
|                | 1000     | -1         | \(4.29 \times 10^{-6}\) |
|                | 500000   | -1         | \(4.05 \times 10^{-6}\) |
|                | 999999   | -1         | \(3.81 \times 10^{-6}\) |
| **Grande**     | 10       | 9          | \(9.30 \times 10^{-6}\) |
|                | 100      | 99         | \(5.01 \times 10^{-6}\) |
|                | 1000     | 999        | \(1.10 \times 10^{-5}\) |
|                | 500000   | 499999     | \(5.65 \times 10^{-5}\) |
|                | 999999   | 999998     | \(1.38 \times 10^{-5}\) |

[Exponential Search Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Search/ExponentialSearch.cs)

<br>

## 5. Shell Sort
   - Implemente o Shell Sort com diferentes sequências de intervalo (ex.: Shell, Knuth, Hibbard). Compare os tempos de execução.
   - Explique como a escolha da sequência de intervalos afeta a eficiência do algoritmo.

| **Sequência** | **Descrição**                        | **Tempo (segundos)** |
|---------------|--------------------------------------|-----------------------|
| **Shell**     | Gaps sucessivamente divididos por 2  | 0.110                |
| **Knuth**     | Gaps baseados na fórmula \(3^k - 1\) | 0.101                |
| **Hibbard**   | Gaps baseados em \(2^k - 1\)         | 0.139                |

- Knuth Sequence foi a mais eficiente nos testes realizados.
- Shell Sequence teve um desempenho intermediário, mas é mais simples de implementar.
- Hibbard Sequence foi a menos eficiente neste caso, devido a gaps maiores no início.

A escolha da sequência de intervalos no Shell Sort afeta diretamente sua eficiência ao influenciar o número de comparações e movimentações:

- Shell Sequence (𝑛/2,𝑛/4,...,1n/2,n/4,...,1): simples, mas menos eficiente para arrays grandes, pois pode deixar elementos desordenados no início.
- Knuth Sequence (3𝑘−13k−1): mais equilibrada, reduz comparações e movimentações, sendo geralmente mais eficiente.
- Hibbard Sequence (2𝑘−12k−1): boa para mistura inicial, mas gaps maiores podem causar movimentações extras.

[Shell Sort Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Sort/ShellSort.cs)

<br>

## 6. Merge Sort
   - Implemente o Merge Sort para ordenar uma lista de números inteiros. Explique o conceito de "dividir para conquistar" usado nesse algoritmo.
   - Modifique o Merge Sort para ordenar strings em ordem alfabética.

### Resposta
- "Dividir para conquistar": esse termo se refere para quando dividimos uma lista até conquistarmos o valor desejado.

[Merge Sort Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Sort/MergeSort.cs)

[Merge Sort em Strings](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/BuscaEOrdenacaoStrings/Algortims/MergeSort.cs)

<br>

## 7. Selection Sort
   - Desenvolva o Selection Sort e acompanhe cada iteração mostrando como a lista é organizada passo a passo.
   - Analise o desempenho do Selection Sort em listas pequenas, médias e grandes.

### Resposta
O desempenho piora quanto mais a lista cresce, por ser O(n²).

[Selection Sort Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Sort/SelectionSort.cs)

<br>

## 8. Bucket Sort
   - Implemente o Bucket Sort para ordenar uma lista de números em ponto flutuante no intervalo [0, 1). Explique como os "baldes" são preenchidos e ordenados.
   - Adapte o Bucket Sort para ordenar números inteiros positivos em intervalos maiores.

### Resposta
Os baldes são preenchidos com os números que correspondem aos seus intervalos.

[Bucket Sort Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Sort/BucketSort.cs)

[Bucket Sort Números Inteiros](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/OrdenarNotas/BucketSort.cs)

<br>

## 9. Radix Sort
   - Implemente o Radix Sort para ordenar uma lista de números inteiros. Teste-o com números de diferentes tamanhos (ex.: 2 dígitos, 5 dígitos, 10 dígitos).
   - Explique como o algoritmo lida com bases diferentes (ex.: base 10 e base 2).

### Resposta

O Radix Sort pode ser adaptado para trabalhar com diferentes bases, como base 10 ou base 2, ajustando a forma como os números são ordenados (dígitos ou bits). Embora o processo seja conceitualmente o mesmo (ordenar de acordo com a posição dos elementos), a escolha da base impacta a quantidade de iterações necessárias para ordenar completamente os números. Base 2, por exemplo, é mais eficiente para números grandes em comparação com base 10, devido ao menor número de passagens necessárias.

[Radix Sort Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Sort/RadixSort.cs)

<br>

## 10. Quick Sort
   - Implemente o Quick Sort utilizando diferentes critérios para escolha do pivô (ex.: primeiro elemento, último elemento, elemento do meio).
   - Analise o desempenho do Quick Sort em listas quase ordenadas e completamente desordenadas.

### Resposta
| **Tipo de Lista**        | **Tempo (segundos)**   | **Primeiros 10 Elementos Ordenados** |
|--------------------------|------------------------|--------------------------------------|
| **Quase Ordenada**       | 0.0161                 | [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]     |
| **Completamente Desordenada** | 0.0294             | [5, 7, 16, 20, 20, 24, 29, 44, 59, 60] |

Em listas desordenadas, o desempenho é pior, pois a escolha do pivô pode não ser a melhor.

[Quick Sort Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Sort/QuickSort.cs)

<br>
    
## 11. Ternary Search
   - Desenvolva o algoritmo Ternary Search para localizar um elemento em uma lista ordenada. Compare seu desempenho com o Binary Search.
   - Identifique situações em que o Ternary Search seria mais eficiente que o Binary Search.

[Ternary Search Implementado](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/blob/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms/Search/TernarySearch.cs)

<br>

## 12. Comparação de Algoritmos de Busca
   - Construa uma tabela comparativa dos tempos de execução de Binary Search, Interpolation Search, Jump Search e Exponential Search em listas de tamanhos diferentes.

<br>

## 13. Comparação de Algoritmos de Ordenação
   - Ordene a mesma lista utilizando Shell Sort, Merge Sort, Selection Sort, Quick Sort, Bucket Sort e Radix Sort. Registre os tempos de execução e número de comparações realizadas.

<br>

## 14. Análise de Complexidade
   - Analise a complexidade de tempo e espaço de cada algoritmo de busca e ordenação listados.

<br>

## 15. Busca e Ordenação em Strings
   - Adapte os algoritmos de ordenação (Merge Sort e Quick Sort) para ordenar palavras em ordem alfabética.
   - Utilize Binary Search para verificar se uma palavra específica está presente em uma lista de palavras ordenadas.

[Busca e Ordenação em Strings](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/tree/main/SortAndSearchAlgoritms/BuscaEOrdenacaoStrings)

<br>

## 16. Aplicação Prática de Busca
   - Use o Binary Search para procurar um livro específico por ISBN em uma lista ordenada de registros de biblioteca.

[Buscar Livro por ISBN](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/tree/main/SortAndSearchAlgoritms/BinarySearchNaPratica)

<br>

## 17. Busca e Ordenação em Dados Reais
   - Implemente Bucket Sort para ordenar as notas de uma turma de alunos, classificadas entre 0 e 100. Em seguida, utilize o Interpolation Search para encontrar um aluno com uma nota específica.

[Ordenar e Buscar Alunos por Nota](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/tree/main/SortAndSearchAlgoritms/OrdenarNotas)

<br>

## 18. Ordenação Estável e Instável
   - Identifique quais algoritmos de ordenação da lista são estáveis e explique o que isso significa. Demonstre com exemplos.

<br>

## 19. Análise Visual dos Algoritmos  
   - Crie gráficos para ilustrar como os algoritmos de ordenação (Merge Sort, Quick Sort, Selection Sort) reorganizam os elementos a cada etapa.

<br>

## 20. Desafios de Implementação
   - Crie um programa que permita ao usuário escolher um algoritmo de busca e ordenação para ordenar uma lista ou procurar um elemento, oferecendo comparações automáticas entre os métodos.

[Todos Algoritmos Implementados](https://github.com/LuisFernandoPBPereira/SortAndSearchAlgoritms_CSharp/tree/main/SortAndSearchAlgoritms/SortAndSearchAlgoritms/Algoritms)
