## Crie um programa que leia vários salários e
## informe os salários que são inferiores à média dos salários lidos.   

total_salarios = 0
quantidade = int(input("Quantos salários serão inseridos? "))       
salarios = []
for _ in range(quantidade):
    salario = float(input("Digite o salário: "))
    salarios.append(salario)
    total_salarios += salario
media = total_salarios / quantidade
print(f"Média dos salários: {media:.2f}")
print("Salários inferiores à média:")
for salario in salarios:
    if salario < media:
        print(f"{salario:.2f}") 