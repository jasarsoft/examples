
package jasarsoft;

import java.util.Scanner;

public class Primjer03 {

    public static void main(String[] args) {
       
        Scanner s = new Scanner(System.in);
        
        System.out.print("Unesite temperaturu u *F: ");
        
        double tempF = s.nextDouble();
        
        double tempC = (tempF - 32) / 1.8;
        
        System.out.println("Temperatura u *C je " + tempC);
    }
    
}
