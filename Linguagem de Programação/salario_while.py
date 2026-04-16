salarios = []

while True:
    salario = float(input(f"Digite um salario para encerrar: "))
    if salario == -1:
        break
    salarios.append(salario)

if len(salarios) > 0:
    media = sum(salarios) / len(salarios)
    print(f"A media salarial é {media:.2f}")