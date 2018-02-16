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

public class Meni {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        //prikazivanje menija na ekranu
        System.out.println("Opcije menija su:");
        System.out.println("\t1. Predjelo");
        System.out.println("\t2. Supe i corbe");
        System.out.println("\t3. Glavno jelo");
        System.out.println("\t4. Salate");
        System.out.println("\t5. Poslastice");
        System.out.println("\t6. Pice");
        System.out.print("Unesite broj opcije koju zelite: ");
        
        //ucitavanje izabrane opcije menija
        Scanner tastatura = new Scanner(System.in);
        int brojOpcije = tastatura.nextInt();
        
        switch(brojOpcije){
            case 1:
                System.out.println("Izabrali ste \"Predjelo\".");
                break;
            case 2:
                System.out.println("Izbarali ste \"Supe i corbe\".");
                break;
            case 3:
                System.out.println("Izabrali ste \"Glavno jelo\".");
                break;
            case 4:
                System.out.println("Izabrali ste \"Salate\".");
                break;
            case 5:
                System.out.println("Izabrali ste \"Poslastice\".");
                break;
            case 6:
                System.out.println("Izabrali ste \"Pice\".");
                break;
            default:
                System.out.println("Greska: pogresna opcija");
                //break;
        }
    }
    
}
