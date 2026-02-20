class Tv:
    def __init__(self, tela, resolucao, fabricante, preco):
        self.tela = tela
        self.resolucao = resolucao
        self.fabricante = fabricante
        self.preco = preco
        self.descricao = f'tv {resolucao} {tela} - {fabricante}'

    def atualizar_preco(self, novo_preco):
        self.preco = novo_preco

    def editar_descricao(self):
        pass

    def aplicar_desconto(self, per_desconto):
        novo_preco = self.preco * (1 - per_desconto/100)
        self.preco = novo_preco


tv_1 = Tv(43, 'fullHD', 'Samsung', 2400)
tv_2 = Tv(50, '4K', 'LG', 3200)

print('TV 1: ', vars(tv_1))
print('TV 2: ', vars(tv_2))

print(f'Preço antigo: R$ {tv_1.preco:.2f}')
tv_1.aplicar_desconto(10)
print(f'Preco com desconto: R$ {tv_1.preco:.2f}')

print(f'Preço antigo: R$ {tv_2.preco:.2f}')
tv_2.aplicar_desconto(10)
print(f'Preco com desconto: R$ {tv_2.preco:.2f}')
