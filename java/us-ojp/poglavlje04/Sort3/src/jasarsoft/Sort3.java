/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;

/**
 *
 * @author jasarsoft
 */
import java.util.*;

public class Sort3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        //ucitavanje tri vrijednosti preko tastature
        Scanner tastatura = new Scanner(System.in);
        System.out.print("Unesite tri broja: ");
        int x = tastatura.nextInt();
        int y = tastatura.nextInt();
        int z = tastatura.nextInt();
        
        //prikazivanje sortirani vrijednosti na ekranu
        System.out.print("Rastuci redosljed unijeti brojeva je: ");
        
        if (x < y && x < z){ //x je na prvom mjestu
            if(y < z)
                System.out.println(x + " " + y + " " + z);
            else
                System.out.println(x + " " + z + " " + y);
        }
        else if (x > y && x > z) { //x je na posljenjem mjestu
            if(y < z)
                System.out.println(y + " " + z + " " + x);
            else
                System.out.println(z + " " + y + " " + x);
        }
        else { //x je u sredini
            if (y < z)
                System.out.println(y + " " + x + " " + z);
            else
                System.out.println(z + " " + x + " " + y);
        }
    }
    
}
