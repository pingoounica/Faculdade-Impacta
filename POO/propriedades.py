class Teste:
    def __init__(self):
        self.__nome = 0

        @property
        def nome(self):
            return self.__nome

        @nome.setter
        def nome(self, novo_nome):
            self.nome = novo_nome
