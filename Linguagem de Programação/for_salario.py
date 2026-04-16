qtd = int(input("Quantos salarios?"))
salarios = []

for i in range(qtd):
    salario = float(input(f"Digite o {i+1} salario: "))
    salarios.append(salario)

media = sum(salarios) / len(salarios)
print(f"A media salarial é {media:.2f}")