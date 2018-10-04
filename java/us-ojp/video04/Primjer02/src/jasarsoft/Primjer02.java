
package jasarsoft;

import java.util.Scanner;

public class Primjer02 {

    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        System.out.print("Unesite temperaturu u *C: ");
        
        double tempC = s.nextDouble();
        
        double tempF = tempC * 1.8 + 32;
        
        System.out.println("Temperatura u *F je " + tempF);
    }
    
}
