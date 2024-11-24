#include <stdio.h>
#include <math.h>

int jumpSearch(int numeros[], int tamanho, int alvo);

int main() {
    int numeros[] = {1,2,3,4,5,6,7,8,9,10};
    int tamanho = sizeof(numeros) / sizeof(numeros[0]);
    int alvo = 4;

    int indiceDoAlvo = jumpSearch(numeros, tamanho, alvo);

    printf("%d\n", indiceDoAlvo);

    return 0;
}

int jumpSearch(int numeros[], int tamanho, int alvo) {
    int salto = sqrt(tamanho); // Define o tamanho do salto
    int anterior = 0;

    // Encontra o bloco onde o elemento pode estar presente
    while (numeros[(int)fmin(salto, tamanho) - 1] < alvo) {
        anterior = salto;        // Move para o próximo bloco
        salto += sqrt(tamanho); // Calcula o próximo passo
        if (anterior >= tamanho) { // Se ultrapassou o tamanho do array
            return -1;
        }
    }

    // Realiza uma busca linear dentro do bloco
    while (numeros[anterior] < alvo) {
        anterior++;
        if (anterior == fmin(salto, tamanho)) { // Alcançou o próximo bloco ou o final do array
            return -1;
        }
    }

    // Verifica se encontrou o elemento
    if (numeros[anterior] == alvo) {
        return anterior;
    }

    return -1; // Elemento não encontrado
}