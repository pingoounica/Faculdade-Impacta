from heranca import Mae, Filha, Neta

print('criando o objeto mae')
mae = Mae(1)

print('\ncriando o objeto filha')
filha = Filha(1, 2)

print('\ncriando o objeto neta')
neta = Neta(1, 2, 3)

print('\nVisualizando os objetos')
print('mae', vars(mae))
print('filha', vars(filha))
print('neta', vars(neta))
