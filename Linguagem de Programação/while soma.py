soma = 0
quantidade = 0
n = int(input('Numero: '))
while n != -1:
    soma += n
    quantidade += 1
    n = int(input('Numero: '))   
print(f'Media: {soma/quantidade}')
