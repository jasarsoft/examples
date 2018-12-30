
import java.util.Scanner;


public class Primjer02 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
                
        double[] niz = new double[10];
        
        for(int i = 0; i < niz.length; i++) {
            System.out.print("Unesite sljedeci broj: ");
            niz[i] = s.nextDouble();
        }
        
        double min = Double.MAX_VALUE;
        double max = Double.MIN_VALUE;
        
        for (int i = 0; i < niz.length; i++) {
            
            if (niz[i] < min) {
                min = niz[i];
            }
            
            if (niz[i] > max) {
                max = niz[i];
            }
        }
        
        
        System.out.println("Najmanja vrijednost u nizu je: " + min);
        System.out.println("Najveca vrijednost u nizu je: " + max);
    }
    
}
