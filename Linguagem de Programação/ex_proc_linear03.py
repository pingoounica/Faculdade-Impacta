##Crie uma função semelhante à do exercício anterior,
#  porém que a busca parta do último item e avance
#  até o primeiro.
def busca_valor_reverso(lista, valor):
    for i in range(len(lista)-1, -1, -1):
        if lista[i] == valor:
            return i
    return -1   
lista = []
while True:
    num = int(input('digite um numero: (digite -1 para parar) '))
    if num == -1:
        break
    lista.append(num)
print('lista criada:', lista)
valor = int(input('Digite o valor a ser buscado: '))
resultado = busca_valor_reverso(lista, valor)
if resultado != -1:
    print(f'Valor encontrado na posição {resultado}')
else:
    print('Valor não encontrado')
    