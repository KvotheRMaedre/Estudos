let dados = require('./frases');

function retornaFraseDodia(dia) {
    return dados.frases[dia - 1];
}

exports.retornaFraseDodia = retornaFraseDodia;