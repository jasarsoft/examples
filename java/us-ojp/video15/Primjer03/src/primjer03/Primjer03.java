
package primjer03;

public class Primjer03 {

    public static void main(String[] args) {
        
        String format = "%-30s%-30s%10d\n";
        
        System.out.print(String.format(format, "Milan", "Tair", 1500));
        System.out.print(String.format(format, "Pera", "Peric", 500));
        System.out.print(String.format(format, "Alexandra", "Tijanic", 200));
        
        System.out.printf(format, "Milica", "Dusic", 2000);
    }
    
}
