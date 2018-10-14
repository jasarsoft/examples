
package jasarsoft;

import java.util.Scanner;

public class Primjer02 {

    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        int izbor;
        
        do {
            System.out.print("Unesite 0 za prekid: ");
            izbor = s.nextInt();
            s.nextLine();
        } while (izbor != 0);
        
        System.out.println("Kraj!");
    }
    
}
