class Tv:
    def __init__(self, tela, resolucao, fabricante, preco):
        self.tela = tela
        self.resolucao = resolucao
        self.fabricante = fabricante
        self.preco = preco

    @property
    def preco(self):
        return self._preco

    @preco.setter
    def preco(self, valor):
        if valor >= 0:
            self._preco = valor

    def aplicar_desconto(self, per_desconto):
        if 0 <= per_desconto <= 100:
            self._preco *= (1 - per_desconto / 100)


tv_1 = Tv(43, 'fullHD', 'Samsung', 2400)
tv_2 = Tv(50, '4K', 'LG', 3200)

print('TV 1: ', vars(tv_1))
print('TV 2: ', vars(tv_2))


print(tv_1.preco)
print(tv_2.preco)
