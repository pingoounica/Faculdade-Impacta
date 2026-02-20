def dobrar(x):
    return 2 * x


def triplicar(x):
    triplo = 3 * x
    return triplo


n1 = float(input('digite um numero: '))
dobro = dobrar(n1)
print(f'o dobro é: {dobro}')
print(f'o triplo é: {triplicar(n1)}')
