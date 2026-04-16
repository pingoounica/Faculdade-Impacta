import math

while True:
    n = float(input('Numero: '))
    if n < 0:
        print('Numero negativo. Fim.')
        break
    print(f'Raiz quadrada: {math.sqrt(n)}')
    