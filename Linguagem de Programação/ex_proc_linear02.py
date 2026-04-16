##Crie uma função semelhante àquela da Codificação 
# 11.2, porém que o valor de retorno seja uma lista
#  com os índices de todos os itens iguais ao valor
#  buscado.
def busca_todos_indices(lista, valor):
    indices = []
    for i in range(len(lista)):
        if lista[i] == valor:
            indices.append(i)
    return indices
lista = []
while True:
    num = int(input('digite um numero: (digite -1 para parar) '))
    if num == -1:
        break
    lista.append(num)
print('lista criada:', lista)
valor = int(input('Digite o valor a ser buscado: '))
resultado = busca_todos_indices(lista, valor)
if resultado:
    print(f'Valor encontrado nas posições {resultado}')
else:
    print('Valor não encontrado')
    