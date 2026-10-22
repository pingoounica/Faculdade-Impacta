##Funçao

def pede_idade():
    idade = int(input('Informe sua idade: '))
    return idade

##Código Principal
idade = pede_idade()
if idade  > 18:
    print('Você tem mais de 18 anos.')
else:
    print('Você tem menos de 18 anos')
