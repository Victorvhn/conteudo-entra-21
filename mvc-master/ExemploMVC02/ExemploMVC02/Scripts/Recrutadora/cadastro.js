﻿function validarFormulario() {

    var textoCampoCPF = document.getElementById("campo-cpf").value;
    var textoCampoSalario = document.getElementById("campo-salario").value;
    var textoCampoTempoEspera = document.getElementById("campo-tempo-empresa").value;

    if (validarCampoNome() == false) {
        event.preventDefault();
    }

}

function apagarElemento(id) {

    if (document.contains(document.getElementById(id))) {
        document.getElementById(id).remove();
    }

}

function validarCampoNome() {

    var textoCampoNome = document.getElementById("campo-nome").value;

    document.getElementById("campo-nome").classList.remove("border-success");

    apagarElemento("span-campo-nome-menor-7");
    apagarElemento("span-campo-nome-maior-100");

    if (textoCampoNome.length < 7) {

        var elementoSpanNome = document.createElement("span");
        var texto = document.createTextNode("Campo nome deve conter no mínimo 7 caracteres");
        elementoSpanNome.id = "span-campo-nome-menor-7";
        elementoSpanNome.appendChild(texto);
        elementoSpanNome.classList.add("text-danger");
        document.getElementById("div-campo-nome").appendChild(elementoSpanNome);
        document.getElementById("campo-nome").classList.add("border-danger");
        return false;

    }

    if (textoCampoNome.length > 100) {

        var elementoSpanNome = document.createElement("span");
        elementoSpanNome.textContent = "Nome deve conter no máximo 100 caracteres";
        elementoSpanNome.id = "span-campo-nome-maior-100";
        elementoSpanNome.classList.add("text-danger");
        document.getElementById("div-campo-nome").appendChild(elementoSpanNome);
        document.getElementById("campo-nome").classList.add("border-danger");
        return false;

    }

    if ((textoCampoNome.length >= 7) && (textoCampoNome.length <= 100)) {
        document.getElementById("campo-nome").classList.remove("border-danger");
        document.getElementById("campo-nome").classList.add("border-success");
        return true;
    }

}