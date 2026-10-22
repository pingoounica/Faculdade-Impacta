valor_item = float(input('Digite o valor: '))
unidades = int(input('Digite a quantidade comprada: '))

total = valor_item * unidades
desconto = total * 0.10
total_final = total - desconto

print(f'Total com desconto: R$ {total_final}')