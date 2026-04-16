x =int(input('Digite um valor: '))
y =int(input('Digite outro valor: '))
operacao = 0
while operacao !=5:
    print('''Escolha a operacao:
    [1] Somar
    [2] Multiplicar
    [3] Maior
    [4] Novos numeros
    [5] Sair do programa''')
    operacao = int(input('Qual operacao voce deseja fazer? '))
    if operacao == 1:
        print(f'A soma entre {x} e {y} eh {x+y}')
    elif operacao == 2:
        print(f'O produto entre {x} e {y} eh {x*y}')
    elif operacao == 3:
        if x>y:
            print(f'O maior numero entre {x} e {y} eh {x}')
        elif y>x:
            print(f'O maior numero entre {x} e {y} eh {y}')
        else:
            print('Os dois numeros sao iguais.')
    elif operacao == 4:
        x =int(input('Digite um valor: '))
        y =int(input('Digite outro valor: '))
    elif operacao == 5:
        print('Finalizando...')
    else:
        print('Operacao invalida. Tente novamente.')