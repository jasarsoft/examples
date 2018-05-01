var x = setInterval(run, 2000);
var i = 0;

function run(){
    document.write('hello');
    i++;
    if(i > 2){
        clearInterval(x);
    }
}