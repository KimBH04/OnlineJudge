const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

readline.on('line', function(x){
    console.log(x.charCodeAt(0));
    readline.close();
});