##1) Crie uma função semelhante àquela da Codificação
#  11.2, porém que retorne -1 como resposta para 
# quando não encontrar o valor buscado. Esta versão 
# mantém a coerência do tipo do valor retornado em 
# todos os casos, imprescindível em diversas linguagens.
 
def busca_valor(lista, valor):
    for i in range(len(lista)):
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
resultado = busca_valor(lista, valor)
if resultado != -1:
    print(f'Valor encontrado na posição {resultado}')
else:
    print('Valor não encontrado')