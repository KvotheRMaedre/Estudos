const os = require('os');

console.log(os.plataform());
console.log(os.arch());
console.log(os.cpus().length);
console.log(os.homedir());
console.log('Line One' + os.EOL + 'Line Two');