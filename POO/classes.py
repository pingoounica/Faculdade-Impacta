class Livro:
    def __init__(self, nome, autor):
        self.nome = nome
        self.autor = autor

    def identidade(self):
        return (f'Sou o livro {self.nome}, e estou salvo'
                f'no endereço de memoria: {id(self)}')


livro_1 = Livro('Harry Potter', 'J.K. Rolling')
livro_2 = Livro('The Lord of the Rings', 'J.R.R. Tolkien')
livro_3 = Livro('Game of Thrones', 'J.R. Martin')
livro_4 = Livro('The Hobbit', 'J.R.R. Tolkien')

print('livro 1: ', vars(livro_1))
print('livro 2: ', vars(livro_2))
print('livro 3: ', vars(livro_3))
print('livro 4: ', vars(livro_4))
