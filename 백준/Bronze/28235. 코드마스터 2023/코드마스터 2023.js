const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

readline.on('line', function(x){
    switch (x)
    {
        case "SONGDO":
            console.log("HIGHSCHOOL");
            break;
            
        case "CODE":
            console.log("MASTER");
            break;
            
        case "2023":
            console.log("0611");
            break;
            
        case "ALGORITHM":
            console.log("CONTEST");
            break;
    }
    readline.close();
});