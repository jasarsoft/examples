
package primjer01;

/**
 *
 * @author jasarsoft
 */
public class Primjer01 {

    public static void main(String[] args) {
        
        Student s = new Student("Pera", "Peric", "2010800700", "pera.peric.10@sigidunum.rs");
        
        s.evidentirajTest(new Test("Programiranje 1", "1. kolokviji", 30, 20));
        s.evidentirajTest(new Test("Programiranje 1", "2. kolokviji", 30, 16));
        s.evidentirajTest(new Test("Programiranje 1", "Zavrsni ispit", 30, 10));
        s.evidentirajTest(new Test("Baze podataka", "1. kolokviji", 30, 17));
        s.evidentirajTest(new Test("Baze podataka", "2. kolokviji", 30, 11));
        s.evidentirajTest(new Test("Baze podataka", "Zavrsni projekat", 100, 80));
        
        s.prikaziRezultateTesta();
    }
    
}
