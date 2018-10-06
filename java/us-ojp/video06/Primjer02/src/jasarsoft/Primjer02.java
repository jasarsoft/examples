
package jasarsoft;

import java.util.Scanner;

public class Primjer02 {

    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        for(int i = 0; i < 10; i++){
            System.out.println("Unesite neki broj: ");
            int broj = s.nextInt();
            
            if(broj % 2 == 0){
                System.out.println("Unijeli ste paran broj.");
            } else{
                System.out.println("Unijeli ste neparan broj.");
            }
        }
        
        System.out.println("Program zavrsen.");
    }
    
}
