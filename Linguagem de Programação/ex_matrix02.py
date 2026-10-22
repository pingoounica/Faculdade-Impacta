def matriz_oposta(matriz):
    matriz_invertida = []
    for i in range(len(matriz)):
        linha_invertida = []
        for j in range(len(matriz[i])):
            linha_invertida.append(-matriz[i][j])
        matriz_invertida.append(linha_invertida)  # adiciona a linha à matriz
    return matriz_invertida  # retorna a matriz oposta


# Exemplo de uso:
matriz = [[1, -2, 3],
          [-4, 5, -6],
          [7, -8, 9]]

resultado = matriz_oposta(matriz)
print("Matriz oposta:")
for linha in resultado:
    print(linha)
