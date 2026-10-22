sexo = input("Por favor, digite seu sexo (M/F): ").strip().upper()
while sexo not in ('M', 'F'):
    print("Sexo invalido. Por favor, digite M ou F.")
    sexo = input("Por favor, digite seu sexo (M/F): ").strip().upper()
if sexo == 'M':
    print("Sexo MASCULINO registrado com sucesso.")
elif sexo == 'F':
    print("Sexo FEMININO registrado com sucesso.")
