def exibe_nome():
    print(f'O nome deste modulo é: {__name__!r}')


if __name__ == '__main__':
    print('ola')
    nome = input('digite seu nome: ')
    exibe_nome()
