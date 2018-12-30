
package primjer01;

public class Primjer01 {

    public static void main(String[] args) {
        
        Automobil a = new Automobil();
        
        a.dopuniGorivo(35.0);
        a.voziPoGradu(3.0);
        a.voziNaOtvorenom(30.0);
        
        System.out.println("Prosjecna potrosnja do sada od posljednje dopune je: " + a.prosjenaPotrosnjaPosljednjeDopune());
        
        a.voziPoGradu(5.6);
        a.voziPoGradu(1.2);
        a.voziNaOtvorenom(100.0);
        
        System.out.println("Prosjecna potrosnja do sada od posljednje dopune je: " + a.prosjenaPotrosnjaPosljednjeDopune());
        
        a.dopuniGorivo(5.0);
        a.voziPoGradu(1.5);
        System.out.println("Prosjecna potrosnja do sada od posljednje dopune je: " + a.prosjenaPotrosnjaPosljednjeDopune());
    }
    
}
