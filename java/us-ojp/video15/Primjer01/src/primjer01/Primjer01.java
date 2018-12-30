
package primjer01;

public class Primjer01 {

    public static void main(String[] args) {
        
        String format = "Vrijednost je %10d";
        String ispis = String.format(format, 456);
        
        System.out.println(ispis);
    }
    
}
