const express = require('express');

const server = express();

server.get('/', (req, res) => {
    res.send('Express');
});

server.get('/about', (req, res) => {
    res.send('Relembrando algumas coisas do ecma 6');
});

server.listen(4242, () => {
    console.log('Server is running ...');
})