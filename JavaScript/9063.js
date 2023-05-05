const readline = require('readline').createInterface({
    input:process.stdin,
    output:process.stdout,
});
var n;
readline.on('line', function(x){
    n = Number(x);
    readline.close();
});