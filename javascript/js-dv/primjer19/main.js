var broj = Math.min(255, 233, 23, 2);
//document.write(broj);

var user = {
    name:       "Danilo",
    prezime:    "Vesovic",
    info:       function(){
        document.write(user.name + " " + user.prezime);
    }
}

var user1 = {
    name:       "Natalija",
    prezime:    "Markovic",
    info:       function(){
        document.write(user1.name + " " + user1.prezime);
    }
}

user.info();
user1.info();
