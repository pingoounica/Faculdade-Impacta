## crie um programa que solicite ao usuário
## um numero natural e exiba a sequencia decrescente
## do numero dado ate um

valor = int(input("valor: "))
for i in range(valor, 0 - 1, -1):
    print(i)