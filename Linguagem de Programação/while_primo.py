n = int(input('Numero: '))
while n >=1:
    for x in range(2,n):
        if n % x == 0:
            print(f'{n} nao eh primo')
            n = int(input('Numero: '))
            break
    else:
        print(f'{n} eh primo')
        n = int(input('Numero: ')) 