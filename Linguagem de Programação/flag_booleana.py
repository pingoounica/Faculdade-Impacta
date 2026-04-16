total = 0
quero_comprar = True
while quero_comprar:
    preco = float(input('Preco: '))
    total += preco
    resposta = input('Quer continuar? (s/n) ')
    if resposta == 'n':
        quero_comprar = False

print(f'Total: {total:.2f}')