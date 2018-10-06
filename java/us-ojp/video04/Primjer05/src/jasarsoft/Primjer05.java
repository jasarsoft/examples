
package jasarsoft;

import java.util.Scanner;

public class Primjer05 {

    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        System.out.print("Unesite neki broj: ");
        
        double x = s.nextDouble();
        
        double f = Math.sqrt(x);
        
        System.out.println("Kvadratni korijen tog broja je: " + f);
        
        f = Math.pow(x, 3.0);
        System.out.println("Kub tog broja je: " + f);
        
        f = Math.abs(x);
        System.out.println("Apsulutna vrijednost: " + f);
        
        f = Math.PI * x;
        System.out.println("Ta vrijednost * PI je " + x);
    }
    
}
