const fs = require('fs');

fs.readFile(__filename, function cb(err,data){
    console.log(data);
});

console.log('Hi');
