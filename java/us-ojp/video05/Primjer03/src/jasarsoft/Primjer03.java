
package jasarsoft;

import java.util.Scanner;

public class Primjer03 {

    public static void main(String[] args) {
       
        Scanner s = new Scanner(System.in);
        
        int godinaRodjenja = s.nextInt();
        
        if (godinaRodjenja <= 2000 && godinaRodjenja % 2 == 0){
            System.out.println("1) Rodjeni ste prije 2000. godine, i godina je parna.");
        }else{
            
            if(godinaRodjenja <= 2000){
                System.out.println("2) Rodjeni ste prije 2000. godine.");
            }else{
                System.out.println("3) Rdojeni ste nakon 2000. godine.");
            }
            
            if(godinaRodjenja % 2 == 0){
                System.out.println("4) Rodjeni ste u godini koja je bila parna.");
            } else {
                System.out.println("5) Rodjeni ste u godini koje je bila neparna.");
            }
        }
        
        System.out.println("Program je zavrsen");
    }
    
}
