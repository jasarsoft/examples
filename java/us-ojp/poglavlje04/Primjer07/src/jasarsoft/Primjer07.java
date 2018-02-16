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

public class Primjer07 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner tastatura = new Scanner(System.in);
        
        while (true) { //beskonacna petlja
            System.out.print("Unesite pozitivan broj: ");
            
            int broj = tastatura.nextInt();
            if (broj > 0) //unijeti broj je ok, prekinuti petlju
                break;
            
            System.out.println("Greska, morate unijet broj > 0");
        }
    }
    
}
