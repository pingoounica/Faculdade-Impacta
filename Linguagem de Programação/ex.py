valor = int(input('digite um numero inteiro entre 2 a 15: '))
fat = 1
cont = 0
while cont < valor:
    fat = fat*valor
    cont = cont + 1
print(f'o fatorial é {fat}')
