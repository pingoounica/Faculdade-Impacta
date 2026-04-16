class Carro:
    def __init__(self, cor, quilometragem):
        self.cor = cor
        self.quilometragem = quilometragem

    def __str__(self):
        return f'O carro {self.cor} tem {self.quilometragem} km'


carro_azul = Carro(cor='azul', quilometragem=20000)
carro_vermelho = Carro(cor='vermelho', quilometragem=20000)

for carro in (carro_azul, carro_vermelho):
    print(carro)
