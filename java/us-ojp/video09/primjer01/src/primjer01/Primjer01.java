
import java.util.Scanner;


public class Primjer01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
        Scanner s = new Scanner(System.in);
        
        System.out.print("Koliko elemenata ce te unijeti? ");
        int n = s.nextInt();
        
        int[] niz = new int[n];
        
        for(int i = 0; i < niz.length; i++) {
            System.out.print("Unesite sljedeci broj: ");
            niz[i] = s.nextInt();
        }
        
        int suma = 0;
        
        for (int i = 0; i < niz.length; i++) {
            suma += niz[i];
        }
        
        double srednjaVrijednost = 1.0 * suma / niz.length;
        
        System.out.println("Srednja vrijednost je: " + srednjaVrijednost);
        
    }
    
}
