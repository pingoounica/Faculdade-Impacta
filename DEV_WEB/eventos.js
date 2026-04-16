const txt = document.querySelector('#tx-nome');
const botao = document.getElementById('botao');


function filtra_caracteres(e){
    if (e.key =='0') {
        e.preventDefault();
    }
}

function valida_dados(event){
    if (txt.value.trim() == '') {
        event.preventDefault()
    }
}

txt.addEventListener('keydown', filtra_caracteres);
botao.addEventListener('click', valida_dados)