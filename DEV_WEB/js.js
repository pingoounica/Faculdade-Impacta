const objeto = document.querySelector('div.div1');

const novo_objeto = document.createElement('p');
novo_objeto.textContent = 'JS';
novo_objeto.style.color = 'blue';

const nova_imagem = document.createElement('img');
nova_imagem.src = 'cachorro.webp'
nova_imagem.alt = 'imagem de um cachorro'

objeto.appendChild(novo_objeto)
objeto.appendChild(nova_imagem)