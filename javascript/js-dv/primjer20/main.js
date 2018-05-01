
function Users(name, prezime){
    this.name = name;
    this.prezime = prezime;
    this.info = function(){
        document.write(name + " " + prezime);
    }
}

var danilo = new Users("Danilo", "Vesovic");
var natalija = new Users("Natalija", "Markovic");

danilo.info();
natalija.info();