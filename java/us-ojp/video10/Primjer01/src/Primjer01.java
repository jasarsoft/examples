
import java.util.Arrays;


public class Primjer01 {

    public enum Poredak {RASTUCI, OPADAJUCI };
    
    public static void sortirajNiz(double[] niz, Poredak p) {
        for (int i = 0; i < niz.length - 1; i++) {
            for (int j = 0; j < niz.length - 1; j++) {
                
                if (p == Poredak.RASTUCI) {
                    if (niz[j] > niz[j+1]) {
                        double tmp = niz[j];
                        niz[j] = niz[j+1];
                        niz[j+1] = tmp;
                    }
                } else if (p == Poredak.OPADAJUCI) {
                    if (niz[j] < niz[j+1]) {
                        double tmp = niz[j];
                        niz[j] = niz[j+1];
                        niz[j+1] = tmp;
                    }
                }
            }
        }
    }
    
    public static void main(String[] args) {
        
        double[] niz = {3.6, 7.8, 1.5 };
        
        System.out.println("Niz je bio: " + Arrays.toString(niz));
        
        sortirajNiz(niz, Poredak.RASTUCI);
        
        System.out.println("Sortiran niz: " + Arrays.toString(niz));
    }
    
}
