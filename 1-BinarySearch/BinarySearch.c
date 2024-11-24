#include <stdio.h>

int binarySearch(int numeros[], int tamanho, int alvo);
void imprimeResultado(int alvo, int indiceDoAlvo);

int main() {
    int numeros[] = {1,2,3,4,5,6,7,8,9,10};
    int tamanho = 10;
    int alvo = 6;

    int indiceDoAlvo = binarySearch(numeros, tamanho, alvo);

    imprimeResultado(alvo, indiceDoAlvo);

    return 0;
}

int binarySearch(int numeros[], int tamanho, int alvo) {
    int esquerdaDoArray = 0;
    int direitaDoArray = tamanho - 1;

    while (esquerdaDoArray <= direitaDoArray) {
        int meioDoArray = esquerdaDoArray + (direitaDoArray - esquerdaDoArray) / 2;

        // Se o alvo estiver no meio, o índice é retornado
        if (numeros[meioDoArray] == alvo) {
            return meioDoArray;
        }

        // Se o alvo é maior, ignora a metade esquerda
        if (numeros[meioDoArray] < alvo) {
            esquerdaDoArray = meioDoArray + 1;
        }
        // Se o alvo é menor, ignora a metade direita
        else {
            direitaDoArray = meioDoArray - 1;
        }
    }

    return -1;
}

void imprimeResultado(int alvo, int indiceDoAlvo) {
    if(indiceDoAlvo == -1){
        printf("Alvo nao encontrado\n");
        return;
    }

    printf("O indice do numero: %d eh %d\n", alvo, indiceDoAlvo);
}