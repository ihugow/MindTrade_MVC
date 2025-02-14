
//========= HEADER =========

//Aparecimento da linha embaixo do header
window.addEventListener("scroll", function() {
    var header = document.querySelector('.bottom-line');
    header.classList.toggle('roll', window.scrollY > 5);
})

window.addEventListener("scroll", function() {
            var header = document.querySelector('header');
            header.classList.toggle('roll2', window.scrollY > 5);
});

//========= HEADER END =========

// ========= SIDEMENU =========

//Aparecimento e ocultação
function showSidebar() {
    const sidebar = document.querySelector('.side_menu')
    sidebar.style.right = '0'
}

function hideSidebar() {
    const sidebar = document.querySelector('.side_menu')
    sidebar.style.right = '-250px'
}

//Animação do icone de expanção de sub-menus
document.addEventListener('DOMContentLoaded', function () {
    const checkbox = document.getElementById('mat-btn');
    const icon = document.querySelector('#expand_icon');

    checkbox.addEventListener('change', function () {
        if (checkbox.checked) {
            icon.classList.add('rotate');
        } else {
            icon.classList.remove('rotate');
        }
    });
});

// ========= SIDEMENU END =========

