package primjer01;

import java.util.Scanner;

public class Primjer01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        System.out.print("Unesi prvi broj: ");
        int prviBroj = s.nextInt();
        
        System.out.print("Unesi drugi broj: ");
        int drugiBroj = s.nextInt();
        
        System.out.print("Unesi treci broj: ");
        int treciBroj = s.nextInt();
        
        System.out.print("Unesi cetvrti broj: ");
        int cetvrtiBroj = s.nextInt();
        
        int najmanji = minimumCetiriBroja(prviBroj, prviBroj, treciBroj, cetvrtiBroj);
        
        System.out.println("Najmanji je: " + najmanji);
    }
    
    public static int minimumDvaBroja(int a, int b) {
        if(a < b) {
            return a;
        } else {
            return b;
        }
    }
    
    public static int minimumTriBroja(int a, int b, int c) {
        return minimumDvaBroja(minimumDvaBroja(a, b), c);
    }
    
    public static int minimumCetiriBroja(int a, int b, int c, int d) {
        return minimumDvaBroja(minimumDvaBroja(a, b), minimumDvaBroja(c, d));
    }
}
