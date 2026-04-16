#Crie um programa que leia um número natural n dado pelo usuário e exiba só os n primeiros pares a partir do 0. Por exemplo, se n=6 será exibido 0 2 4 6 8 10.
n = int(input('Numero: '))
contador = 0    
x = 0
while contador < n:
    print(x)
    x += 2
    contador += 1   
    