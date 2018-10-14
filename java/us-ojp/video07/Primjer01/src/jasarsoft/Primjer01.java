
package jasarsoft;

import java.util.Scanner;

public class Primjer01 {

    
    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        int izbor = -1;
        
        while (izbor != 0){
            System.out.print("Unesite 0 za prekid: ");
            izbor = s.nextInt();
            s.nextLine();
        }
        
        System.out.println("Kraj!");
    }
    
}
