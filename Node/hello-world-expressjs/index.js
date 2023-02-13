const express = require('express');
const app = express();

app.get('/', (req,res) => {
    let resposta = {mensagem: 'Oi, meus lindos'}
    res.json(resposta);
});

app.listen(8080, () => {
    let data = new Date();
    console.log('Servidor node iniciado em: ' + data);
})