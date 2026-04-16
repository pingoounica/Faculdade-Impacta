##Crie uma função que receba uma matriz numérica como
#  argumento e retorne o valor da soma de seus itens.
#  Acesse os itens da matriz indexando-a com os dois índices.

def soma_matriz(matriz):
    soma = 0
    for i in range(len(matriz)):
        for j in range(len(matriz[i])):
            soma += matriz[i][j]
    return soma
# Exemplo de uso:
matriz = [[1, 2, 3],
          [4, 5, 6],    
            [7, 8, 9]]
resultado = soma_matriz(matriz)
print("A soma dos itens da matriz é:", resultado)   
# Saída esperada: A soma dos itens da matriz é: 45
