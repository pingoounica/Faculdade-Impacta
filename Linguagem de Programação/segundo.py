idade = int(input('sua idade:'))
tempo_cnh = int(input('tempo de carta: '))

aliquota = 0.05

if idade < 25:
    aliquota += 0.03
if tempo_cnh < 2:
    aliquota += 0.02
print(f'sua aliquota é: {aliquota: .1%}')
