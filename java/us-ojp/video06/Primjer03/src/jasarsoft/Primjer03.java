
package jasarsoft;

import java.util.Scanner;

public class Primjer03 {

    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        int tajniBroj = 54;
        
        for(int i = 0; i < 10; i++){
            System.out.println("Unesite neki broj: ");
            int broj = s.nextInt();
            
            if(broj == tajniBroj){
                System.out.println("Pogodak!");
                break;
            } else {
                if(tajniBroj < broj){
                    System.out.println("Tajni broj je manji.");
                } else {
                    System.out.println("Tajni broj je veci.");
                }
            }
        }
    }
    
}
