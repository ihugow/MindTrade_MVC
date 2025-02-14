//Função para os botões de login e cadastro
document.addEventListener('DOMContentLoaded', function () {
    const cadastroBtn = document.querySelector('.cadastro_btn');
    const loginBtn = document.querySelector('.login_btn');

    loginBtn.addEventListener('mouseenter', function () {
        cadastroBtn.style.backgroundColor = '#fff';
        cadastroBtn.style.color = '#000'; // Opcional, se quiser mudar a cor do texto também
    });

    loginBtn.addEventListener('mouseleave', function () {
        cadastroBtn.style.backgroundColor = 'rgb(0, 185, 255)';
        cadastroBtn.style.color = '#fff'; // Opcional, se quiser mudar a cor do texto também
    });
});