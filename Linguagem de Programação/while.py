p = int(input('p: '))
q = int(input('q: '))
contador = 0
while p >= q:
    p -= q
    contador += 1
print(f'O quociente é {contador} e o resto é {p}.')
