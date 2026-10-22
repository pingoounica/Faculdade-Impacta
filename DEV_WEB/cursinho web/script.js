const form = document.querySelector('form');
const usuario = document.querySelector('#tx-usuario');
const email = document.querySelector('#tx-email');

form.addEventListener('submit', function(e) {
    if (usuario.value.trim() === "") {
        e.preventDefault();
        alert('O nome não pode ser vazio');
        return;
    }

    if (email.value.trim() === "") {
        e.preventDefault();
        alert('O email não pode ser vazio');
        return;
    }
});
