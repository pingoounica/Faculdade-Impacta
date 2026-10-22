from contas_bancarias import ContaPoupanca, ContaInvestimento

# Criação das contas
conta_poupaca = ContaPoupanca('001', 'Vanessa')
conta_investimento = ContaInvestimento('001', 'Vanessa', 'William')

print('\n----Operações na Conta poupança----')
conta_poupaca.depositar(1000)
saque_1 = conta_poupaca.sacar(100)
saque_2 = conta_poupaca.sacar(3000)

print(f'Primeiro saque da poupança: R$ {saque_1}')
print(f'Segundo saque da poupança: R$ {saque_2}')

print('\n----Operações na conta investimento----')
conta_investimento.depositar(500)
saque_3 = conta_investimento.sacar(300)
saque_4 = conta_investimento.sacar(300)

print(f'Primeiro saque da conta investimento: R$ {saque_3}')
print(f'Segundo saque da conta investimento: R$ {saque_4}')
