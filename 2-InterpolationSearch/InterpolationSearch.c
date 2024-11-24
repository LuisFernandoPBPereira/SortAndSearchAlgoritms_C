#include <stdio.h>

int interpolationSearch(int numeros[], int tamanho, int alvo);
void imprimeValores(int alvo, int indiceDoAlvo);

int main() {
    // int numeros[] = {1,2,3,4,5,6,7,8,9,10};
    int numeros[] = {10,25,30,45,50,65,70,85,90,105};
    int tamanho = 10;
    int alvo = 85;

    int indiceDoAlvo = interpolationSearch(numeros, tamanho, alvo);

    imprimeValores(alvo, indiceDoAlvo);

    return 0;
}

int interpolationSearch(int numeros[], int tamanho, int alvo) {
    int indiceMenorValor = 0;
    int indiceMaiorValor = tamanho - 1;

    while (indiceMenorValor <= indiceMaiorValor && alvo >= numeros[indiceMenorValor] && alvo <= numeros[indiceMaiorValor]) {
        // Evita divisão por zero
        if (numeros[indiceMenorValor] == numeros[indiceMaiorValor]) {
            if (numeros[indiceMenorValor] == alvo) {
                return indiceMenorValor; // Elemento encontrado
            } else {
                break;
            }
        }

        // Calcula a posição estimada
        int posicao = indiceMenorValor + ((alvo - numeros[indiceMenorValor]) * (indiceMaiorValor - indiceMenorValor)) / (numeros[indiceMaiorValor] - numeros[indiceMenorValor]);

        // Verifica se o elemento foi encontrado
        if (numeros[posicao] == alvo) {
            return posicao;
        }

        // Ajusta os limites da busca
        if (numeros[posicao] < alvo) {
            indiceMenorValor = posicao + 1; // Ignora a parte à esquerda
        } else {
            indiceMaiorValor = posicao - 1; // Ignora a parte à direita
        }
    }

    return -1;
}

void imprimeValores(int alvo, int indiceDoAlvo) {
    if(indiceDoAlvo == -1) {
        printf("Alvo nao encontrado\n");
        return;
    }

    printf("O indice do numero %d eh %d\n", alvo, indiceDoAlvo);
}