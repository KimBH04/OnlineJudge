const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

readline.on('line', function(x){
    if (x == null || x == ''){
        readline.close();
    }

    var arr = x.split(' ').map(function(n){
        return Number(x);
    });

    var n = arr[0];
    arr = arr.slice(1);

    if (n == 1){
        console.log('Jolly');
    }
    else{
        var isJolly = true;
        var jolly = [];
    
        var i;
        for (i = 0; i < n - 1; i++){
            jolly.push(Math.abs(arr[i] - arr[i + 1]));
        }
    
        jolly = jolly.sort(function(a, b){
            return a - b;
        });
        
        loop: for (i = 1; i < n; i++){
            if (jolly[i - 1] != i){
                isJolly = false;
                break loop;
            }
        }

        console.log(isJolly ? 'Jolly' : 'Not jolly');
    }
});