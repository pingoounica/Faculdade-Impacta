#O programa receberá os salários indefinidamente, até 
# que o usuário digite o valor -1 como salário. 
# Então o programa deve seguir o restante do fluxo, 
# calcular a média e exibir todos os salários 
# inferiores, como no cenário 1. Neste caso, será 
# necessário usar while, pois a quantidade de salários 
# não está definida antes da execução do laço.

total_salarios = 0
quantidade = 0
salarios = []
while True:
    salario = float(input("Digite o salário (-1 para encerrar): "))
    if salario == -1:
        break
    salarios.append(salario)
    total_salarios += salario
    quantidade += 1
if quantidade == 0:
    print("Nenhum salário foi inserido.")
else:
    media = total_salarios / quantidade
    print(f"Média dos salários: {media:.2f}")
    print("Salários inferiores à média:")
    for salario in salarios:
        if salario < media:
            print(f"{salario:.2f}")

            