soma = 0

while soma < 21:

    carta = int(input('Digite o valor da carta: '))

    soma += carta
    pausa = input('parar de pegar cartas? (Y/N) ')
    if pausa.upper() == "Y":
        break
print(f'Seu resultado é: {soma}')
