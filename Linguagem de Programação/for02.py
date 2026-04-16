## Crie um programa que solicite ao usuario um número
## natural e exiba a sequencia crescente de zero ate o numero 
## dado, somente os pares

valor = int(input("valor: "))
for i in range(0, valor + 1, 2):
    print(i)