//Função para os botões de login e cadastro
document.addEventListener('DOMContentLoaded', function () {
    const cadastroBtn = document.querySelector('.cadastro_btn');
    const loginBtn = document.querySelector('.login_btn');

    cadastroBtn.addEventListener('mouseenter', function () {
        loginBtn.style.backgroundColor = '#fff';
        loginBtn.style.color = '#000'; // Opcional, se quiser mudar a cor do texto também
    });

    cadastroBtn.addEventListener('mouseleave', function () {
        loginBtn.style.backgroundColor = 'rgb(0, 185, 255)';
        loginBtn.style.color = '#fff'; // Opcional, se quiser mudar a cor do texto também
    });
});