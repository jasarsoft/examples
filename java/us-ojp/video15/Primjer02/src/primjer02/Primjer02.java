
package primjer02;

public class Primjer02 {

    public static void main(String[] args) {
        
        String format = "Vrijednost je %10.2f";
        String ispis = String.format(format, 4563.83924);
        
        System.out.println(ispis);
    }
    
}
