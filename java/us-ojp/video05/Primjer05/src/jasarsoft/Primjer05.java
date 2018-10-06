
package jasarsoft;

import java.util.Scanner;

public class Primjer05 {

    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        System.out.println("Unesite neki realna broj: ");
        
        double broj = s.nextDouble();
        double korijenBroja = Math.sqrt(broj);
        
        if(korijenBroja == 5.0){
            System.out.println("Ispravno");
        } else {
            System.out.println("Nije ispravno");
        }
        
        System.out.println("Kraj programa");
    }
    
}
