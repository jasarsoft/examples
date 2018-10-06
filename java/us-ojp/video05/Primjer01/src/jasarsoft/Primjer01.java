
package jasarsoft;

import java.util.Scanner;


public class Primjer01 {

    public static void main(String[] args) {
        
        Scanner s = new Scanner(System.in);
        
        int godinaRodjenja = s.nextInt();
        
        if (godinaRodjenja % 2 == 0){
            System.out.println("Godina rodjenja koju ste unijeli e parna.");
        }else{
            System.out.println("Godina rodjenja koju ste unijeli je neparna");
        }
        
        System.out.println("Program je zavrsen");
    }
    
}
