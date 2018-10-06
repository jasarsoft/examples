
package jasarsoft;

import java.util.Scanner;

public class Primjer02 {

    public static void main(String[] args) {
       
        Scanner s = new Scanner(System.in);
        
        int godinaRodjenja = s.nextInt();
        
        if (2000 <= godinaRodjenja){
            System.out.println("Rodjeni ste nakon 2000. godine");
        }else{
            System.out.println("Rodjeni ste prije 2000. godine");
        }
        
        System.out.println("Program je zavrsen");
    }
    
}
