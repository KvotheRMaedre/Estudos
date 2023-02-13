const express = require('express');
const app = express();

let fraseDoDia = require('./fraseDoDia');

let data = new Date();

app.get('/fraseDoDia', (req, res) => {
    let dia = data.getDate();
    let fraseEscolhida = fraseDoDia.retornaFraseDodia(dia);

    res.json({mensagem: fraseEscolhida});
});

app.listen(8080, () => {
})