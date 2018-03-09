/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;
import java.util.*;

/**
 *
 * @author jasarsoft
 */
public class Glasanje {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner tastatura = new Scanner(System.in);
        
        //ucitavanje ukupnog broja partija
        System.out.print("Unesite ukupan broj partija: ");
        int brojPartija = tastatura.nextInt();
        
        //konstruisanje niza partija za sabiranje glasova
        int[] partija = new int[brojPartija];
        
        //ucitavanje glasova za pojedinacne partije
        for(;;){ //beskonacna petlja
            System.out.print("Redni broj partije kojoj ide glas> ");
            int p = tastatura.nextInt();
            
            if (p < 1 || p > brojPartija)
                break;
            else
                partija[p-1] = partija[p-1] + 1;
        }
       
        //prikazivanje osvojenih glasova svih partija
        for(int i = 0; i < partija.length; i++){
            System.out.print("Partija pod rednim brojem " + (i+1));
            System.out.println(" ima "  + partija[i] + " glasova.");
        }
    }
    
}
