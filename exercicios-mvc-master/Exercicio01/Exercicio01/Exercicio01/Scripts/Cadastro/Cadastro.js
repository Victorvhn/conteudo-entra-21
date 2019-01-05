function gerarNumeroMatricula() {
    var data_nascimento = document.getElementById("campo-data-nascimento").value;
    var replace_data_nascimento = data_nascimento.replace(/-/g, "");
    document.getElementById("campo-codigo-matricula").value = replace_data_nascimento + random();
}

function contaFrequencia() {
    var faltas = document.getElementById("campo-faltas").value;
    var conta = ((faltas * 100) / 200);
    var frequencia = 100 - conta
    document.getElementById("campo-frequencia").value = frequencia + "%";
}

function random() {
    return Math.floor(Math.random() * 65536)
}

function media() {
    var nota1 = parseFloat(document.getElementById("campo-nota-1").value);
    var nota2 = parseFloat(document.getElementById("campo-nota-2").value);
    var nota3 = parseFloat(document.getElementById("campo-nota-3").value);
    var media = parseFloat((nota1 + nota2 + nota3) / 3);
    var media_formatada = media.toFixed(2)
    var media_virgula = media_formatada.replace(".", ",");
    document.getElementById("campo-media").value = media_virgula;
}

$(function () {

    $("#campo-nota-1").mask("99,99", {
        autoclear: true
    });

    $("#campo-nota-2").mask("99,99", {
        autoclear: true
    });

    $("#campo-nota-3").mask("99,99", {
        autoclear: true
    });

});

function validarFormulario() {

    if (validarCampoNome() == false) {
        event.preventDefault();
    }

    if (validarCampoNota1() == false) {
        event.preventDefault();
    }

    if (validarCampoNota2() == false) {
        event.preventDefault();
    }

    if (validarCampoNota3() == false) {
        event.preventDefault();
    }

    if (validarFaltas() == false) {
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

function validarCampoNota1() {
    var textoCampoNota1 = parseFloat(document.getElementById("campo-nota-1").value);

    document.getElementById("campo-nota-1").classList.remove("border-success");

    apagarElemento("span-nota-1-menor-0");
    apagarElemento("span-nota-1-maior-10");

    if (textoCampoNota1 < 0) {
        var elementoSpanNota1 = document.createElement("span");
        var texto = document.createTextNode("Deve ser maior/ou 0");
        elementoSpanNota1.id = "span-nota-1-menor-0";
        elementoSpanNota1.appendChild(texto);
        elementoSpanNota1.classList.add("text-danger");
        document.getElementById("div-campo-nota-1").appendChild(elementoSpanNota1);
        document.getElementById("campo-nota-1").classList.add("border-danger");
        return false;
    }

    if (textoCampoNota1 > 10) {
        var elementoSpanNota1 = document.createElement("span");
        var texto = document.createTextNode("Deve ser menor/ou 10");
        elementoSpanNota1.id = "span-nota-1-maior-10";
        elementoSpanNota1.appendChild(texto);
        elementoSpanNota1.classList.add("text-danger");
        document.getElementById("div-campo-nota-1").appendChild(elementoSpanNota1);
        document.getElementById("campo-nota-1").classList.add("border-danger");
        return false;
    }

    if ((textoCampoNota1 >= 0) && (textoCampoNota1 <= 10)) {
        document.getElementById("campo-nota-1").classList.remove("border-danger");
        document.getElementById("campo-nota-1").classList.add("border-success");
        return true;
    }
}

function validarCampoNota2() {
    var textoCampoNota2 = parseFloat(document.getElementById("campo-nota-2").value);

    document.getElementById("campo-nota-2").classList.remove("border-success");

    apagarElemento("span-nota-2-menor-0");
    apagarElemento("span-nota-2-maior-10");

    if (textoCampoNota2 < 0) {
        var elementoSpanNota2 = document.createElement("span");
        var texto = document.createTextNode("Deve ser maior/ou 0");
        elementoSpanNota2.id = "span-nota-2-menor-0";
        elementoSpanNota2.appendChild(texto);
        elementoSpanNota2.classList.add("text-danger");
        document.getElementById("div-campo-nota-2").appendChild(elementoSpanNota2);
        document.getElementById("campo-nota-2").classList.add("border-danger");
        return false;
    }

    if (textoCampoNota2 > 10) {
        var elementoSpanNota2 = document.createElement("span");
        var texto = document.createTextNode("Deve ser menor/ou 10");
        elementoSpanNota2.id = "span-nota-2-maior-10";
        elementoSpanNota2.appendChild(texto);
        elementoSpanNota2.classList.add("text-danger");
        document.getElementById("div-campo-nota-2").appendChild(elementoSpanNota2);
        document.getElementById("campo-nota-2").classList.add("border-danger");
        return false;
    }

    if ((textoCampoNota2 >= 0) && (textoCampoNota2 <= 10)) {
        document.getElementById("campo-nota-2").classList.remove("border-danger");
        document.getElementById("campo-nota-2").classList.add("border-success");
        return true;
    }
}

function validarCampoNota3() {
    var textoCampoNota3 = parseFloat(document.getElementById("campo-nota-3").value);

    document.getElementById("campo-nota-3").classList.remove("border-success");

    apagarElemento("span-nota-3-menor-0");
    apagarElemento("span-nota-3-maior-10");

    if (textoCampoNota3 < 0) {
        var elementoSpanNota3 = document.createElement("span");
        var texto = document.createTextNode("Deve ser maior/ou 0");
        elementoSpanNota3.id = "span-nota-3-menor-0";
        elementoSpanNota3.appendChild(texto);
        elementoSpanNota3.classList.add("text-danger");
        document.getElementById("div-campo-nota-3").appendChild(elementoSpanNota3);
        document.getElementById("campo-nota-3").classList.add("border-danger");
        return false;
    }

    if (textoCampoNota3 > 10) {
        var elementoSpanNota3 = document.createElement("span");
        var texto = document.createTextNode("Deve ser menor/ou 10");
        elementoSpanNota3.id = "span-nota-3-maior-10";
        elementoSpanNota3.appendChild(texto);
        elementoSpanNota3.classList.add("text-danger");
        document.getElementById("div-campo-nota-3").appendChild(elementoSpanNota3);
        document.getElementById("campo-nota-3").classList.add("border-danger");
        return false;
    }

    if ((textoCampoNota3 >= 0) && (textoCampoNota3 <= 10)) {
        document.getElementById("campo-nota-3").classList.remove("border-danger");
        document.getElementById("campo-nota-3").classList.add("border-success");
        return true;
    }
}

function validarFaltas() {
    var textoFaltas = parseInt(document.getElementById("campo-faltas").value);

    document.getElementById("campo-faltas").classList.remove("border-success");

    apagarElemento("span-faltas-menor-0");
    apagarElemento("span-faltas-maior-200");

    if (textoFaltas < 0) {
        var elementoSpanFaltas = document.createElement("span");
        var texto = document.createTextNode("Deve ser no mínimo 0");
        elementoSpanFaltas.id = "span-faltas-menor-0";
        elementoSpanFaltas.appendChild(texto);
        elementoSpanFaltas.classList.add("text-danger");
        document.getElementById("div-campo-faltas").appendChild(elementoSpanFaltas);
        document.getElementById("campo-faltas").classList.add("border-danger");
        return false;
    }

    if (textoFaltas > 200) {
        var elementoSpanFaltas = document.createElement("span");
        var texto = document.createTextNode("Deve ser no máximo 200");
        elementoSpanFaltas.id = "span-faltas-maior-200";
        elementoSpanFaltas.appendChild(texto);
        elementoSpanFaltas.classList.add("text-danger");
        document.getElementById("div-campo-faltas").appendChild(elementoSpanFaltas);
        document.getElementById("campo-faltas").classList.add("border-danger");
        return false;
    }

    if ((textoFaltas > 0) && (textoFaltas < 200)) {
        document.getElementById("campo-faltas").classList.remove("border-danger");
        document.getElementById("campo-faltas").classList.add("border-success");
        return true;
    }
}

function excluir() {
    $("bota-excluir").on('click',
        function () {
            var intervalo = setInterval(function () {
                $('tabela').load('Aluno/Index.cshtml');
            }
            )
        });
}
